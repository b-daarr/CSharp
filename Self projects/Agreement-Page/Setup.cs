using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace IDET
{
    public partial class LicenseAgreement : Form
    {
        public LicenseAgreement()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (BrowseDialog.ShowDialog() == DialogResult.OK)
            {
                GoInstall.Visible = true;
                textBox1.Visible = true;
                NameShort.Enabled = true;
                NoShortcut.Enabled = true;
                PathInstall.Text = BrowseDialog.SelectedPath;
            }
        }

        protected void INS()
        {
            //Directory.CreateDirectory(PathInstall.Text + @"\TCMD");
            //File.Copy(@"C:\TempPower\Setup", PathInstall.Text + @"\TCMD");
            //File.Delete(@"C:\TempPower");
        }
        protected void SMSh()
        {
            //File.Copy(@"C:\TempPower\TCMD", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");
        }

        protected bool SC = true;

        private void GoInstall_Click(object sender, EventArgs e)
        {


            GoInstall.Enabled = false;
            Accept.Enabled = false;
            NoAccept.Enabled = false;
            Browse.Enabled = false;
            NameShort.Enabled = false;
            NoShortcut.Enabled = false;

            More4.Visible = true;
            InputScale4.Visible = true;
            Percentage.Visible = true;
            Percent.Visible = true;
            ErrorPic.Visible = true;
            ErrorLog.Visible = true;
            textBox1.Visible = false;
            Percent.Text = "Err";

            INS();

            if (SC == true)
            {
                SMSh();
            }

        }

        private void Accept_CheckedChanged(object sender, EventArgs e)
        {
            if (Accept.Checked == true)
            {
                Browse.Enabled = true;
                NoAccept.Checked = false;
            }
        }

        private void NoAccept_CheckedChanged(object sender, EventArgs e)
        {
            if (NoAccept.Checked == true)
            {
                GoInstall.Enabled = false;
                Accept.Checked = false;
            }
        }

        private void NoShortcut_CheckedChanged(object sender, EventArgs e)
        {
            if (NoShortcut.Checked == true)
            {
                NameShort.Enabled = false;
                NameShort.Text = "Without Shurtcut!";
                SC = false;
            }
            else if (NoShortcut.Checked == false)
            {
                NameShort.Enabled = true;
                NameShort.Text = "TelPrompt";
            }
        }

        private void EndWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
