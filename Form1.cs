using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msgGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string CMDArg;
            CMDArg = "/C msg " + UsersTxT.Text + " /server:" + ComputerNameTxT.Text + " " + MessageTxT.Text;
            System.Diagnostics.Process.Start("CMD.exe", CMDArg);
        }

        private void ComputerNameTxT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
