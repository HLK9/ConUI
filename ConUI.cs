using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace ConUI
{
    public partial class ConUI : MaterialForm
    {
        public ConUI()
        {
            InitializeComponent();

        }

        private void btnRunCus_Click(object sender, EventArgs e)
        {
            Process runCustom = new Process();
            runCustom.StartInfo.FileName = "cmd.exe";
            runCustom.StartInfo.Arguments = "/c " + txtCmdCus.Text;
            runCustom.StartInfo.RedirectStandardOutput = true;
            runCustom.StartInfo.UseShellExecute = false;
            runCustom.StartInfo.CreateNoWindow = true;
            runCustom.Start();
            runCustom.WaitForExit();
            richOutput.Text += "\n"+runCustom.StandardOutput.ReadLine();

        }
    }
}
