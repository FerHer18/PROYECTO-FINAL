using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class ClaseProceso
    {
        public int Id { get; set; }
        public int TiempoLlegada { get; set; }
        public int TiempoEjecucion { get; set; }
        public int TiempoRestante { get; set; }
        public int TamanioMemoria { get; set; }
        public string Estado { get; set; }

        public ClaseProceso(int id, int llegada, int ejecucion, int tamanio)
        {
            Id = id;
            TiempoLlegada = llegada;
            TiempoEjecucion = ejecucion;
            TiempoRestante = ejecucion;
            TamanioMemoria = tamanio;
            Estado = "Listo";
        }
    }
}
