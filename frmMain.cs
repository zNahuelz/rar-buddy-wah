using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace WinACTV
{
    public partial class frmMain : Form
    {
        private readonly List<string> _key = new List<string>()
        {
            "RAR registration data",
            "Federal Agency for Education",
            "1000000 PC usage license",
            "UID=b621cca9a84bc5deffbf",
            "6412612250ffbf533df6db2dfe8ccc3aae5362c06d54762105357d",
            "5e3b1489e751c76bf6e0640001014be50a52303fed29664b074145",
            "7e567d04159ad8defc3fb6edf32831fd1966f72c21c0c53c02fbbb",
            "2f91cfca671d9c482b11b8ac3281cb21378e85606494da349941fa",
            "e9ee328f12dc73e90b6356b921fbfb8522d6562a6a4b97e8ef6c9f",
            "fb866be1e3826b5aa126a4d2bfe9336ad63003fc0e71c307fc2c60",
            "64416495d4c55a0cc82d402110498da970812063934815d81470829275"
        };

        public string path = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPath.Enabled = false;
            txtPath.ReadOnly = true;
            btnActivate.Enabled = false;
            txtslMain.Text = "Select WinRAR path to begin.";
        }

        public bool PermissionLevel()
        {
            bool admin;
            using (WindowsIdentity i = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal p = new WindowsPrincipal(i);
                admin = p.IsInRole(WindowsBuiltInRole.Administrator);
            }
            if (admin) { return true; }
            else { return false; }
        }

        private void Activate(string path)
        {
            string createFile = path + "\\" + "rarreg.key";
            try
            {
                using (StreamWriter sw = new StreamWriter(createFile))
                {
                    foreach (string s in _key) { sw.WriteLine(s); }
                }
            }
            catch (Exception) { MessageBox.Show("Cann't write on that route. Try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
            if (File.Exists(createFile))
            {
                MessageBox.Show("Done! WinRAR activated.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActivate.Enabled = false;
                btnSearch.Enabled = false;
                txtslMain.Text = "Activated WinRAR on route: " + path;
            }
            else
            {
                MessageBox.Show("Error! Cannot activate WinRAR. Try again...!", "ACTIVATION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnActivate.Enabled = false;
                btnSearch.Enabled = false;
                txtslMain.Text = "Activation failed: Generated key file deleted by an external program. Try again.";
            }
        }

        public void SearchExe()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
                txtPath.Text = path;
            }
            if (File.Exists(path + "\\WinRAR.exe"))
            {
                MessageBox.Show("WinRAR found! You can activate now...!");
                btnSearch.Enabled = false;
                btnActivate.Enabled = true;
            }
            else
            {
                MessageBox.Show("WinRAR was not found on that path, try again!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { SearchExe(); }

        private void btnActivate_Click(object sender, EventArgs e) { Activate(path); }

        private void lblGit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zNahuelz");
            }
            catch (Exception) { MessageBox.Show("It seems like you don't have any web browser installed on this PC."); }
        }
    }
}
