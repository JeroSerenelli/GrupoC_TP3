using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                options.UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow;
                hojasRutaMicros = System.Text.Json.JsonSerializer.Deserialize<List<HojaRutaMicroEntidad>>(hojasRutaMicrosJson, options) ?? new List<HojaRutaMicroEntidad>();
            }
        }

        public static void GuardarHojaDeRutaMicro()
        {


           // var hojasRutaMicrosJson = System.Text.Json.JsonSerializer.Serialize(hojasRutaMicros);
            //File.WriteAllText(@"Datos\HojasRutaMicros.json", hojasRutaMicrosJson);



            var options = new JsonSerializerOptions { WriteIndented = true };
            var hojasRutaMicrosJson = JsonSerializer.Serialize(hojasRutaMicros, options);
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "HojasRutaMicros.json");
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
            File.WriteAllText(path, hojasRutaMicrosJson);

        }
    }
}
