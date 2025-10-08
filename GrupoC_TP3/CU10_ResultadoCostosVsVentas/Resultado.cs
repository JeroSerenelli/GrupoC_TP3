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
        public int Venta { get; set; }
        public int Costo { get; set; }
        public int ResultadoCV { get; set; } = 0;
    }
}
