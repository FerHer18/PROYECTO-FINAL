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

        public ClaseMemoria(int tamanio)
        {
            Tamanio = tamanio;
            Libre = true;
            Izquierda = null;
            Derecha = null;
        }
    }
}
