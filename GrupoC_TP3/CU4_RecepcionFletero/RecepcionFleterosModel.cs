using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public class RecepcionFleterosModel
    {
        public List<HojasDeRutaAsignadas> Fleteros { get; } = new()
        {
            new HojasDeRutaAsignadas { Fletero = "Juan",   HojaDeRuta = "6254", NroGuia = "17397", Estado = "Cumplido"},
            new HojasDeRutaAsignadas { Fletero = "Pedro",  HojaDeRuta = "6255", NroGuia = "17398", Estado = "Cumplido"},
            new HojasDeRutaAsignadas { Fletero = "Daniel", HojaDeRuta = "6256", NroGuia = "17399", Estado = "No Cumplido"},
            new HojasDeRutaAsignadas { Fletero = "Osvaldo",HojaDeRuta = "6257", NroGuia = "17400", Estado = "No Cumplido"},
        };

        public List<HojasDeRutaPorAsignar> Transportistas { get; } = new()
        {
            new HojasDeRutaPorAsignar { Fletero = "", HojaDeRuta = "6258", NroGuia = "17401" },
            new HojasDeRutaPorAsignar { Fletero = "", HojaDeRuta = "6259", NroGuia = "17402" },
            new HojasDeRutaPorAsignar { Fletero = "", HojaDeRuta = "6260", NroGuia = "17403" },
            new HojasDeRutaPorAsignar { Fletero = "", HojaDeRuta = "6261", NroGuia = "17404" },
        };
    }
}





