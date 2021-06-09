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
    public class CRUD_UsuarioDb
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        public CRUD_Usuario GetUsuario(int ID_Usuario)
        {
            CRUD_Usuario nUsuario = new CRUD_Usuario();
            string query = "select * from USUARIO where ID_Usuario=@ID_Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@ID_Usuario", ID_Usuario);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    nUsuario.ID_Usuario = reader.GetInt32(0);
                    nUsuario.DPI = reader.GetString(1);
                    nUsuario.Nombres = reader.GetString(2);
                    nUsuario.Apellidos = reader.GetString(3);
                    nUsuario.Usuario = reader.GetString(4);
                    nUsuario.Contraseña = reader.GetString(5);
                    nUsuario.Telefono = reader.GetString(6);
                    nUsuario.Direccion = reader.GetString(7);
                    nUsuario.Correo = reader.GetString(8);
                    nUsuario.Puesto = reader.GetString(9);
                    nUsuario.Rol = reader.GetString(10);
                    nUsuario.Estado = reader.GetBoolean(11);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos" + ex.Message);
                }
            }
            return nUsuario;
        }

        public List<CRUD_Usuario> GetUsuarios()
        {
            List<CRUD_Usuario> nUsuarios = new List<CRUD_Usuario>();
            string query = "select * from USUARIO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        CRUD_Usuario nUsuario = new CRUD_Usuario();
                        nUsuario.ID_Usuario = reader.GetInt32(0);
                        nUsuario.DPI = reader.GetString(1);
                        nUsuario.Nombres = reader.GetString(2);
                        nUsuario.Apellidos = reader.GetString(3);
                        nUsuario.Usuario = reader.GetString(4);
                        nUsuario.Contraseña = reader.GetString(5);
                        nUsuario.Telefono = reader.GetString(6);
                        nUsuario.Direccion = reader.GetString(7);
                        nUsuario.Correo = reader.GetString(8);
                        nUsuario.Puesto = reader.GetString(9);
                        nUsuario.Rol = reader.GetString(10);
                        nUsuario.Estado = reader.GetBoolean(11);
                        nUsuarios.Add(nUsuario);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron obtener los datos" + ex.Message);
                }

            }
            return nUsuarios;
        }

        public void AddUsuario(CRUD_Usuario nUsuario)
        {
            string query = $"INSERT INTO USUARIO( DPI, Nombres, Apellidos, Usuario, Contraseña, Telefono, Direccion, Correo, Puesto, Rol) VALUES ( @DPI, @Nombres, @Apellidos, @Usuario, @Contraseña, @Telefono, @Direccion, @Correo, @Puesto, @Rol)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);

                sql.Parameters.AddWithValue("@DPI", nUsuario.DPI);
                sql.Parameters.AddWithValue("@Nombres", nUsuario.Nombres);
                sql.Parameters.AddWithValue("@Apellidos", nUsuario.Apellidos);
                sql.Parameters.AddWithValue("@Usuario", nUsuario.Usuario);
                sql.Parameters.AddWithValue("@Contraseña", nUsuario.Contraseña);
                sql.Parameters.AddWithValue("@Telefono", nUsuario.Telefono);
                sql.Parameters.AddWithValue("@Direccion", nUsuario.Direccion);
                sql.Parameters.AddWithValue("@Correo", nUsuario.Correo);
                sql.Parameters.AddWithValue("@Puesto", nUsuario.Puesto);
                sql.Parameters.AddWithValue("@Rol", nUsuario.Rol);
                try
                {
                    connection.Open();
                    sql.ExecuteNonQuery();
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el usuario" + ex.Message);
                }
            }
        }

        public void UpdateUsuario(int ID_Usuario, string DPI, string Nombres, string Apellidos, string Usuario, string Contraseña, string Telefono, string Direccion, string Correo, string Puesto, string Rol)
        {
            string query = "UPDATE USUARIO set DPI=@DPI, Nombres=@Nombres, Apellidos=@Apellidos, Usuario=@Usuario, Contraseña=@Contraseña, Telefono=@Telefono, Direccion=@Direccion, Correo=@Correo, Puesto=@Puesto, Rol=@Rol WHERE ID_Usuario=@ID_Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Usuario", ID_Usuario);
                command.Parameters.AddWithValue("@DPI", DPI);
                command.Parameters.AddWithValue("@Nombres", Nombres);
                command.Parameters.AddWithValue("@Apellidos", Apellidos);
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Contraseña", Contraseña);
                command.Parameters.AddWithValue("@Telefono", Telefono);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@Puesto", Puesto);
                command.Parameters.AddWithValue("@Rol", Rol);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario Actualizado");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el Usuario" + ex.Message);
                }
            }
        }

        public void DeleteUsuario(int ID_Usuario)
        {
            string query = "UPDATE USUARIO SET ESTADO = 0 WHERE ID_Usuario=@ID_Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Usuario", ID_Usuario);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Usuario Eliminado");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al Eliminar " + ex.Message);
                }
            }
        }
    }
}
