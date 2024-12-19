using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class ClaseSimular
    {
        private int quantum;
        private int tiempoSimulacion;
        private int idProceso;
        private bool simulacionActiva;
        private int velocidad;
        public int MemoriaTotal { get; private set; }
        private ClaseMemoria memoria;
        private Queue<ClaseProceso> colaProcesos;
        private List<ClaseProceso> procesosFinalizados;
        private ClassEstadisticas estadisticas;

        public event Action<List<ClaseProceso>, ClaseProceso, List<ClaseProceso>> ActualizarTabla;

        public ClaseSimular(int memoriaTotal, int quantum)
        {
            MemoriaTotal = memoriaTotal;
            this.quantum = quantum;
            memoria = new ClaseMemoria(memoriaTotal);
            colaProcesos = new Queue<ClaseProceso>();
            procesosFinalizados = new List<ClaseProceso>();
            tiempoSimulacion = 0;
            idProceso = 1;
            simulacionActiva = true;
            estadisticas = new ClassEstadisticas(memoriaTotal);
        }

        public void GenerarProceso()
        {
            var rand = new Random();
            int tiempoEjecucion = rand.Next(1, 11); // 1 a 10
            int tamanioMemoria = (int)Math.Pow(2, rand.Next(5, 9)); // 32KB a 256KB
            var nuevoProceso = new ClaseProceso(idProceso++, tiempoSimulacion, tiempoEjecucion, tamanioMemoria);

            if (AsignarMemoria(memoria, tamanioMemoria))
            {
                colaProcesos.Enqueue(nuevoProceso);
            }
        }

        public void EjecutarSimulacion()
        {
            while (simulacionActiva)
            {
                GenerarProceso();
                ClaseProceso procesoActual = null;

                if (colaProcesos.Count > 0)
                {
                    procesoActual = colaProcesos.Dequeue();
                    procesoActual.Estado = "Ejecución";
                    int tiempoEjecutado = Math.Min(quantum, procesoActual.TiempoRestante);
                    procesoActual.TiempoRestante -= tiempoEjecutado;

                    if (procesoActual.TiempoRestante <= 0)
                    {
                        procesoActual.Estado = "Finalizado";
                        procesosFinalizados.Add(procesoActual);
                        LiberarBloque(memoria, procesoActual.TamanioMemoria);
                    }
                    else
                    {
                        procesoActual.Estado = "Listo";
                        colaProcesos.Enqueue(procesoActual);
                    }
                }

                ActualizarTabla?.Invoke(new List<ClaseProceso>(colaProcesos), procesoActual, new List<ClaseProceso>(procesosFinalizados));
                tiempoSimulacion++;
                System.Threading.Thread.Sleep(VelocidadSimulacion); // Simular tiempo
            }
        }

        private bool AsignarMemoria(ClaseMemoria nodo, int tamanio)
        {
            if (nodo == null || !nodo.Libre || nodo.Tamanio < tamanio)
                return false;

            if (nodo.Tamanio == tamanio)
            {
                nodo.Libre = false;
                return true;
            }

            if (nodo.Izquierda == null && nodo.Derecha == null)
            {
                nodo.Izquierda = new ClaseMemoria(nodo.Tamanio / 2);
                nodo.Derecha = new ClaseMemoria(nodo.Tamanio / 2);
            }

            return AsignarMemoria(nodo.Izquierda, tamanio) || AsignarMemoria(nodo.Derecha, tamanio);
        }

        public int VelocidadSimulacion
        {
            get { return velocidad; }
            set { velocidad = 1000; }
        }

        public void SetVelocidad(int velocidad)
        {
            this.velocidad = velocidad; 
        }

        private void LiberarBloque(ClaseMemoria nodo, int tamanio)
        {
            if (nodo == null || nodo.Tamanio != tamanio)
                return;

            nodo.Libre = true;
            nodo.Coalescer();
            estadisticas.RegistrarUsoMemoria(CalcularMemoriaEnUso());
        }

        public void DetenerSimulacion()
        {
            simulacionActiva = false;  // Detiene el ciclo en EjecutarSimulacion
        }

        public ClassEstadisticas ObtenerEstadisticas()
        {
            estadisticas.CalcularEstadisticas(
                colaProcesos.Count + procesosFinalizados.Count,
                procesosFinalizados.Count,
                colaProcesos.Count
            );
            return estadisticas;
        }

        private int CalcularMemoriaEnUso()
        {
            int memoriaUsada = 0;

            void CalcularUsoRecursivo(ClaseMemoria nodo)
            {
                if (nodo == null) return;

                if (!nodo.Libre) memoriaUsada += nodo.Tamanio;

                CalcularUsoRecursivo(nodo.Izquierda);
                CalcularUsoRecursivo(nodo.Derecha);
            }

            CalcularUsoRecursivo(memoria);
            return memoriaUsada;
        }
    }
}
