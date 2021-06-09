using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class vista_AlquilerCancha : Form
    {
        Alquiler_CanchaDb alquilerCControl = new Alquiler_CanchaDb();
        public vista_AlquilerCancha()
        {
            InitializeComponent();
            alquilerCControl.GetCliente(cbCliente);
            Actualizar();
        }

        private void Actualizar()
        {
            alquilerCControl.GetAlquiler(Alquilerlist);
        }

        private int GetID()
        {
            try
            {
                return int.Parse(Alquilerlist.Rows[Alquilerlist.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return 0;
            }
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(txtFechaApartada.Text);
            TimeSpan horaInicio = new TimeSpan(Convert.ToDateTime(txtFecha_Inicio.Text).Hour, Convert.ToDateTime(txtFecha_Inicio.Text).Minute, Convert.ToDateTime(txtFecha_Inicio.Text).Second);
            TimeSpan horaFinal = new TimeSpan(Convert.ToDateTime(txtFecha_Final.Text).Hour, Convert.ToDateTime(txtFecha_Final.Text).Minute, Convert.ToDateTime(txtFecha_Final.Text).Second);
            string nombreDia = fecha.ToString("dddd");

            List<CRUD_Horarios> horario = alquilerCControl.GetHorario();

            for (int i = 0; i < horario.Count; i++)
            {
                if (horario[i].Dia.ToLower() == nombreDia)
                {
                    if (horaInicio >= horario[i].Hora_Apertura && horaFinal <= horario[i].Hora_Cierre)
                    {
                        if (cbCliente.Text == "" || cbCancha.Text == "" || txtFechaApartada.Text == "" || txtFecha_Inicio.Text == "" || txtFecha_Final.Text == "")
                        {
                            MessageBox.Show("Ingrese todos los datos");
                        }
                        else
                        {
                            string cliente = Convert.ToString(cbCliente.SelectedItem);
                            string[] clienteArray = cliente.Split(' ');

                            string Nombres = "";
                            string Apellidos = "";
                            int idCliente = 0;
                            if (clienteArray.Length == 2)
                            {
                                Nombres = clienteArray[0];
                                Apellidos = clienteArray[1];
                                idCliente = alquilerCControl.GetIDCliente(Nombres, Apellidos);
                            }
                            else if (clienteArray.Length == 4)
                            {
                                Nombres = $"{clienteArray[0]} {clienteArray[1]}";
                                Apellidos = $"{clienteArray[2]} {clienteArray[3]}";
                                idCliente = alquilerCControl.GetIDCliente(Nombres, Apellidos);
                            }
                            if (cbArbitro.SelectedIndex != -1)
                            {

                                string cancha = Convert.ToString(cbCancha.SelectedItem);
                                string[] arrayCancha = cancha.Split('|');
                                int numeroCancha = Convert.ToInt32(arrayCancha[0]);

                                decimal totalAlquilerCancha = alquilerCControl.Total_AlquilerC(horaInicio, horaFinal, numeroCancha);

                                Alquiler_Cancha alquilarCancha = new Alquiler_Cancha();

                                if (cbArbitro.Items.Count == 0)
                                {
                                    MessageBox.Show("No hay arbitros disponibles en ese horario");
                                }
                                else
                                {
                                    string arbitro = Convert.ToString(cbArbitro.SelectedItem);
                                    string[] arbitrosArray = arbitro.Split('|');
                                    int dpiArbitro = Convert.ToInt32(arbitrosArray[0]);

                                    decimal totalArbitraje = alquilerCControl.TotalPrecioArb(horaInicio, horaFinal, dpiArbitro);
                                    alquilarCancha.Numero_Cancha = numeroCancha;
                                    alquilarCancha.Id_Cliente = idCliente;
                                    alquilarCancha.Fecha_Apartada = fecha;
                                    alquilarCancha.Hora_Inicio = horaInicio;
                                    alquilarCancha.Hora_Final = horaFinal;
                                    alquilarCancha.Precio_Total_Cancha = totalAlquilerCancha;

                                    alquilerCControl.AddAlquilerCancha(alquilarCancha);
                                    int idAlquilerCancha = alquilerCControl.GetIDAlquiler();
                                    alquilerCControl.AddArbitroAlquilado(fecha, horaInicio, horaFinal, dpiArbitro, idAlquilerCancha, totalArbitraje);
                                    Actualizar();
                                }
                            }
                            else
                            {

                                string cancha = Convert.ToString(cbCancha.SelectedItem);
                                string[] arrayCancha = cancha.Split('|');
                                int numeroCancha = Convert.ToInt32(arrayCancha[0]);

                                decimal totalAlquilerCancha = alquilerCControl.Total_AlquilerC(horaInicio, horaFinal, numeroCancha);

                                Alquiler_Cancha alquilarCancha = new Alquiler_Cancha();
                                alquilarCancha.Numero_Cancha = numeroCancha;
                                alquilarCancha.Id_Cliente = idCliente;
                                alquilarCancha.Fecha_Apartada = fecha;
                                alquilarCancha.Hora_Inicio = horaInicio;
                                alquilarCancha.Hora_Final = horaFinal;
                                alquilarCancha.Precio_Total_Cancha = totalAlquilerCancha;

                                alquilerCControl.AddAlquilerCancha(alquilarCancha);
                                Actualizar();
                            }
                        }
                        txtFechaApartada.Clear();
                        txtFecha_Final.Clear();
                        txtFecha_Inicio.Clear();
                        cbArbitro.Text = "";
                        cbCancha.Text = "";
                        cbCliente.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("La hora no se encuentra en el rango");
                    }
                    break;
                }


            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCancha.Enabled = true;
            DateTime fecha = Convert.ToDateTime(txtFechaApartada.Text);
            TimeSpan horaInicio = new TimeSpan(Convert.ToDateTime(txtFecha_Inicio.Text).Hour, Convert.ToDateTime(txtFecha_Inicio.Text).Minute, Convert.ToDateTime(txtFecha_Inicio.Text).Second);
            TimeSpan horaFinal = new TimeSpan(Convert.ToDateTime(txtFecha_Final.Text).Hour, Convert.ToDateTime(txtFecha_Final.Text).Minute, Convert.ToDateTime(txtFecha_Final.Text).Second);

            alquilerCControl.GetCanchas(cbCancha, fecha, horaInicio, horaFinal);
        }

        private void cbCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(txtFechaApartada.Text);
            TimeSpan horaInicio = new TimeSpan(Convert.ToDateTime(txtFecha_Inicio.Text).Hour, Convert.ToDateTime(txtFecha_Inicio.Text).Minute, Convert.ToDateTime(txtFecha_Inicio.Text).Second);
            TimeSpan horaFinal = new TimeSpan(Convert.ToDateTime(txtFecha_Final.Text).Hour, Convert.ToDateTime(txtFecha_Final.Text).Minute, Convert.ToDateTime(txtFecha_Final.Text).Second);

            alquilerCControl.GetArbitroDisp(cbArbitro, fecha, horaInicio, horaFinal);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID_Alquiler = GetID();
            alquilerCControl.DeleteAlquiler(ID_Alquiler);
            Actualizar();
        }
    }
}
