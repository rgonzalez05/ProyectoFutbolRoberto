using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class vistaReporteRobertoEquipos : Form
    {
        public string query = "select * from equipo";
        public vistaReporteRobertoEquipos()
        {
            InitializeComponent();
            GetEquipos(query);
        }

        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        private void GetEquipos(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter sql = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();

                    sql.Fill(data);
                    Equiposlist.DataSource = data;
                    connection.Close();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudieron cargar los equipos");
                }

            }
        }

    }
}
