using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinACTV
{
    public partial class main : Form
    {
        
        private static readonly List<string> key = new List<string>()
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

        private static readonly List<string> n = new List<string>()
        {
            "winrar","WinRAR","WINRAR","winrar"
        };
        public static bool NivelPermiso()
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

        public static bool CheckCadena(string cadena)
        {
            int num = 0;
            foreach(string i in n)
            {
                if (cadena.Contains(i)) { num += 1; }
            }
            if(num>0) { return true; }
            else { return false; }
        }

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            bool permisos = NivelPermiso();
            if (permisos) 
            {
                txtRuta.ReadOnly = true;
                btnAct.Enabled = false;
                lblEstado.Text = "";
            }
            else
            {
                _ = MessageBox.Show("Debe ejecutar la herramienta con permisos de administrador!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

        private void btnSr_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = fbd.SelectedPath;
                btnAct.Enabled = true;
                btnSr.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ruta");
            }
        

        }
        public string barra = "\\";
        private void btnAct_Click(object sender, EventArgs e)
        {
            string rutaArchivo = txtRuta.Text;
            if (rutaArchivo.Length > 0)
            {
                rutaArchivo += barra+"rarreg.key";
                txtRuta.Text = rutaArchivo;
                using(StreamWriter sw = File.CreateText(rutaArchivo))
                {
                    foreach(string i in key)
                    {
                        sw.WriteLine(i);
                    }
                }
                //Revisar.
                bool estado = CheckCadena(rutaArchivo);
                if (estado)
                {
                    lblEstado.Text = "WinRAR Activado con exito!";
                    btnAct.Enabled = false;
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    lblEstado.Text = "WinRAR Activado con exito!";
                    MessageBox.Show("No se encontro la palabra 'WinRAR' en la ruta especificada. Se recomienda comprobar la activación o volver a intentarlo.","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    btnAct.Enabled = false;
                }

            }
        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zNahuelz");
            }
            catch(Exception ex) { MessageBox.Show("Ups! Parece que no podemos encontrar un navegador web predeterminado." +Environment.NewLine+"Vease el error:"+Environment.NewLine+ex.ToString()); }
            
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
