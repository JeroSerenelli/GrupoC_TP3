using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class Recorrido
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public int CentroDistribucionDestino { get; set; }
        public int CentroDistribucionOrigen { get; set; }

    }
}
