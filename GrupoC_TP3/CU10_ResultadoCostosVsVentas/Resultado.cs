using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    public class Resultado
    {
        public string EmpresaTransporte { get; set; }
        public decimal Venta { get; set; }
        public decimal Costo { get; set; }
        public decimal ResultadoCV { get; set; }

        public DateTime Fecha { get; set; }
    }
}
