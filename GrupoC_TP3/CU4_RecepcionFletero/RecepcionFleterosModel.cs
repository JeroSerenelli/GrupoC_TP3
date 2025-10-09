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
        public Dictionary<string, List<HojasDeRutaPorAsignar>> PorAsignarPorFletero { get; } = new()
{
    { "Juan", new List<HojasDeRutaPorAsignar> {
        new() { Fletero = "", HojaDeRuta = "7001", NroGuia = "20001" },
        new() { Fletero = "", HojaDeRuta = "7002", NroGuia = "20002" },
    }},
    { "Pedro", new List<HojasDeRutaPorAsignar> {
        new() { Fletero = "", HojaDeRuta = "7101", NroGuia = "21001" },
        new() { Fletero = "", HojaDeRuta = "7102", NroGuia = "21002" },
    }},
    { "Daniel", new List<HojasDeRutaPorAsignar> {
        new() { Fletero = "", HojaDeRuta = "7201", NroGuia = "22001" },
    }},
    { "Osvaldo", new List<HojasDeRutaPorAsignar> {
        new() { Fletero = "", HojaDeRuta = "7301", NroGuia = "23001" },
        new() { Fletero = "", HojaDeRuta = "7302", NroGuia = "23002" },
        new() { Fletero = "", HojaDeRuta = "7303", NroGuia = "23003" },
    }},
};
    }
}





