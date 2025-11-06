using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class AdicionalesYComisionesAlmacen
    {
        public static List<AdicionalesYComisionesEntidad> adicionalesComisiones = new List<AdicionalesYComisionesEntidad>();

        static AdicionalesYComisionesAlmacen()
        {
            if (File.Exists(@"Datos\AdicionalesComisiones.json"))
            {
                var adicionalesComisionesJson = File.ReadAllText(@"Datos\AdicionalesComisiones.json");
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                options.UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow;
                adicionalesComisiones = System.Text.Json.JsonSerializer.Deserialize<List<AdicionalesYComisionesEntidad>>(adicionalesComisionesJson, options) ?? new List<AdicionalesYComisionesEntidad>();
            }
        }

        /*public static void GuardarAdicionalesComisiones() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var adicionalesComisionesJson = System.Text.Json.JsonSerializer.Serialize(adicionalesComisiones);
            File.WriteAllText("AdicionalesComisiones.json", adicionalesComisionesJson);

        }*/
    }
}
