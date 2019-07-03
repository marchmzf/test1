using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //[DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        //static extern int MsgBox(int hWnd, string msg, string caption, int type);
        [DllImport("NISEC_SKPC.dll")]
        static extern void OperateDisk(string sInputInfo,out string sOutputInfo);
        private void button1_Click(object sender, EventArgs e)
        {
            
            string s ;
            string t = "<?xml version='1.0' encoding='gbk'?>"
         + "<business comment='税控盘信息查询' id='SKPXXCX'>"
         + "<body yylxdm='1'>"
         + "<input>"
         + "<skpkl>88888888</skpkl>"
         + "</input>"
         + "</body>"
         + "</business>";
            OperateDisk(t,out s);
            textBox1.Text = s;
        }
    }
}
