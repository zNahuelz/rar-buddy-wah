using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RarBuddy
{
    public partial class Main : ReaLTaiizor.Forms.LostForm
    {
        private readonly List<string> Key = new List<string>()
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

        private string Path = "";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!IsRunningAsAdmin())
            {
                MessageBox.Show("Ups! This tool needs to be executed as administrator. Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                BtnSearch.Enabled = true;
                BtnActivate.Enabled = false;
                StatusBar.Text = "Select WinRAR path to begin.";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SelectPath();
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            ApplyKey(Path);
        }

        private void LblGitHub_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zNahuelz");
            }
            catch
            {
                return;
            }
        }

        private bool IsRunningAsAdmin()
        {
            bool isAdmin;
            using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                isAdmin = principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            return isAdmin;
        }

        private void SelectPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Path = dialog.SelectedPath;
                TxtPath.Text = Path;
                if (WinRARExists(Path))
                {
                    MessageBox.Show("WinRAR.exe found in the selected directory. You can activate now...!", "WinRAR Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSearch.Enabled = false;
                    BtnActivate.Enabled = true;
                }
                else
                {
                    Path = "";
                    TxtPath.Text = "";
                    MessageBox.Show("WinRAR executable not found in the selected directory. Please select the correct path.", "WinRAR Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ApplyKey(string path)
        {
            string filePath = $"{path}\\rarreg.key";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in Key)
                    {
                        writer.WriteLine(line);
                    }
                }
                if (File.Exists(filePath))
                {
                    MessageBox.Show($"Key file created successfully! You can now use WinRAR without limitations.\nPath: {path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnActivate.Enabled = false;
                    BtnSearch.Enabled = false;
                    StatusBar.Text = $"WinRAR activated at: {path}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the key file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Path = "";
                BtnSearch.Enabled = true;
                BtnActivate.Enabled = false;
                return;
            }
        }

        private bool WinRARExists(string path)
        {
            return File.Exists($"{path}\\WinRAR.exe");
        }
    }
}
