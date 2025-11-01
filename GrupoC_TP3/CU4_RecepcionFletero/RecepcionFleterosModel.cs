using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using GrupoC_TP3.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public class RecepcionFleterosModel
    {
        // Ahora usamos "Nombre Apellido" para todas las referencias internas
        public List<HojasDeRutaAsignadas> Fleteros { get; } = new()
        {
            new HojasDeRutaAsignadas { Fletero = "Juan Pérez",    HojaDeRuta = "6254", NroGuia = "17397", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro García",  HojaDeRuta = "6255", NroGuia = "17398", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "María González",HojaDeRuta = "6256", NroGuia = "17399", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Lucía Ramírez", HojaDeRuta = "6257", NroGuia = "17400", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Juan Pérez",    HojaDeRuta = "6258", NroGuia = "17401", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro García",  HojaDeRuta = "6259", NroGuia = "17402", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Pedro García",  HojaDeRuta = "6260", NroGuia = "17403", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "María González",HojaDeRuta = "6261", NroGuia = "17404", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "María González",HojaDeRuta = "6262", NroGuia = "17405", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "María González",HojaDeRuta = "6263", NroGuia = "17406", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Lucía Ramírez", HojaDeRuta = "6264", NroGuia = "17407", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Lucía Ramírez", HojaDeRuta = "6265", NroGuia = "17408", Estado = "No Cumplida"},
            new HojasDeRutaAsignadas { Fletero = "Homero Thompson", HojaDeRuta = "6266", NroGuia = "17409", Estado = "No Cumplida"}
        };

        public Dictionary<string, List<HojasDeRutaPorAsignar>> PorAsignarPorFletero { get; } = new()
        {
            { "Juan Pérez", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Juan Pérez", HojaDeRuta = "7001", NroGuia = "20001" },
                new() { Fletero = "Juan Pérez", HojaDeRuta = "7002", NroGuia = "20002" },
            }},
            { "Pedro García", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Pedro García", HojaDeRuta = "7101", NroGuia = "21001" },
                new() { Fletero = "Pedro García", HojaDeRuta = "7102", NroGuia = "21002" },
            }},
            { "María González", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "María González", HojaDeRuta = "7201", NroGuia = "22001" },
            }},
            { "Lucía Ramírez", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Lucía Ramírez", HojaDeRuta = "7301", NroGuia = "23001" },
                new() { Fletero = "Lucía Ramírez", HojaDeRuta = "7302", NroGuia = "23002" },
                new() { Fletero = "Lucía Ramírez", HojaDeRuta = "7303", NroGuia = "23003" },
            }},
            { "Homero Thompson", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Homero Thompson", HojaDeRuta = "7401", NroGuia = "24001" },
            }},
        };

        public List<string> ObtenerNombresFleteros()
        {
            var desdeAlmacen = FleteroAlmacen.fleteros
                .Where(f => !string.IsNullOrWhiteSpace(f.NombreFletero))
                .Select(f => ($"{f.NombreFletero} {f.ApellidoFletero}").Trim());

            var desdeModelo = Fleteros
                .Where(f => !string.IsNullOrWhiteSpace(f.Fletero))
                .Select(f => f.Fletero.Trim());

            var clavesPorAsignar = PorAsignarPorFletero?.Keys ?? Enumerable.Empty<string>();

            var conjunto = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var n in desdeAlmacen) conjunto.Add(n);
            foreach (var n in desdeModelo) conjunto.Add(n);
            foreach (var n in clavesPorAsignar) conjunto.Add(n);

            return conjunto.OrderBy(n => n, StringComparer.OrdinalIgnoreCase).ToList();
        }
    }
}
