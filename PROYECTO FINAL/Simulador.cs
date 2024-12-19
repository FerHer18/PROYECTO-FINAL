using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Simulador : Form
    {
        private ClaseSimular simulador;

        private bool simulacion;
        public Simulador()
        {
            InitializeComponent();
            simulador = new ClaseSimular(1024, 4); // 1 MB, Quantum 4
            simulador.ActualizarTabla += ActualizarVista;
            simulacion = false;
            PersonalizarTabla();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
        }

        private void ActualizarVista(List<ClaseProceso> cola, ClaseProceso actual, List<ClaseProceso> finalizados)
        {
            if (!dgvProcesos.IsDisposed && dgvProcesos.IsHandleCreated && this.IsHandleCreated && !this.IsDisposed)
            {
                Invoke((Action)(() =>
                {
                    dgvProcesos.Rows.Clear();
                    foreach (var p in cola)
                    {
                        dgvProcesos.Rows.Add(p.Id, p.TiempoLlegada, p.TiempoEjecucion, p.TiempoRestante, "Listo");
                    }

                    if (actual != null)
                    {
                        dgvProcesos.Rows.Add(actual.Id, actual.TiempoLlegada, actual.TiempoEjecucion, actual.TiempoRestante, "Ejecución");
                    }

                    foreach (var p in finalizados)
                    {
                        dgvProcesos.Rows.Add(p.Id, p.TiempoLlegada, p.TiempoEjecucion, 0, "Finalizado");
                    }
                }));
            }
        }

        private void PersonalizarTabla()
        {
            dgvProcesos.EnableHeadersVisualStyles = false;
            dgvProcesos.ClearSelection();
            dgvProcesos.CurrentCell = null;

            dgvProcesos.Columns["ID"].DefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.Columns["TiempoLlegada"].DefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.Columns["TiempoEjecucion"].DefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.Columns["TiempoRestante"].DefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.Columns["Estado"].DefaultCellStyle.BackColor = Color.Black;

            // Encabezados de columnas
            dgvProcesos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProcesos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvProcesos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Encabezados de filas
            dgvProcesos.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvProcesos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProcesos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


        }

        private void dgvProcesos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var fila = dgvProcesos.Rows[e.RowIndex];
            var estado = fila.Cells["Estado"].Value?.ToString();

            if (estado == "Ejecución")
            {
                fila.DefaultCellStyle.ForeColor = Color.Green;
            }
            else if (estado == "Finalizado")
            {
                fila.DefaultCellStyle.ForeColor = Color.HotPink;
            }
            else if (estado == "Listo")
            {
                fila.DefaultCellStyle.ForeColor = Color.Aqua;
            }
        }

        private void buttonDetener_Click(object sender, EventArgs e)
        {
            simulador.DetenerSimulacion();
            MessageBox.Show("La simulación ha terminado", "Finalización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var estadisticas = simulador.ObtenerEstadisticas();
            Form2 f2 = new Form2(estadisticas);
            this.Hide();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (simulador.VelocidadSimulacion == 0)
            {
                MessageBox.Show("Hola, te recuerdo que debes seleccionar una velocidad de simulacion :)");
                return;
            }

            simulacion = true;
            Task.Run(() => simulador.EjecutarSimulacion());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simulador.SetVelocidad(2000);
            MessageBox.Show("Velocidad configurada a Lento :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simulador.SetVelocidad(500);
            MessageBox.Show("Velocidad configurada a Medio :)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simulador.SetVelocidad(50);
            MessageBox.Show("Velocidad configurada a Rápido :)");
        }
    }
}
