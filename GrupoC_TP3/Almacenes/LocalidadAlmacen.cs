using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class LocalidadAlmacen
    {
        public static List<LocalidadEntidad> localidades = new List<LocalidadEntidad>();

        static LocalidadAlmacen()
        {
            if (File.Exists("Localidades.json"))
            {
                var localidadJson = File.ReadAllText("Localidades.json");
                localidades = System.Text.Json.JsonSerializer.Deserialize<List<LocalidadEntidad>>(localidadJson) ?? new List<LocalidadEntidad>();
            }
        }

        /*public static void GuardarLocalidades() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var localidadJson = System.Text.Json.JsonSerializer.Serialize(localidades);
            File.WriteAllText("Localidades.json", localidadJson);

        }*/
    }
}
