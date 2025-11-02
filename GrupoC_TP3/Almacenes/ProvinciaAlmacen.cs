using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class ProvinciaAlmacen
    {
        public static List<ProvinciaEntidad> provincias = new List<ProvinciaEntidad>();

        static ProvinciaAlmacen()
        {
            if (File.Exists(@"Datos\Provincias.json"))
            {
                var provinciaJson = File.ReadAllText(@"Datos\Provincias.json");
                provincias = System.Text.Json.JsonSerializer.Deserialize<List<ProvinciaEntidad>>(provinciaJson) ?? new List<ProvinciaEntidad>();
            }
        }

        /*public static void GuardarProvincia() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var provinciaJson = System.Text.Json.JsonSerializer.Serialize(provincias);
            File.WriteAllText("Provincias.json", provinciaJson);

        }*/
    }
}
