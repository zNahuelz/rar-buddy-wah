namespace RarBuddy
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tcMain = new ReaLTaiizor.Controls.ForeverTabPage();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.TxtPath = new ReaLTaiizor.Controls.ForeverTextBox();
            this.BtnActivate = new ReaLTaiizor.Controls.ForeverButton();
            this.BtnSearch = new ReaLTaiizor.Controls.ForeverButton();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.LblName = new ReaLTaiizor.Controls.LostLabel();
            this.LblGitHub = new ReaLTaiizor.Controls.LostLabel();
            this.LblDevName = new ReaLTaiizor.Controls.LostLabel();
            this.PbDevIcon = new System.Windows.Forms.PictureBox();
            this.StatusBar = new ReaLTaiizor.Controls.SkyStatusBar();
            this.tcMain.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.AboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDevIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tcMain.ActiveFontColor = System.Drawing.Color.White;
            this.tcMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tcMain.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tcMain.Controls.Add(this.HomeTab);
            this.tcMain.Controls.Add(this.AboutTab);
            this.tcMain.DeactiveFontColor = System.Drawing.Color.White;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tcMain.ItemSize = new System.Drawing.Size(120, 40);
            this.tcMain.Location = new System.Drawing.Point(11, 39);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(328, 284);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.HomeTab.Controls.Add(this.PbLogo);
            this.HomeTab.Controls.Add(this.TxtPath);
            this.HomeTab.Controls.Add(this.BtnActivate);
            this.HomeTab.Controls.Add(this.BtnSearch);
            this.HomeTab.Location = new System.Drawing.Point(4, 44);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeTab.Size = new System.Drawing.Size(320, 236);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "HOME";
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::RarBuddy.Properties.Resources.logo;
            this.PbLogo.Location = new System.Drawing.Point(111, 7);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(99, 88);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 3;
            this.PbLogo.TabStop = false;
            // 
            // TxtPath
            // 
            this.TxtPath.BackColor = System.Drawing.Color.Transparent;
            this.TxtPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TxtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.TxtPath.Enabled = false;
            this.TxtPath.FocusOnHover = false;
            this.TxtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TxtPath.Location = new System.Drawing.Point(33, 99);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPath.MaxLength = 32767;
            this.TxtPath.Multiline = false;
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(255, 29);
            this.TxtPath.TabIndex = 2;
            this.TxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPath.UseSystemPasswordChar = false;
            // 
            // BtnActivate
            // 
            this.BtnActivate.BackColor = System.Drawing.Color.Transparent;
            this.BtnActivate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.BtnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActivate.Enabled = false;
            this.BtnActivate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnActivate.Location = new System.Drawing.Point(89, 182);
            this.BtnActivate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Rounded = false;
            this.BtnActivate.Size = new System.Drawing.Size(145, 37);
            this.BtnActivate.TabIndex = 1;
            this.BtnActivate.Text = "ACTIVATE";
            this.BtnActivate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSearch.Location = new System.Drawing.Point(89, 141);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rounded = false;
            this.BtnSearch.Size = new System.Drawing.Size(145, 37);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.Text = "SET PATH";
            this.BtnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // AboutTab
            // 
            this.AboutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AboutTab.Controls.Add(this.LblName);
            this.AboutTab.Controls.Add(this.LblGitHub);
            this.AboutTab.Controls.Add(this.LblDevName);
            this.AboutTab.Controls.Add(this.PbDevIcon);
            this.AboutTab.Location = new System.Drawing.Point(4, 44);
            this.AboutTab.Margin = new System.Windows.Forms.Padding(2);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(2);
            this.AboutTab.Size = new System.Drawing.Size(320, 236);
            this.AboutTab.TabIndex = 1;
            this.AboutTab.Text = "ABOUT";
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(38, 7);
            this.LblName.Margin = new System.Windows.Forms.Padding(2);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(245, 23);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "RARBuddy - v1.0 (ex WinACTV)";
            // 
            // LblGitHub
            // 
            this.LblGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LblGitHub.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LblGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblGitHub.Location = new System.Drawing.Point(56, 193);
            this.LblGitHub.Margin = new System.Windows.Forms.Padding(2);
            this.LblGitHub.Name = "LblGitHub";
            this.LblGitHub.Size = new System.Drawing.Size(215, 27);
            this.LblGitHub.TabIndex = 2;
            this.LblGitHub.Text = "GitHub Profile (Click Here!)";
            this.LblGitHub.Click += new System.EventHandler(this.LblGitHub_Click);
            // 
            // LblDevName
            // 
            this.LblDevName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LblDevName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblDevName.ForeColor = System.Drawing.Color.White;
            this.LblDevName.Location = new System.Drawing.Point(81, 166);
            this.LblDevName.Margin = new System.Windows.Forms.Padding(2);
            this.LblDevName.Name = "LblDevName";
            this.LblDevName.Size = new System.Drawing.Size(157, 23);
            this.LblDevName.TabIndex = 1;
            this.LblDevName.Text = "Created By: zNahuelz";
            // 
            // PbDevIcon
            // 
            this.PbDevIcon.Image = global::RarBuddy.Properties.Resources._6667878;
            this.PbDevIcon.Location = new System.Drawing.Point(104, 45);
            this.PbDevIcon.Margin = new System.Windows.Forms.Padding(2);
            this.PbDevIcon.Name = "PbDevIcon";
            this.PbDevIcon.Size = new System.Drawing.Size(134, 117);
            this.PbDevIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbDevIcon.TabIndex = 0;
            this.PbDevIcon.TabStop = false;
            // 
            // StatusBar
            // 
            this.StatusBar.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.StatusBar.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.StatusBar.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StatusBar.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.StatusBar.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.StatusBar.Location = new System.Drawing.Point(0, 327);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(350, 23);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "Welcome! Select WinRAR path to begin.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::RarBuddy.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(3637, 293, 3637, 293);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RARBuddy : WinRAR Activator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcMain.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.AboutTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbDevIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ForeverTabPage tcMain;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage AboutTab;
        private ReaLTaiizor.Controls.ForeverButton BtnActivate;
        private ReaLTaiizor.Controls.ForeverButton BtnSearch;
        private ReaLTaiizor.Controls.ForeverTextBox TxtPath;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.PictureBox PbDevIcon;
        private ReaLTaiizor.Controls.LostLabel LblDevName;
        private ReaLTaiizor.Controls.LostLabel LblGitHub;
        private ReaLTaiizor.Controls.LostLabel LblName;
        private ReaLTaiizor.Controls.SkyStatusBar StatusBar;
    }
}