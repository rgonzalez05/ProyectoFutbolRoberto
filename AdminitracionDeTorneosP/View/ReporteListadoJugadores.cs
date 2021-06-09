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
    public partial class ReporteListadoJugadores : Form
    {
        public JUGADORES_DB jugador_context = new JUGADORES_DB();
        public ReporteListadoJugadores()
        {
            InitializeComponent();
            mostrar_jugadores_datagrid();
            lista_jugadores_datagrid.AllowUserToAddRows = false;
            lista_jugadores_datagrid.AllowDrop = false;
            lista_jugadores_datagrid.AllowUserToDeleteRows = false;
        }

        public void mostrar_jugadores_datagrid()
        {

            lista_jugadores_datagrid.DataSource = jugador_context.busqueda_jugadores_total();
        }
        private void ReporteListadoJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
