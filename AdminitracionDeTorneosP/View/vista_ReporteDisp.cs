using AdminitracionDeTorneosP.Model;
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
    public partial class vista_ReporteDisp : Form
    {
        private string connectionString = ("Server=DESKTOP-DF943KT  ;Database=PROYECTO_TORNEOS;User Id=tito1;Password=1234;");
        string[,] disponibilidad;
        DateTime[] fechas;

        public vista_ReporteDisp()
        {
            InitializeComponent();
            Getcancha(cbCancha);
        }

        public void Getcancha(ComboBox cb)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cb.Items.Clear();
                connection.Open();

                SqlCommand sql = new SqlCommand("SELECT * FROM cancha", connection);

                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add($"{dr[0]}| {dr[1]}");
                }
                connection.Close();
            }
        }

        public List<CRUD_Horarios> GetHorario()
        {
            List<CRUD_Horarios> horas = new List<CRUD_Horarios>();
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
                        CRUD_Horarios horarios = new CRUD_Horarios();
                        horarios.Dia = reader.GetString(0);
                        horarios.Hora_Apertura = reader.GetTimeSpan(1);
                        horarios.Hora_Cierre = reader.GetTimeSpan(2);
                        horas.Add(horarios);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error al obtener los datos");
                }
            }
            return horas;
        }

        public string GetDisponibilidadC(DateTime fecha, TimeSpan hora_Inicio, TimeSpan hora_Final, int numero_Cancha)
        {
            string query = "EXEC DISPONIBILIDAD_CANCHA @Fecha, @Hora_Inicio, @Hora_Final, @Numero_Cancha";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sql = new SqlCommand(query, connection);
                sql.Parameters.AddWithValue("@Fecha", fecha.Date);
                sql.Parameters.AddWithValue("@Hora_Inicio", hora_Inicio);
                sql.Parameters.AddWithValue("@Hora_Final", hora_Final);
                sql.Parameters.AddWithValue("@Numero_Cancha", numero_Cancha);

                connection.Open();
                SqlDataReader reader = sql.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    return "Diponible";
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return "No Diponible";
                }

            }
        }

        private void Update()
        {
            string stringCancha = Convert.ToString(cbCancha.SelectedItem);
            string[] ArrelgoCancha = stringCancha.Split('|');
            int numeroCancha = Convert.ToInt32(ArrelgoCancha[0]);
            List<CRUD_Horarios> horario = GetHorario();

            TimeSpan restFecha = Convert.ToDateTime(txtFecha_Final.Text).Date - Convert.ToDateTime(txtFecha_Inicio.Text).Date;
            int cantidadDias = restFecha.Days;

            TimeSpan horaMayor = horario[0].Hora_Cierre - horario[0].Hora_Apertura;
            int cantidadHorasMayor = horaMayor.Hours;
            TimeSpan Apertura = horario[0].Hora_Apertura;
            TimeSpan Cierre = horario[0].Hora_Apertura;

            DateTime fechaInicio = Convert.ToDateTime(txtFecha_Inicio.Text).Date;
            DateTime fechaFinal = Convert.ToDateTime(txtFecha_Final.Text).Date;

            int contador = 0;
            fechas = new DateTime[cantidadDias + 1];

            while (fechaInicio <= fechaFinal)
            {
                fechas[contador] = fechaInicio;
                fechaInicio += new TimeSpan(1, 0, 0, 0);
                Console.WriteLine(fechas[contador]);
                contador++;
            }

            for (int i = 1; i < horario.Count; i++)
            {
                TimeSpan diferenciaHoras = horario[i].Hora_Cierre - horario[i].Hora_Apertura;
                int horas = diferenciaHoras.Hours;

                if (horas > cantidadHorasMayor)
                {
                    cantidadHorasMayor = horas;
                    Apertura = horario[i].Hora_Apertura;
                    Cierre = horario[i].Hora_Cierre;
                }

            }

            TimeSpan Inicial = Apertura;
            disponibilidad = new string[cantidadHorasMayor + 1, cantidadDias + 2];

            disponibilidad[0, 0] = "|";

            for (int i = 1; i <= cantidadHorasMayor; i++)
            {
                disponibilidad[i, 0] = $"{Apertura}-{Apertura + new TimeSpan(1, 0, 0)}";
                Apertura += new TimeSpan(1, 0, 0);
                Console.WriteLine(disponibilidad[i, 0]);
            }

            int contador2 = 0;
            for (int i = 1; i <= cantidadDias + 1; i++)
            {
                disponibilidad[0, i] = $"{fechas[contador2]}";

                Console.WriteLine(disponibilidad[0, i]);
                contador2++;
            }

            for (int horas = 1; horas <= cantidadHorasMayor; horas++)
            {
                string horarioIndividual = Convert.ToString(disponibilidad[horas, 0]);
                string[] arrayHorario = horarioIndividual.Split('-');

                for (int dias = 1; dias <= cantidadDias + 1; dias++)
                {
                    TimeSpan Horauno = new TimeSpan(Convert.ToDateTime(arrayHorario[0]).Hour, Convert.ToDateTime(arrayHorario[0]).Minute, Convert.ToDateTime(arrayHorario[0]).Second);
                    TimeSpan Horados = new TimeSpan(Convert.ToDateTime(arrayHorario[1]).Hour, Convert.ToDateTime(arrayHorario[1]).Minute, Convert.ToDateTime(arrayHorario[1]).Second);

                    disponibilidad[horas, dias] = GetDisponibilidadC(Convert.ToDateTime(disponibilidad[0, dias]), Horauno, Horados, numeroCancha);
                }
            }

            int heigth = cantidadHorasMayor;
            int width = cantidadDias + 2;

            this.listDisponibilidad.ColumnCount = width;

            for (int f = 0; f <= heigth; f++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.listDisponibilidad);
                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = disponibilidad[f, c];
                }
                this.listDisponibilidad.Rows.Add(row);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            listDisponibilidad.Rows.Clear();
            Update();
        }
    }
}
