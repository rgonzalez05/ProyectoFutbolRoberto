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
    public partial class vista_CRUD_Cliente : Form
    {
        public CRUD_ClienteDb clientecontext = new CRUD_ClienteDb();
        public Model.CRUD_Cliente clienteSeleccionado = new Model.CRUD_Cliente();
        public enum Acciones
        {
            editar = 0,
            guardar = 1
        }
        public int accion = 1;

        public vista_CRUD_Cliente()
        {
            InitializeComponent();
            GetClienteActualizado();
            clientelist.AllowUserToAddRows = false;
            clientelist.AllowDrop = false;
            clientelist.AllowUserToDeleteRows = false;
            clientelist.MultiSelect = false;
        }

        public void GetClienteActualizado()
        {
            clientelist.DataSource = clientecontext.GetClientes();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                Model.CRUD_Cliente nCliente = new Model.CRUD_Cliente();
                nCliente.DPI = txtDPI.Text;
                nCliente.Nombres = txtNombre.Text;
                nCliente.Apellidos = txtApellido.Text;
                nCliente.Telefono = txtTelefono.Text;
                nCliente.Correo = txtCorreo.Text;
                clientecontext.AddCliente(nCliente);
                GetClienteActualizado();
            }
           else if (accion == 0)
            {
                int ID_Cliente = GetID();
                int DPI = Convert.ToInt32( txtDPI.Text);
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Telefono = txtTelefono.Text;
                string Correo = txtCorreo.Text;
                clientecontext.UpdateCliente(ID_Cliente, DPI, Nombre, Apellido, Telefono, Correo);
                GetClienteActualizado();
            }
            txtDPI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        public int GetID()
        {
            try
            {
                return int.Parse(
                    clientelist.Rows[clientelist.CurrentRow.Index].Cells[0].Value.ToString()
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
            int ID_Cliente = GetID();
            Model.CRUD_Cliente clienteeditar = clientecontext.GetCliente(ID_Cliente);
            txtDPI.Text = clienteeditar.DPI;
            txtNombre.Text = clienteeditar.Nombres;
            txtApellido.Text = clienteeditar.Apellidos;
            txtTelefono.Text = clienteeditar.Telefono;
            txtCorreo.Text = clienteeditar.Correo;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID_Cliente = GetID();
            clientecontext.DeleteCliente(ID_Cliente);
            GetClienteActualizado();
        }
    }
}
