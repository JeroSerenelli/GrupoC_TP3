using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class TarifaAlmacen
    {
        public static List<TarifaEntidad> tarifas = new List<TarifaEntidad>();

        static TarifaAlmacen()
        {
            if (File.Exists(@"Datos\Tarifas.json"))
            {
                var tarifaJson = File.ReadAllText(@"Datos\Tarifas.json");
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                tarifas = System.Text.Json.JsonSerializer.Deserialize<List<TarifaEntidad>>(tarifaJson, options) ?? new List<TarifaEntidad>();
            }
        }

        /*public static void GuardarTarifas() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var tarifaJson = System.Text.Json.JsonSerializer.Serialize(tarifas);
            File.WriteAllText("Tarifas.json", tarifaJson);

        }*/
    }
}
