using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class EmpresaOmnibusAlmacen
    {
        public static List<EmpresaOmnibusEntidad> empresasOmnibus = new List<EmpresaOmnibusEntidad>();

        static EmpresaOmnibusAlmacen()
        {
            if (File.Exists(@"Datos\EmpresasOmnibus.json"))
            {
                var empresaOmnibusJson = File.ReadAllText(@"Datos\EmpresasOmnibus.json");
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                empresasOmnibus = System.Text.Json.JsonSerializer.Deserialize<List<EmpresaOmnibusEntidad>>(empresaOmnibusJson, options) ?? new List<EmpresaOmnibusEntidad>();
            }
        }

        /*public static void GuardarEmpresaOmnibus() ABM 30/10: comentado dado que no tenemos por que guardar cambios en este almacen.
        {
            var empresaOmnibusJson = System.Text.Json.JsonSerializer.Serialize(empresasOmnibus);
            File.WriteAllText("EmpresasOmnibus.json", empresaOmnibusJson);

        }*/
    }
}
