using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class CronogramaOmnibusEntidad
    {
        public string PatenteMicro { get; set; }
        public List<Recorrido> Recorridos { get; set; } = new List<Recorrido>();
    }
}
