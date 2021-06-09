using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AdminitracionDeTorneosP.Model;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.Database
{
    public class CRUD_HorariosDb
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        public CRUD_Horarios GetHorario(string Dia)
        {
            CRUD_Horarios nDia = new CRUD_Horarios();
            string query = "select * from HORARIO where Dia=@Dia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Dia", Dia);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    nDia.Dia = reader.GetString(0);
                    nDia.Hora_Apertura = reader.GetTimeSpan(1);
                    nDia.Hora_Cierre = reader.GetTimeSpan(2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos" + ex.Message);
                }
            }
            return nDia;
        }

        public List<CRUD_Horarios> GetHorario()
        {
            List<CRUD_Horarios> nDias = new List<CRUD_Horarios>();
            string query = "select * from HORARIO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        CRUD_Horarios nDia = new CRUD_Horarios();
                        nDia.Dia = reader.GetString(0);
                        nDia.Hora_Apertura = reader.GetTimeSpan(1);
                        nDia.Hora_Cierre = reader.GetTimeSpan(2);
                        nDias.Add(nDia);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron obtener los datos" + ex.Message);
                }

            }
            return nDias;
        }

        public void AddHorario(CRUD_Horarios nDia)
        {
            string query = $"INSERT INTO HORARIO( Dia, Hora_Apertura, Hora_Cierre) VALUES ( @Dia, @Hora_Apertura, @Hora_Cierre)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);

                sql.Parameters.AddWithValue("@Dia", nDia.Dia);
                sql.Parameters.AddWithValue("@Hora_Apertura", nDia.Hora_Apertura);
                sql.Parameters.AddWithValue("@Hora_Cierre", nDia.Hora_Cierre);
                try
                {
                    connection.Open();
                    sql.ExecuteNonQuery();
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el Horario" + ex.Message);
                }
            }
        }

        public void UpdateHorario(string Dia, TimeSpan Hora_Apertura, TimeSpan Hora_Cierre)
        {
            string query = "UPDATE HORARIO set Dia=@Dia, Hora_Apertura=@Hora_Apertura, Hora_Cierre=@Hora_Cierre WHERE Dia=@Dia";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dia", Dia);
                command.Parameters.AddWithValue("@Hora_Apertura", Hora_Apertura);
                command.Parameters.AddWithValue("@Hora_Cierre", Hora_Cierre);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Horario Actualizado");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el Horario" + ex.Message);
                }
            }
        }

    }
}
