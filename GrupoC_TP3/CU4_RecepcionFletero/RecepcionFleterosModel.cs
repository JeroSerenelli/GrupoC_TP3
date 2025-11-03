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
        // Hardcodeado para coincidir con Datos\HojaDeRutaFlete.json:
        // sólo incluyo las HDR con Estado "NoCumplida" (mapeadas a "No Cumplida")
        public List<HojasDeRutaAsignadas> Fleteros { get; } = new()
        {
            // HojaRutaFlete 1 - DNIFletero 33190535 -> Agustina Herrera (NoCumplida)
            new HojasDeRutaAsignadas { Fletero = "Agustina Herrera", HojaDeRuta = "1", NroGuia = "147929", Estado = "No Cumplida" },
            new HojasDeRutaAsignadas { Fletero = "Agustina Herrera", HojaDeRuta = "1", NroGuia = "641739", Estado = "No Cumplida" },
            new HojasDeRutaAsignadas { Fletero = "Agustina Herrera", HojaDeRuta = "1", NroGuia = "438715", Estado = "No Cumplida" },

            // HojaRutaFlete 4 - DNIFletero 24807375 -> Agustina Flores (NoCumplida)
            new HojasDeRutaAsignadas { Fletero = "Agustina Flores", HojaDeRuta = "4", NroGuia = "800051", Estado = "No Cumplida" },
            new HojasDeRutaAsignadas { Fletero = "Agustina Flores", HojaDeRuta = "4", NroGuia = "958537", Estado = "No Cumplida" },
            
            // HojaRutaFlete 11 - DNIFletero 42629238 -> Julieta Rodríguez (NoCumplida)
            new HojasDeRutaAsignadas { Fletero = "Julieta Rodríguez", HojaDeRuta = "11", NroGuia = "451319", Estado = "No Cumplida" },
            new HojasDeRutaAsignadas { Fletero = "Julieta Rodríguez", HojaDeRuta = "11", NroGuia = "798364", Estado = "No Cumplida" },
            new HojasDeRutaAsignadas { Fletero = "Julieta Rodríguez", HojaDeRuta = "11", NroGuia = "730112", Estado = "No Cumplida" },
        };

        // Hardcodeado con las HDR que en HojaDeRutaFlete.json están en "PendienteAsignación"
        public Dictionary<string, List<HojasDeRutaPorAsignar>> PorAsignarPorFletero { get; } = new()
        {
            // HojaRutaFlete 2 - DNIFletero 28373390 -> Carlos Castro (PendienteAsignación)
            { "Carlos Castro", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Carlos Castro", HojaDeRuta = "2", NroGuia = "407192" },
                new() { Fletero = "Carlos Castro", HojaDeRuta = "2", NroGuia = "171993" },
                new() { Fletero = "Carlos Castro", HojaDeRuta = "2", NroGuia = "595934" },
            }},

            // HojaRutaFlete 7 - DNIFletero 21295377 -> Lucía Suárez (PendienteAsignación)
            { "Lucía Suárez", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Lucía Suárez", HojaDeRuta = "7", NroGuia = "724514" },
                new() { Fletero = "Lucía Suárez", HojaDeRuta = "7", NroGuia = "469329" },
            }},

            // HojaRutaFlete 8 - DNIFletero 35589539 -> Juan Alvarez (PendienteAsignación)
            { "Juan Alvarez", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Juan Alvarez", HojaDeRuta = "8", NroGuia = "199267" },
                new() { Fletero = "Juan Alvarez", HojaDeRuta = "8", NroGuia = "584117" },
            }},

            // HojaRutaFlete 9 - DNIFletero 42629238 -> Julieta Rodríguez (PendienteAsignación)
            { "Julieta Rodríguez", new List<HojasDeRutaPorAsignar> {
                new() { Fletero = "Julieta Rodríguez", HojaDeRuta = "9", NroGuia = "551319" },
                new() { Fletero = "Julieta Rodríguez", HojaDeRuta = "9", NroGuia = "788364" },
                new() { Fletero = "Julieta Rodríguez", HojaDeRuta = "9", NroGuia = "710112" },
            }},
        };

        // Devuelve TODOS los fleteros definidos en FleteroAlmacen (Nombre + Apellido)
        // No filtramos por estado, esto siempre trae el listado completo del JSON.
        public List<string> ObtenerNombresFleteros()
        {
            return FleteroAlmacen.fleteros
                .Where(f => !string.IsNullOrWhiteSpace(f.NombreFletero))
                .Select(f => ($"{f.NombreFletero} {f.ApellidoFletero}").Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                .ToList();
        }
    }
}
