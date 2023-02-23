namespace WinACTV
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnSr = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.linkLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(6, 44);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(291, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(114, 117);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 1;
            this.btnAct.Text = "ACTIVAR";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnSr
            // 
            this.btnSr.Location = new System.Drawing.Point(84, 88);
            this.btnSr.Name = "btnSr";
            this.btnSr.Size = new System.Drawing.Size(135, 23);
            this.btnSr.TabIndex = 0;
            this.btnSr.Text = "SELECCIONAR RUTA";
            this.btnSr.UseVisualStyleBackColor = true;
            this.btnSr.Click += new System.EventHandler(this.btnSr_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.ssMain.Location = new System.Drawing.Point(0, 194);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(335, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.Text = "<----->";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(311, 172);
            this.tcMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAct);
            this.tabPage1.Controls.Add(this.txtRuta);
            this.tabPage1.Controls.Add(this.btnSr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(303, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLbl);
            this.tabPage2.Controls.Add(this.lbl2);
            this.tabPage2.Controls.Add(this.lbl1);
            this.tabPage2.Controls.Add(this.pbMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acerca de";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbMain
            // 
            this.pbMain.Image = global::WinACTV.Properties.Resources.YNYDOnOv_400x400;
            this.pbMain.Location = new System.Drawing.Point(7, 7);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(123, 133);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(147, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(138, 14);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Desarrollado por: zNahuelz\r\n";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(139, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(154, 14);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "WinACTv | \"WinRAR Activator\"\r\n";
            // 
            // linkLbl
            // 
            this.linkLbl.AutoSize = true;
            this.linkLbl.Location = new System.Drawing.Point(196, 74);
            this.linkLbl.Name = "linkLbl";
            this.linkLbl.Size = new System.Drawing.Size(40, 13);
            this.linkLbl.TabIndex = 3;
            this.linkLbl.TabStop = true;
            this.linkLbl.Text = "GitHub";
            this.linkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RUTA WinRAR";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 216);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinACTv - v0.2";
            this.Load += new System.EventHandler(this.main_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnSr;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.LinkLabel linkLbl;
        private System.Windows.Forms.Label label1;
    }
}

