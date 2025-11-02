using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class TarifaEntidad
    {
        public TamañoCaja TamañoCaja { get; set; }
        public int CentroDistribucionOrigen { get; set; }
        public int CentroDistribucionDestino { get; set; }
        public decimal Importe { get; set; }

    }
}
