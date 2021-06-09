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
    class Alquiler_CanchaDb
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");

        public void GetAlquiler(DataGridView list)
        {
            string query = "EXEC Ver_Alquiler";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    SqlDataAdapter sql = new SqlDataAdapter(query, connection);
                    DataTable datos = new DataTable();

                    sql.Fill(datos);
                    list.DataSource = datos;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudieron obtener los datos");
                }
            }
        }

        public void GetCliente(ComboBox cb)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cb.Items.Clear();
                connection.Open();
                SqlCommand sql = new SqlCommand("SELECT * FROM CLIENTE", connection);
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add($"{dr[2]} {dr[3]}");
                }
                connection.Close();
            }
        }

        public void GetCanchas(ComboBox cb, DateTime Fecha_Apartada, TimeSpan Hora_Inicio, TimeSpan Hora_Final)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cb.Items.Clear();
                connection.Open();
                SqlCommand sql = new SqlCommand("EXEC CANCHAS_DISPONIBLE @Fecha_Apartada, @Hora_Inicio,@Hora_Final", connection);
                sql.Parameters.AddWithValue("@Fecha_Apartada", Fecha_Apartada);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add($"{dr[0]}| {dr[1]}");
                }
                connection.Close();
            }
        }

        public void AddAlquilerCancha(Alquiler_Cancha alquiler_Cancha)
        {
            string query = "EXEC AGREGAR_AlQUILER @Numero_Cancha ,@ID_Cliente , @Fecha_Apartada ,@Hora_Inicio ,@Hora_Final ,@Precio_Total_Cancha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero_Cancha", alquiler_Cancha.Numero_Cancha);
                command.Parameters.AddWithValue("@ID_Cliente", alquiler_Cancha.Id_Cliente);
                command.Parameters.AddWithValue("@Fecha_Apartada", alquiler_Cancha.Fecha_Apartada);
                command.Parameters.AddWithValue("@Hora_Inicio", alquiler_Cancha.Hora_Inicio);
                command.Parameters.AddWithValue("@Hora_Final", alquiler_Cancha.Hora_Final);
                command.Parameters.AddWithValue("@Precio_Total_Cancha", alquiler_Cancha.Precio_Total_Cancha);
                try
                {
                    connection.Open();
                    //Ejecuta el Query
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Alquiler Agregado");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar" + error.Message, "ERROR");
                }
            }
        }

        public int GetIDCliente(string Nombres, string Apellidos)
        {
            int ID = 0;
            string query = "EXEC ID_CLIENTE @Nombres , @Apellidos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Nombres", Nombres);
                sql.Parameters.AddWithValue("@Apellidos", Apellidos);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    ID = reader.GetInt32(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return ID;
            }

        }

        public decimal GetPrecioCancha(int Numero_Cancha)
        {
            decimal precio = 0;
            string query = "EXEC PRECIO_CANCHAS @NumeroCancha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@NumeroCancha", Numero_Cancha);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();
                    precio = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return precio;
            }

        }

        public decimal Total_AlquilerC(TimeSpan Hora_Inicio, TimeSpan Hora_Final, int Numero_Cancha)
        {
            decimal Total = 0;
            string query = "EXEC PRECIO_TOTAL @Hora_Inicio, @Hora_Final, @NumeroCancha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                sql.Parameters.AddWithValue("@NumeroCancha", Numero_Cancha);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();
                    Total = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return Total;
            }
        }

        public decimal TotalPrecioArb(TimeSpan Hora_Inicio, TimeSpan Hora_Final, int DPI_ARBITRO)
        {
            decimal TotalArbitraje = 0;
            string query = "EXEC PRECIO_ARBITRAJE @Hora_Inicio , @Hora_Final , @DPI_Arbitro";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                sql.Parameters.AddWithValue("@DPI_Arbitro", DPI_ARBITRO);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();
                    TotalArbitraje = reader.GetDecimal(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return TotalArbitraje;
            }
        }

        public void GetArbitroDisp(ComboBox cb, DateTime Fecha_Apartada, TimeSpan Hora_Inicio, TimeSpan Hora_Final)
        {
            string query = "EXEC  ARBITRO_DISPONIBLE @FechaApartada, @HoraInicio,@HoraFinal";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cb.Items.Clear();
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@FechaApartada", Fecha_Apartada);
                sql.Parameters.AddWithValue("@HoraInicio", Hora_Inicio);
                sql.Parameters.AddWithValue("@HoraFinal", Hora_Final);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        cb.Items.Add($"{reader[0]}| {reader[1]} {reader[2]}");
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al obtener los datos");
                }
            }
        }

        public void AddArbitroAlquilado(DateTime Fecha_Apartada, TimeSpan Hora_Inicio, TimeSpan Hora_Final, int DPI, int ID_Alquiler, Decimal Precio_Arbitro)
        {
            string query = "EXEC AGREGAR_ARBITRAJE_ALQUILADO @Fecha_Apartado , @Hora_Inicio , @Hora_Final , @DPI_Arbitro ,@ID_ALQUILER ,@Total_Precio_Arbitro ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha_Apartado", Fecha_Apartada);
                command.Parameters.AddWithValue("@Hora_Inicio", Hora_Inicio);
                command.Parameters.AddWithValue("@Hora_Final", Hora_Final);
                command.Parameters.AddWithValue("@DPI_Arbitro", DPI);
                command.Parameters.AddWithValue("@ID_ALQUILER", ID_Alquiler);
                command.Parameters.AddWithValue("@Total_Precio_Arbitro", Precio_Arbitro);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar el Alquiler" + error.Message, "ERROR");
                }
            }
        }

        public int GetIDAlquiler()
        {
            int ID_Alquiler = 0;
            string query = "SELECT TOP 1 * FROM ALQUILER_CANCHA ORDER BY ID DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    reader.Read();

                    ID_Alquiler = reader.GetInt32(0);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener los datos" + error, "ERROR");
                }
                return ID_Alquiler;
            }
        }

        public List<CRUD_Horarios> GetHorario()
        {
            List<CRUD_Horarios> horario = new List<CRUD_Horarios>();
            string query = "SELECT * FROM HORARIO";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        CRUD_Horarios Horarios = new CRUD_Horarios();
                        Horarios.Dia = reader.GetString(0);
                        Horarios.Hora_Apertura = reader.GetTimeSpan(1);
                        Horarios.Hora_Cierre = reader.GetTimeSpan(2);
                        horario.Add(Horarios);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al obtener el Horario" + error, "ERROR");
                }
            }
            return horario;
        }

        public void DeleteAlquiler(int ID)
        {
            string query = "EXEC ALQUILER_CANCHA @ID";
            string query2 = "EXEC DELETE_ALQUILERARB @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand sql = new SqlCommand(query, connection);
                SqlCommand sql2 = new SqlCommand(query2, connection);
                sql.Parameters.AddWithValue("@ID", ID);
                sql2.Parameters.AddWithValue("@ID", ID);
                try
                {
                    connection.Open();
                    sql2.ExecuteNonQuery();
                    sql.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Registro Eliminado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al eliminar el alquiler");
                }
            }
        }

    }
}
