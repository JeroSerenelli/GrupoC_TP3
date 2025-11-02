using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new List<GuiaEntidad>();

        static GuiaAlmacen()
        {
            if (File.Exists(@"Datos\Guias.json"))
            {
                var guiaJson = File.ReadAllText(@"Datos\Guias.json");
                guias = System.Text.Json.JsonSerializer.Deserialize<List<GuiaEntidad>>(guiaJson) ?? new List<GuiaEntidad>();
            }
        }

        public static void GuardarGuia()
        {
            var guiaJson = System.Text.Json.JsonSerializer.Serialize(guias);
            File.WriteAllText(@"Datos\Guias.json", guiaJson);

        }
    }
}
