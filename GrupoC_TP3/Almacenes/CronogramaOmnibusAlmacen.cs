using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class CronogramaOmnibusAlmacen
    {
        public static List<CronogramaOmnibusEntidad> cronogramasOmnibus = new List<CronogramaOmnibusEntidad>();

        static CronogramaOmnibusAlmacen()
        {
            if (File.Exists("CronogramaOmnibus.json"))
            {
                var cronogramaOmnibusJson = File.ReadAllText("CronogramaOmnibus.json");
                cronogramasOmnibus = System.Text.Json.JsonSerializer.Deserialize<List<CronogramaOmnibusEntidad>>(cronogramaOmnibusJson) ?? new List<CronogramaOmnibusEntidad>();
            }
        }

        /*public static void GuardarCronogramasOmnibus() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var cronogramaOmnibusJson = System.Text.Json.JsonSerializer.Serialize(cronogramasOmnibus);
            File.WriteAllText("CronogramaOmnibus.json", cronogramaOmnibusJson);

        }*/
    }
}
