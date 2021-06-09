using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;


namespace AdminitracionDeTorneosP.View
{
    public partial class vista_Login : Form
    {
        Login_UsuarioDb logController = new Login_UsuarioDb();
        public string Fecha = DateTime.Now.ToString("yyyy-MM-dd");
        public string Hora = DateTime.Now.ToString("hh:mm");
        public string Operacion = "Inicio de Sesion";

        public vista_Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int Id_Usuario = logController.GetID(txtUsuario.Text, txtContraseña.Text);

            Boolean Usuario_Estado = logController.GetEstado_Usuario(txtUsuario.Text, txtContraseña.Text);
            if (Usuario_Estado == true)
            {
                logController.AddBitacora(Id_Usuario, Operacion, Fecha, Hora);
                this.Hide();
                Form1 t = new Form1(Id_Usuario);
                t.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos o usuario deshabilitado");
            }
        }
    }
}
