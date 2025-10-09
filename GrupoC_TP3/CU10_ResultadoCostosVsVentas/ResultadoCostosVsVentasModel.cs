using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    internal class ResultadoCostosVsVentasModel
    {
            
            public List<Resultado> Resultados1 { get; set; } = new()
            {
                new Resultado { EmpresaTransporte = "Plusmar", Venta = 100, Costo = 50, ResultadoCV = 50, Fecha = new DateTime(2025, 10, 01) },
                new Resultado { EmpresaTransporte = "Plusmar", Venta = 100, Costo = 50, ResultadoCV = 50, Fecha = new DateTime(2025, 10, 02) },
                new Resultado { EmpresaTransporte = "Flecha Bus", Venta = 200, Costo = 120, ResultadoCV = 80, Fecha = new DateTime(2025, 10, 03) },
                new Resultado { EmpresaTransporte = "Via Bariloche", Venta = 150, Costo = 90, ResultadoCV = 60, Fecha = new DateTime(2025, 10, 04) },
                new Resultado { EmpresaTransporte = "El Rápido", Venta = 180, Costo = 100, ResultadoCV = 80, Fecha = new DateTime(2025, 8, 05) },
                new Resultado { EmpresaTransporte = "Chevallier", Venta = 220, Costo = 130, ResultadoCV = 90, Fecha = new DateTime(2025, 8, 06) },
                new Resultado { EmpresaTransporte = "Andesmar", Venta = 250, Costo = 140, ResultadoCV = 110, Fecha = new DateTime(2024, 10, 07) },
                new Resultado { EmpresaTransporte = "Tata Rápido", Venta = 170, Costo = 95, ResultadoCV = 75, Fecha = new DateTime(2025, 1, 08) }
            };

    }
}
