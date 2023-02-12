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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnSr = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain.SuspendLayout();
            this.gb1.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(321, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtRuta);
            this.gb1.Controls.Add(this.btnAct);
            this.gb1.Controls.Add(this.btnSr);
            this.gb1.Location = new System.Drawing.Point(13, 27);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(296, 101);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // btnSr
            // 
            this.btnSr.Location = new System.Drawing.Point(81, 46);
            this.btnSr.Name = "btnSr";
            this.btnSr.Size = new System.Drawing.Size(135, 23);
            this.btnSr.TabIndex = 0;
            this.btnSr.Text = "SELECCIONAR RUTA";
            this.btnSr.UseVisualStyleBackColor = true;
            this.btnSr.Click += new System.EventHandler(this.btnSr_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(109, 72);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 1;
            this.btnAct.Text = "ACTIVAR";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(6, 20);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(284, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.ssMain.Location = new System.Drawing.Point(0, 135);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(321, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.Text = "<----->";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 157);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.msMain;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinACTv - v0.1";
            this.Load += new System.EventHandler(this.main_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnSr;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}

