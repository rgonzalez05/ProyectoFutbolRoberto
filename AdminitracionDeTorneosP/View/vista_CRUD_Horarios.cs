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
    public partial class vista_CRUD_Horarios : Form
    {
        public CRUD_HorariosDb horariocontext = new CRUD_HorariosDb();
        public Model.CRUD_Horarios horarioSeleccionado = new Model.CRUD_Horarios();
        public enum Acciones
        {
            editar = 0,
            guardar = 1
        }
        public int accion = 1;

        public vista_CRUD_Horarios()
        {
            InitializeComponent();
            GetHorarioActualizado();
            horariolist.AllowUserToAddRows = false;
            horariolist.AllowDrop = false;
            horariolist.AllowUserToDeleteRows = false;
            horariolist.MultiSelect = false;
            txtDia.Enabled = false;
        }

        public void GetHorarioActualizado()
        {
            horariolist.DataSource = horariocontext.GetHorario();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                Model.CRUD_Horarios nDia = new Model.CRUD_Horarios();
                nDia.Dia = txtDia.Text;
                nDia.Hora_Apertura = TimeSpan.Parse(txtApertura.Text);
                nDia.Hora_Cierre = TimeSpan.Parse(txtCierre.Text);
                GetHorarioActualizado();
            }
            else if (accion == 0)
            {
                string Dia = Convert.ToString(GetID());
                TimeSpan Hora_Apertura = TimeSpan.Parse(txtApertura.Text);
                TimeSpan Hora_Cierre = TimeSpan.Parse(txtCierre.Text);
                horariocontext.UpdateHorario(Dia, Hora_Apertura, Hora_Cierre);
                GetHorarioActualizado();
            }
            txtDia.Clear();
            txtApertura.Clear();
            txtCierre.Clear();
        }

        public string GetID()
        {
            try
            {
                return 
                    horariolist.Rows[horariolist.CurrentRow.Index].Cells[0].Value.ToString()
                    ;
            }
            catch
            {
                return null;
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            accion = 0;
            string Dia = GetID();
            Model.CRUD_Horarios horarioeditar = horariocontext.GetHorario(Dia);
            txtDia.Text = horarioeditar.Dia;
            txtApertura.Text =Convert.ToString( horarioeditar.Hora_Apertura);
            txtCierre.Text = Convert.ToString(horarioeditar.Hora_Cierre);
        }
    }
}
