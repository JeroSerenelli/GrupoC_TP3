using GrupoC_TP3.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU10_ResultadoCostosVsVentas
{
    internal class ResultadoCostosVsVentasModel
    {   
        

        public List<Resultado> Resultados1 { get; set; } = EmpresaOmnibusAlmacen.empresasOmnibus
        .Select(empresa => new Resultado
        {
            EmpresaTransporte = empresa.EmpresaOmnibus,
            Venta = empresa.Unidades
                .SelectMany(u => HojaRutaMicroAlmacen.hojasRutaMicros
                    .Where(h => h.PatenteMicro == u.PatenteMicro) 
                    .SelectMany(h => h.NumerosGuiaMicro)
                    .Select(gm => GuiaAlmacen.guias
                        .FirstOrDefault(g => g.NumeroGuia == gm.NumeroGuia && g.EstadoEncomienda == EstadoEncomienda.Entregado))
                    .Where(g => g != null)
                    .Select(g => g.Importe))
                .Sum(),
            Costo = empresa.PrecioDeArrendamiento,
            ResultadoCV = 
                empresa.Unidades
                .SelectMany(u => HojaRutaMicroAlmacen.hojasRutaMicros
                    .Where(h => h.PatenteMicro == u.PatenteMicro)
                    .SelectMany(h => h.NumerosGuiaMicro)
                    .Select(gm => GuiaAlmacen.guias
                        .FirstOrDefault(g => g.NumeroGuia == gm.NumeroGuia && g.EstadoEncomienda == EstadoEncomienda.Entregado))
                    .Where(g => g != null)
                    .Select(g => g.Importe))
                .Sum() - (
                empresa.PrecioDeArrendamiento),
            Fecha = DateTime.Now //TODO: no se como manejar esta fecha
            
        })
        .ToList();
    }
}
