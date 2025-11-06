using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class FacturaAlmacen
    {
        public static List<FacturaEntidad> facturas = new List<FacturaEntidad>();

        static FacturaAlmacen()
        {
            if (File.Exists(@"Datos\Facturas.json"))
            {
                var facturaJson = File.ReadAllText(@"Datos\Facturas.json");
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                facturas = System.Text.Json.JsonSerializer.Deserialize<List<FacturaEntidad>>(facturaJson, options) ?? new List<FacturaEntidad>();
            }
        }

        public static void GuardarFacturas()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            var facturaJson = System.Text.Json.JsonSerializer.Serialize(facturas, options);
            File.WriteAllText(@"Datos\Facturas.json", facturaJson);
        }
    }
}
