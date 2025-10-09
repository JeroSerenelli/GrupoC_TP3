using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    internal class RecepcionFleterosModel
    {
        public List<HojasdeRutaAsignadas> Fleteros { get; } = new()
        {
            new HojasdeRutaAsignadas { Fletero = "Juan", HojaDeRuta = "12345", NroGuia = "12312314" , Estado = "Cumplido"},
            new HojasdeRutaAsignadas{ Fletero = "Juan", HojaDeRuta = "12345", NroGuia = "12312314", Estado = "Cumplido"},
             new HojasdeRutaAsignadas{ Fletero = "Juan", HojaDeRuta = "12345", NroGuia = "12312314", Estado = "No Cumplido"},
            new HojasdeRutaAsignadas { Fletero = "Osvaldo", HojaDeRuta = "5612", NroGuia = "87321123", Estado = "Cumplido"},
        };
    }
}

