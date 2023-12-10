namespace WinACTV
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tbpHome = new System.Windows.Forms.TabPage();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tbpAbout = new System.Windows.Forms.TabPage();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.txtslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            this.lblGit = new System.Windows.Forms.Label();
            this.tabcMain.SuspendLayout();
            this.tbpHome.SuspendLayout();
            this.tbpAbout.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tbpHome);
            this.tabcMain.Controls.Add(this.tbpAbout);
            this.tabcMain.Location = new System.Drawing.Point(12, 12);
            this.tabcMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(193, 213);
            this.tabcMain.TabIndex = 0;
            // 
            // tbpHome
            // 
            this.tbpHome.Controls.Add(this.pbHome);
            this.tbpHome.Controls.Add(this.btnActivate);
            this.tbpHome.Controls.Add(this.btnSearch);
            this.tbpHome.Controls.Add(this.txtPath);
            this.tbpHome.Location = new System.Drawing.Point(4, 22);
            this.tbpHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpHome.Name = "tbpHome";
            this.tbpHome.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpHome.Size = new System.Drawing.Size(185, 187);
            this.tbpHome.TabIndex = 0;
            this.tbpHome.Text = "Home";
            this.tbpHome.UseVisualStyleBackColor = true;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(55, 136);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(74, 23);
            this.btnActivate.TabIndex = 2;
            this.btnActivate.Text = "ACTIVATE";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(55, 106);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SET PATH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 71);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(172, 20);
            this.txtPath.TabIndex = 0;
            // 
            // tbpAbout
            // 
            this.tbpAbout.Controls.Add(this.lblGit);
            this.tbpAbout.Controls.Add(this.lblMe);
            this.tbpAbout.Controls.Add(this.lblDesc);
            this.tbpAbout.Controls.Add(this.pbAbout);
            this.tbpAbout.Location = new System.Drawing.Point(4, 22);
            this.tbpAbout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpAbout.Name = "tbpAbout";
            this.tbpAbout.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpAbout.Size = new System.Drawing.Size(185, 187);
            this.tbpAbout.TabIndex = 1;
            this.tbpAbout.Text = "About";
            this.tbpAbout.UseVisualStyleBackColor = true;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtslMain});
            this.stsMain.Location = new System.Drawing.Point(0, 233);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(217, 22);
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "statusStrip1";
            // 
            // txtslMain
            // 
            this.txtslMain.Name = "txtslMain";
            this.txtslMain.Size = new System.Drawing.Size(91, 17);
            this.txtslMain.Text = "<-Something->";
            // 
            // pbHome
            // 
            this.pbHome.Image = global::WinACTV.Properties.Resources._301_3017073_source_mlp_winrar_icon;
            this.pbHome.Location = new System.Drawing.Point(55, 6);
            this.pbHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(74, 59);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 3;
            this.pbHome.TabStop = false;
            // 
            // pbAbout
            // 
            this.pbAbout.Image = global::WinACTV.Properties.Resources.b47312b3460d9bd45e7824346b01d69e;
            this.pbAbout.Location = new System.Drawing.Point(37, 6);
            this.pbAbout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(110, 90);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAbout.TabIndex = 4;
            this.pbAbout.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(5, 171);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(178, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "WinACTV  - WinRAR Activator V1.0";
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Location = new System.Drawing.Point(38, 109);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(108, 13);
            this.lblMe.TabIndex = 6;
            this.lblMe.Text = "Created by: zNahuelz";
            // 
            // lblGit
            // 
            this.lblGit.AutoSize = true;
            this.lblGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGit.Location = new System.Drawing.Point(39, 126);
            this.lblGit.Name = "lblGit";
            this.lblGit.Size = new System.Drawing.Size(106, 13);
            this.lblGit.TabIndex = 7;
            this.lblGit.Text = "GitHub: zNahuelz";
            this.lblGit.Click += new System.EventHandler(this.lblGit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 255);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.tabcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinRAR ACTV.";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabcMain.ResumeLayout(false);
            this.tbpHome.ResumeLayout(false);
            this.tbpHome.PerformLayout();
            this.tbpAbout.ResumeLayout(false);
            this.tbpAbout.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tbpHome;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TabPage tbpAbout;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel txtslMain;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblGit;
        private System.Windows.Forms.Label lblMe;
    }
}

