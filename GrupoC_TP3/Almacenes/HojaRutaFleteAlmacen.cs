using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class HojaRutaFleteAlmacen
    {
        public static List<HojaRutaFleteEntidad> hojasRutaFletes = new List<HojaRutaFleteEntidad>();

        static HojaRutaFleteAlmacen()
        {
            if (File.Exists("HojaRutaFlete.json"))
            {
                var hojaRutaFleteJson = File.ReadAllText("HojaRutaFlete.json");
                hojasRutaFletes = System.Text.Json.JsonSerializer.Deserialize<List<HojaRutaFleteEntidad>>(hojaRutaFleteJson) ?? new List<HojaRutaFleteEntidad>();
            }
        }

        public static void GuardarHojaDeRutaFlete()
        {
            var hojaRutaFleteJson = System.Text.Json.JsonSerializer.Serialize(hojasRutaFletes);
            File.WriteAllText("HojaRutaFlete.json", hojaRutaFleteJson);

        }
    }
}
