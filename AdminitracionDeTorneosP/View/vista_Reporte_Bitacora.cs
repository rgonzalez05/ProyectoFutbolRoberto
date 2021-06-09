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
    public partial class vista_Reporte_Bitacora : Form
    {

        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        public vista_Reporte_Bitacora()
        {
            InitializeComponent();
            GetUsuario(cbUsuario);
        }

        public void GetUsuario(ComboBox cb)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cb.Items.Clear();
                connection.Open();
                SqlCommand sql = new SqlCommand("SELECT * FROM USUARIO", connection);
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add($"{dr[0]}| {dr[2]} {dr[3]}");
                }
                connection.Close();
            }
        }

        private void Datos(string dato)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter sqll = new SqlDataAdapter(dato, connection);
                    DataTable datos = new DataTable();

                    sqll.Fill(datos);

                    Ingresolist.DataSource = datos;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pueden obtener los registros");
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string Usuario = Convert.ToString(cbUsuario.Text);
            string[] usuarioArray = Usuario.Split('|');
            int Id_Usuario = Convert.ToInt32(usuarioArray[0]);

            string Fecha_Inicio = $"{Convert.ToDateTime(txtFecha_Inicio.Text).Year}/{Convert.ToDateTime(txtFecha_Inicio.Text).Month}/{Convert.ToDateTime(txtFecha_Inicio.Text).Day}";
            string Fecha_Final = $"{Convert.ToDateTime(txtFecha_Final.Text).Year}/{Convert.ToDateTime(txtFecha_Final.Text).Month}/{Convert.ToDateTime(txtFecha_Final.Text).Day}";
            string query = $"EXEC Bitacora_Rep '{Fecha_Inicio}', '{Fecha_Final}', {Id_Usuario}";

            Datos(query);
        }
    }
}
