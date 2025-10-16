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
            new HojasDeRutaAsignadas { Fletero = "Juan",   HojaDeRuta = "6254", NroGuia = "17397", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro",  HojaDeRuta = "6255", NroGuia = "17398", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Daniel", HojaDeRuta = "6256", NroGuia = "17399", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Osvaldo",HojaDeRuta = "6257", NroGuia = "17400", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Juan",   HojaDeRuta = "6277", NroGuia = "17397", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro",  HojaDeRuta = "6278", NroGuia = "17398", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro",  HojaDeRuta = "6279", NroGuia = "17398", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Daniel", HojaDeRuta = "6280", NroGuia = "17399", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Daniel", HojaDeRuta = "6281", NroGuia = "17400", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Daniel", HojaDeRuta = "6282", NroGuia = "17401", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Osvaldo",HojaDeRuta = "6283", NroGuia = "17402", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Osvaldo",HojaDeRuta = "6284", NroGuia = "17403", Estado = "No Cumplida"}
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
