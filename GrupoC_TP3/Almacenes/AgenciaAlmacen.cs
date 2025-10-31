using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class AgenciaAlmacen
    {
        public static List<AgenciaEntidad> agencias = new List<AgenciaEntidad>();

        static AgenciaAlmacen()
        {
            if (File.Exists("Agencias.json"))
            {
                var agenciaJson = File.ReadAllText("Agencias.json");
                agencias = System.Text.Json.JsonSerializer.Deserialize<List<AgenciaEntidad>>(agenciaJson) ?? new List<AgenciaEntidad>();
            }
        }

        /*public static void GuardarAgencias() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var agenciaJson = System.Text.Json.JsonSerializer.Serialize(agencias);
            File.WriteAllText("Agencias.json", agenciaJson);

        }*/
    }
}
