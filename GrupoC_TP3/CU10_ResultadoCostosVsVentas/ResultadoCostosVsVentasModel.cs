using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    internal class ResultadoCostosVsVentasModel
    {
        public List<Resultado> Resultados { get; } = new()
        {
            new Resultado { EmpresaTransporte = "Plusmar", Venta = 100, Costo = 50, ResultadoCV = 50},
        };


    }
}
