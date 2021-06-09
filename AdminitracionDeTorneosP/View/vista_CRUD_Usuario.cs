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
    public partial class vista_CRUD_Usuario : Form
    {

        public CRUD_UsuarioDb usuarioContext = new CRUD_UsuarioDb();
        public Model.CRUD_Usuario usuarioSeleccionado = new Model.CRUD_Usuario();
        public enum Acciones
        {
            editar = 0,
            guardar = 1
        }
        public int accion = 1;

        public vista_CRUD_Usuario()
        {
            InitializeComponent();
            GetUsuarioActualizado();
            usuariolist.AllowUserToAddRows = false;
            usuariolist.AllowDrop = false;
            usuariolist.AllowUserToDeleteRows = false;
            usuariolist.MultiSelect = false;
        }

        public void GetUsuarioActualizado()
        {
            usuariolist.DataSource = usuarioContext.GetUsuarios();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                Model.CRUD_Usuario nUsuario = new Model.CRUD_Usuario();
                nUsuario.DPI = txtDPI.Text;
                nUsuario.Nombres = txtNombre.Text;
                nUsuario.Apellidos = txtApellido.Text;
                nUsuario.Usuario = txtUsuario.Text;
                nUsuario.Contraseña = txtContraseña.Text;
                nUsuario.Telefono = txtTelefono.Text;
                nUsuario.Direccion = txtDireccion.Text;
                nUsuario.Correo = txtCorreo.Text;
                nUsuario.Puesto = txtPuesto.Text;
                nUsuario.Rol = cbRol.Text;
                usuarioContext.AddUsuario(nUsuario);
                GetUsuarioActualizado();
            }
            else if (accion == 0)
            {
                int ID_Usuario = GetID();
                string DPI = txtDPI.Text;
                string Nombres = txtNombre.Text;
                string Apellidos = txtApellido.Text;
                string Usuario = txtUsuario.Text;
                string Contraseña = txtContraseña.Text;
                string Telefono = txtTelefono.Text;
                string Direccion = txtDireccion.Text;
                string Correo = txtCorreo.Text;
                string Puesto = txtPuesto.Text;
                string Rol = cbRol.Text;
                usuarioContext.UpdateUsuario(ID_Usuario, DPI, Nombres, Apellidos, Usuario, Contraseña, Telefono, Direccion, Correo, Puesto, Rol);
                GetUsuarioActualizado();
            }
            txtDPI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtPuesto.Clear();
            cbRol.Text = "";
            accion = 1;
        }

        public int GetID()
        {
            try
            {
                return int.Parse(
                    usuariolist.Rows[usuariolist.CurrentRow.Index].Cells[0].Value.ToString()
                    );
            }
            catch
            {
                return 0;
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            accion = 0;
            int ID_Usuario = GetID();
            Model.CRUD_Usuario usuarioeditar = usuarioContext.GetUsuario(ID_Usuario);
            txtDPI.Text = usuarioeditar.DPI;
            txtNombre.Text = usuarioeditar.Nombres;
            txtApellido.Text = usuarioeditar.Apellidos;
            txtUsuario.Text = usuarioeditar.Usuario;
            txtContraseña.Text = usuarioeditar.Contraseña;
            txtTelefono.Text = usuarioeditar.Telefono;
            txtDireccion.Text = usuarioeditar.Direccion;
            txtCorreo.Text = usuarioeditar.Correo;
            txtPuesto.Text = usuarioeditar.Puesto;
            cbRol.Text = usuarioeditar.Rol;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID_Usuario = GetID();
            usuarioContext.DeleteUsuario(ID_Usuario);
            GetUsuarioActualizado();
        }
    }
}
