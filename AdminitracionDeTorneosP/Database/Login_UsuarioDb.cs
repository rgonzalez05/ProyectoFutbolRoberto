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
    public class Login_UsuarioDb
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        public string GetRol(int ID_Usuario)
        {
            string Rol = "";
            string query = $"EXEC Tipo_Rol {ID_Usuario}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Rol = reader.GetString(0);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario incorrecto o no existente");
                }
            }
            return Rol;
        }

        public int GetID(string USUARIO, string Contraseña)
        {
            int Id = 1;
            string query = $"EXEC ID_Estado '{USUARIO}', '{Contraseña}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Id = reader.GetInt32(0);
                }
                
                reader.Close();
                connection.Close();
            }
            return Id;
        }

        public Boolean GetEstado_Usuario(string USUARIO, string Contraseña)
        {
            Boolean Estado = false;
            string query = $"EXEC ESTADO_USUARIO '{USUARIO}', '{Contraseña}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Estado = reader.GetBoolean(0);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario no existente");
                }
            }
            return Estado;
        }

        public void AddBitacora(int ID_Usuario, string Operacion, string Fecha, string Hora)
        {
            string query = "EXEC AgregarBitacora  @Id_Usuario, @Operacion,@Fecha, @Hora";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Usuario", ID_Usuario);
                command.Parameters.AddWithValue("@Operacion", Operacion);
                command.Parameters.AddWithValue("@Fecha", Fecha);
                command.Parameters.AddWithValue("@Hora", Hora);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "ERROR");
                }
            }
        }

    }
}
