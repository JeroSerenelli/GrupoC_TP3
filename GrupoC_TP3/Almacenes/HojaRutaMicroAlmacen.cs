using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class HojaRutaMicroAlmacen
    {
        public static List<HojaRutaMicroEntidad> hojasRutaMicros = new List<HojaRutaMicroEntidad>();

        static HojaRutaMicroAlmacen()
        {
            if (File.Exists(@"Datos\HojasRutaMicros.json"))
            {
                var hojasRutaMicrosJson = File.ReadAllText(@"Datos\HojasRutaMicros.json");
                hojasRutaMicros = System.Text.Json.JsonSerializer.Deserialize<List<HojaRutaMicroEntidad>>(hojasRutaMicrosJson) ?? new List<HojaRutaMicroEntidad>();
            }
        }

        public static void GuardarHojaDeRutaMicro()
        {
            var hojasRutaMicrosJson = System.Text.Json.JsonSerializer.Serialize(hojasRutaMicros);
            File.WriteAllText(@"Datos\HojasRutaMicros.json", hojasRutaMicrosJson);

        }
    }
}
