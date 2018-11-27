using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StdioMQTT
{
    public static class StExtent
    {
        public static void MsgBox(this Control @this, string msg)
        {
            MessageBox.Show(@this, msg);
        }
    }
}
