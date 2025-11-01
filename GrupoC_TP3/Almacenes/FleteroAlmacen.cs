using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class FleteroAlmacen
    {
        public static List<FleteroEntidad> fleteros = new List<FleteroEntidad>();

        static FleteroAlmacen()
        {
            if (File.Exists(@"Datos\Fletero.json"))
            {
                var fleteroJson = File.ReadAllText(@"Datos\Fletero.json");
                fleteros = System.Text.Json.JsonSerializer.Deserialize<List<FleteroEntidad>>(fleteroJson) ?? new List<FleteroEntidad>();
            }
        }

        /*public static void GuardarFletero() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var fleteroJson = System.Text.Json.JsonSerializer.Serialize(fleteros);
            File.WriteAllText("Fleteros.json", fleteroJson);

        }*/
    }
}
