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
    public class CRUD_ClienteDb
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");


        public CRUD_Cliente GetCliente(int Nocliente)
        {
            CRUD_Cliente nCliente = new CRUD_Cliente();
            string query = "select * from CLIENTE where ID_CLIENTE=@ID_CLIENTE";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@ID_CLIENTE", Nocliente);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    nCliente.ID_Cliente = reader.GetInt32(0);
                    nCliente.DPI = reader.GetString(1);
                    nCliente.Nombres = reader.GetString(2);
                    nCliente.Apellidos = reader.GetString(3);
                    nCliente.Telefono = reader.GetString(4);
                    nCliente.Correo = reader.GetString(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos" + ex.Message);
                }
            }
            return nCliente;
        }

        public List<CRUD_Cliente> GetClientes()
        {
            List<CRUD_Cliente> nClientes = new List<CRUD_Cliente>();
            string query = "select * from CLIENTE";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        CRUD_Cliente nCliente = new CRUD_Cliente();
                        nCliente.ID_Cliente = reader.GetInt32(0);
                        nCliente.DPI = reader.GetString(1);
                        nCliente.Nombres = reader.GetString(2);
                        nCliente.Apellidos = reader.GetString(3);
                        nCliente.Telefono = reader.GetString(4);
                        nCliente.Correo = reader.GetString(5);
                        nClientes.Add(nCliente);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron obtener los datos" + ex.Message);
                }

            }
            return nClientes;
        }

        public void AddCliente(CRUD_Cliente nCliente)
        {
            string query = $"INSERT INTO CLIENTE( DPI, Nombres, Apellidos, Telefono, Correo) VALUES ( @DPI, @Nombres, @Apellidos, @Telefono, @Correo)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);

                sql.Parameters.AddWithValue("@DPI", nCliente.DPI);
                sql.Parameters.AddWithValue("@Nombres", nCliente.Nombres);
                sql.Parameters.AddWithValue("@Apellidos", nCliente.Apellidos);
                sql.Parameters.AddWithValue("@Telefono", nCliente.Telefono);
                sql.Parameters.AddWithValue("@Correo", nCliente.Correo);
                try
                {
                    connection.Open();
                    sql.ExecuteNonQuery();
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente" + ex.Message);
                }
            }
        }

        public void UpdateCliente(int ID_Cliente, int DPI, string Nombres, string Apellidos, string Telefono, string Correo)
        {
            string query = "UPDATE CLIENTE set DPI=@DPI, Nombres=@Nombres, Apellidos=@Apellidos, Telefono=@Telefono, Correo=@Correo WHERE ID_Cliente=@ID_Cliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                command.Parameters.AddWithValue("@DPI", DPI);
                command.Parameters.AddWithValue("@Nombres", Nombres);
                command.Parameters.AddWithValue("@Apellidos", Apellidos);
                command.Parameters.AddWithValue("@Telefono", Telefono);
                command.Parameters.AddWithValue("@Correo", Correo);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente Actualizado");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el Cliente" + ex.Message);
                }
            }
        }

        public void DeleteCliente(int ID_Cliente)
        {
            string query = " delete from CLIENTE where ID_Cliente=@ID_Cliente";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cliente Eliminado");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al Eliminar " + ex.Message);
                }
            }

        }

    }
}
