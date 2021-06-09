using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.View;

namespace AdminitracionDeTorneosP
{
    public partial class Form1 : Form
    {
        Login_UsuarioDb logController = new Login_UsuarioDb();
        int Id_Usuario;
        string Rol;
        public Form1(int Id_Usuario)
        {
            
            InitializeComponent();
            this.Id_Usuario = Id_Usuario;
            this.Rol = logController.GetRol(Id_Usuario);

            if (Rol == "Administrador")
            {
                button2.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button11.Enabled = true;
                button15.Enabled = true;
                button10.Enabled = true;
                button5.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button12.Enabled = true;
                button7.Enabled = true;
                button13.Enabled = true;
                btnCliente.Enabled = true;
                btnUsuarios.Enabled = true;
                button13.Enabled = true;
                btnAlquiler_c.Enabled = true;
                button26.Enabled = true;
                btnHorario.Enabled = true;
            }
            else if (Rol == "Operador")
            {
                btnHorario.Enabled = false;
                btnAlquiler_c.Enabled = false;
                button2.Enabled = false;
                button8.Enabled = true;
                button9.Enabled = true;
                button11.Enabled = true;
                button15.Enabled = false;
                button10.Enabled = true;
                button5.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button12.Enabled = true;
                button7.Enabled = true;
                button13.Enabled = true;
                btnCliente.Enabled = true;
                btnUsuarios.Enabled = false;
                button13.Enabled = false;
                button26.Enabled = false;
            }
            else if (Rol == "Reportes")
            {
                btnHorario.Enabled = false;
                button2.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = false;
                button15.Enabled = false;
                button10.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button12.Enabled = false;
                button7.Enabled = false;
                btnCliente.Enabled = false;
                btnAlquiler_c.Enabled = false;
                btnUsuarios.Enabled = false;
                button13.Enabled = false;
                button26.Enabled = true;
            }
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Torneo";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.Torneo2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Inscripcion Equipo";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.MenuIncripcionEquipo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Inscripcion Jugador";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.MenuIncripcionJugador());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Amonestaciones";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.CRUD_AMONESTACION());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Jornadas de Partido";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.JornadasPartido());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Iniciar Partido";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.ComenzarPartido());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Entrenador";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.CRUD_ENTRENADOR());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Equipos";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.CRUD_EQUIPO());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Arbitros";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.refereeView());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Jugadores";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.CRUD_JUGADORES());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Encuentros Ganados";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.vISTA_ENCUENTROS_WIN());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Pago de Tarjetas";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.VISTA_PAGOS_TARGETAS());
        }
               
        private void button15_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Agregar Cancha";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.Agregar_Cancha());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Reportes";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.Bienvenida());
        }
        

        private void btnCerrarSS_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Cerrar Sesión";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            this.Close();
            vista_Login nuevaSesion = new vista_Login();
            nuevaSesion.Show();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Horarios";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.vista_CRUD_Horarios());
        }

        private void btnAlquiler_c_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Alquiler Canchas";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.vista_AlquilerCancha());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Usuario";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.vista_CRUD_Usuario());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm");
            string accion = "Cliente";
            logController.AddBitacora(Id_Usuario, accion, fecha, hora);
            AbrirFormInPanel(new View.vista_CRUD_Cliente());
        }
    }
}
