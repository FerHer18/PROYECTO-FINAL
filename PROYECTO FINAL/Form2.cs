using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ClassEstadisticas estadisticas)
        {
            InitializeComponent();
            MostrarEstadisticas(estadisticas);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void MostrarEstadisticas(ClassEstadisticas estadisticas)
        {
            textBoxTotPro.Text = Convert.ToString(estadisticas.TotalProcesos);
            textBoxProFin.Text = Convert.ToString(estadisticas.ProcesosFinalizados);
            textBoxProPendientes.Text = Convert.ToString(estadisticas.ProcesosPendientes);
            textBoxPromMemoria.Text = $"{estadisticas.UsoPromedioMemoria:F2} KB";
            textBoxMaxMemoria.Text = $"{estadisticas.MaximoUsoMemoria} KB";
            textBoxTurnaround.Text = $"{estadisticas.TurnaroundPromedio:F2} unidades de tiempo";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
