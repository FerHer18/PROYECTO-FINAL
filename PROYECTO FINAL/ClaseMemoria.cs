using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class ClaseMemoria
    {
        public int Tamanio { get; set; }
        public bool Libre { get; set; }
        public ClaseMemoria Izquierda { get; set; }
        public ClaseMemoria Derecha { get; set; }
        public ClaseMemoria Padre { get; set; }

        public ClaseMemoria(int tamanio)
        {
            Tamanio = tamanio;
            Libre = true;
            Izquierda = null;
            Derecha = null;
            Padre = null;
        }

        public void Coalescer() //soporte para coalescencia de bloques al liberar memoria.
        {
            if (Padre == null) return;

            if (Padre.Izquierda.Libre && Padre.Derecha.Libre)
            {
                Padre.Izquierda = null;
                Padre.Derecha = null;
                Padre.Libre = true;
                Padre.Coalescer();
            }
        }
    }
}
