using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class ClassEstadisticas
    {
        public int TotalProcesos { get; private set; }
        public int ProcesosFinalizados { get; private set; }
        public int ProcesosPendientes { get; private set; }
        public double UsoPromedioMemoria { get; private set; }
        public int MaximoUsoMemoria { get; private set; }
        public double TurnaroundPromedio { get; private set; }

        private int memoriaTotal;
        private List<int> usoMemoria;
        private List<int> tiemposFinalizacion;


        public ClassEstadisticas(int memoriaTotal)
        {
            this.memoriaTotal = memoriaTotal;
            usoMemoria = new List<int>();
            tiemposFinalizacion = new List<int>();
        }

        public void RegistrarUsoMemoria(int usoActual)
        {
            usoMemoria.Add(usoActual);
            MaximoUsoMemoria = Math.Max(MaximoUsoMemoria, usoActual);
        }

        public void RegistrarFinalizacionProceso(int tiempoFinalizacion)
        {
            tiemposFinalizacion.Add(tiempoFinalizacion);
        }

        public void CalcularEstadisticas(int totalProcesos, int finalizados, int pendientes)
        {
            TotalProcesos = totalProcesos;
            ProcesosFinalizados = finalizados;
            ProcesosPendientes = pendientes;

            UsoPromedioMemoria = usoMemoria.Any() ? usoMemoria.Average() : 0;
            TurnaroundPromedio = tiemposFinalizacion.Any() ? tiemposFinalizacion.Average() : 0;
        }

    }
}
