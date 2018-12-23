using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Threading;

namespace StdioMQTT
{
    public partial class FrmMain : Form
    {
        private MqttClient mqttClient;
        private bool IsStop { get; set; } = true;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.txtClientId.Text = Guid.NewGuid().ToString();
            Task.Run(() => {
                this.timer1_Tick();
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.mqttClient != null)
            {
                List<string> lst = new List<string>();
                foreach(SubscribeModel model in this.lstSubscribeTopic.Items)
                {
                    lst.Add(model.Topic);
                }
                this.lstSubscribeTopic.Items.Clear();
                if (lst.Count > 0)
                {
                    ushort us = this.mqttClient.Unsubscribe(lst.ToArray());
                }
                this.mqttClient.Disconnect();
            }
            this.mqttClient = new MqttClient(this.txtServer.Text);
            this.mqttClient.ConnectionClosed += MqttClient_ConnectionClosed;
            this.mqttClient.MqttMsgPublished += MqttClient_MqttMsgPublished;
            this.mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            this.mqttClient.MqttMsgSubscribed += MqttClient_MqttMsgSubscribed;
            this.mqttClient.MqttMsgUnsubscribed += MqttClient_MqttMsgUnsubscribed;
            byte success = this.mqttClient.Connect(this.txtClientId.Text);
            if(success != 0 && this.mqttClient.IsConnected)
            {
                this.MsgBox("连接失败！");
                return;
            }
            this.btnConnect.Text = "断开连接";
        }

        private void MqttClient_ConnectionClosed(object sender, EventArgs e)
        {
        }

        private void MqttClient_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            Action action = () => {
               for(int i = 0; i < this.lstSubscribeTopic.Items.Count; i++)
                {
                    SubscribeModel subscribeModel = this.lstSubscribeTopic.Items[i] as SubscribeModel;
                    if(subscribeModel != null && subscribeModel.UnsubscribeId == e.MessageId)
                    {
                        this.lstSubscribeTopic.Items.Remove(subscribeModel);
                        break;
                    }
                }
            };
            this.Invoke(action);
        }

        private void MqttClient_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            byte[] bys = e.GrantedQoSLevels;
            ushort messageId = e.MessageId;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (this.Disposing)
                return;
            byte[] bys = e.Message;
            string content = Encoding.UTF8.GetString(bys);
            string topic = e.Topic;
            bool dupFlag = e.DupFlag;
            byte qosLevel = e.QosLevel;
            bool retain = e.Retain;
            Action action = () =>
            {
                this.rtbRecive.AppendText($"接收时间：{DateTime.Now}{Environment.NewLine}");
                this.rtbRecive.AppendText($"主题：{topic}{Environment.NewLine}");
                this.rtbRecive.AppendText($"内容：{content}{Environment.NewLine}");
                //this.rtbRecive.Focus();
                this.rtbRecive.Select(this.rtbRecive.TextLength, 0);
                this.rtbRecive.ScrollToCaret();
            };
            this.BeginInvoke(action);
        }

        private void MqttClient_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
        }
        private void btnAddSubscribe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSubscribe.Text))
            {
                for(int i = 0; i < this.lstSubscribeTopic.Items.Count; i++)
                {
                    SubscribeModel subscribeModel = this.lstSubscribeTopic.Items[i] as SubscribeModel;
                    if(subscribeModel.Topic == this.txtSubscribe.Text)
                    {
                        this.MsgBox("主题重复了！");
                        return;
                    }
                }
                if (this.mqttClient != null)
                {
                    SubscribeModel subscribeModel = new SubscribeModel(this.txtSubscribe.Text, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE);
                    subscribeModel.Subscribe(this.mqttClient);
                    this.lstSubscribeTopic.Items.Add(subscribeModel);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }

        private void btnSendPublish_Click(object sender, EventArgs e)
        {
            string topic = this.txtPublishTopic.Text;
            string content = this.rtbSendPublish.Text;
            if(!string.IsNullOrEmpty(topic) && !string.IsNullOrEmpty(content))
            {
                byte[] bys = Encoding.UTF8.GetBytes(content);
                ushort? publishId = this.mqttClient?.Publish(topic, bys, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.rtbRecive.Clear();
        }

        private void lstSubscribeTopic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SubscribeModel subscribeModel = this.lstSubscribeTopic.SelectedItem as SubscribeModel;
            if(subscribeModel != null)
            {
                subscribeModel.Unsubscribe(this.mqttClient);
            }
        }

        private void cboPublick_CheckedChanged(object sender, EventArgs e)
        {
            this.IsStop = !this.cboPublick.Checked;
        }

        private void timer1_Tick()
        {
            while (true)
            {
                if (!this.IsStop && this.mqttClient != null && this.mqttClient.IsConnected)
                {
                    Action action = () => {
                        string topic = this.txtPublishTopic.Text;
                        string content = this.rtbSendPublish.Text;
                        if (!string.IsNullOrEmpty(topic) && !string.IsNullOrEmpty(content))
                        {
                            byte[] bys = Encoding.UTF8.GetBytes(content);
                            ushort? publishId = this.mqttClient?.Publish(topic, bys, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);
                        }
                    };
                    this.BeginInvoke(action);
                    Thread.Sleep(100);
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.IsStop = true;
            if (this.mqttClient != null)
            {
                this.mqttClient?.Disconnect();
            }
        }
    }
    /// <summary>
    /// 订阅
    /// </summary>
    public class SubscribeModel
    {
        public string Topic { get; set; }
        public byte Qos { get; set; }
        public ushort MessageId { get; set; }
        public ushort UnsubscribeId { get; set; }
        public SubscribeModel(string topic, byte qos)
        {
            this.Topic = topic;
            this.Qos = qos;
        }
        public void Subscribe(MqttClient mqttClient)
        {
            string[] topics = new string[] { this.Topic };
            byte[] qos = new byte[] { this.Qos };
            this.MessageId = mqttClient.Subscribe(topics, qos);

        }
        public void Unsubscribe(MqttClient mqttClient)
        {
            string[] topics = new string[] { this.Topic };
            this.UnsubscribeId = mqttClient.Unsubscribe(topics);
        }
        public override string ToString()
        {
            return $"主题：{this.Topic},质量：{this.Qos},消息ID:{this.MessageId}";
        }
    }
}
