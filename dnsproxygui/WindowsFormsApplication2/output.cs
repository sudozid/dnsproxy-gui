using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace dnsproxygui
{
    public partial class outputform : Form
    {
        public outputform()
        {
            InitializeComponent();
        }

        private void outputform_Shown(object sender, EventArgs e)
        {
            outputTA.Text = "";
            outputTA.Text = finalcommand.command;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String command = outputTA.Text;
            command = command.Replace("dnsproxy ","");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "dnsproxy.exe ";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            try {
                process.Start();
            }
            catch(Win32Exception a)
            {
                MessageBox.Show("File May not Exist?");
            }
            

        }
   
        
    }
}
