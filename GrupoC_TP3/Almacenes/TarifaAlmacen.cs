using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class TarifaAlmacen
    {
        public static List<TarifaEntidad> tarifas = new List<TarifaEntidad>();

        static TarifaAlmacen()
        {
            if (File.Exists("Tarifas.json"))
            {
                var tarifaJson = File.ReadAllText("Tarifas.json");
                tarifas = System.Text.Json.JsonSerializer.Deserialize<List<TarifaEntidad>>(tarifaJson) ?? new List<TarifaEntidad>();
            }
        }

        /*public static void GuardarTarifas() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var tarifaJson = System.Text.Json.JsonSerializer.Serialize(tarifas);
            File.WriteAllText("Tarifas.json", tarifaJson);

        }*/
    }
}
