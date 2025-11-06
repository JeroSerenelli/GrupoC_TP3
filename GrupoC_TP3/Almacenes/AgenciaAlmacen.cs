using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace GrupoC_TP3.Almacenes
{
    static class AgenciaAlmacen
    {
        public static AgenciaEntidad AgenciaActual { get; set; }

        public static List<AgenciaEntidad> agencias = new List<AgenciaEntidad>();

        static AgenciaAlmacen()
        {
            if (File.Exists(@"Datos\Agencias.json"))
            {
                var agenciaJson = File.ReadAllText(@"Datos\Agencias.json");
                var options = new JsonSerializerOptions();
                options.UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow;
                agencias = System.Text.Json.JsonSerializer.Deserialize<List<AgenciaEntidad>>(agenciaJson, options) ?? new List<AgenciaEntidad>();
            }
        }

        /*public static void GuardarAgencias() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var agenciaJson = System.Text.Json.JsonSerializer.Serialize(agencias);
            File.WriteAllText("Agencias.json", agenciaJson);

        }*/
    }
}
