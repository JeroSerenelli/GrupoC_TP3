using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU7_ConsultaEstadoGuia
{
    internal class ConsultaEstadoGuiaModel
    {

        public List<Guia> Guias { get; } = new()
        {
            new Guia { NumeroGuia = 1111, EstadoGuia = "Entregado", UltActualizacion = "2025-10-08" },
            new Guia { NumeroGuia = 1111, EstadoGuia = "En camino a CD", UltActualizacion = "2025-10-07" },
            new Guia { NumeroGuia = 4444, EstadoGuia = "En Agencia", UltActualizacion = "2023-10-08" },
        };



        
    }
}
