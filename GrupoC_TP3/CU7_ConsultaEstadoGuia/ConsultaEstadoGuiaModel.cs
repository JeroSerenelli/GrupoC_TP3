using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU7_ConsultaEstadoGuia
{
    internal class ConsultaEstadoGuiaModel
    {
        public List<Guia> ObtenerHistorialPorNumero(long numeroGuia)
        {
            if (numeroGuia <= 0)
                throw new ArgumentException("El número de guía debe ser positivo.");

            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == (int)numeroGuia);
            if (guia == null)
                throw new KeyNotFoundException("El número de guía ingresado no existe.");

            var historial = guia.HistorialEstadosGuia
                .OrderByDescending(h => h.Fecha)
                .Select(h => new Guia
                {
                    NumeroGuia = numeroGuia,                       
                    EstadoGuia = h.Descripcion,                    
                    UltActualizacion = h.Fecha.ToString("yyyy-MM-dd HH:mm")
                })
                .ToList();

            return historial;
        }
    }

}



