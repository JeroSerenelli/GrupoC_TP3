using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class ClienteAlmacen
    {
        public static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        static ClienteAlmacen()
        {
            if (File.Exists(@"Datos\Clientes.json"))
            {
                var clienteJson = File.ReadAllText(@"Datos\Clientes.json");
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                clientes = System.Text.Json.JsonSerializer.Deserialize<List<ClienteEntidad>>(clienteJson, options) ?? new List<ClienteEntidad>();
            }
        }

        public static void GuardarCliente()
        {
            var clienteJson = System.Text.Json.JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"Datos\Clientes.json", clienteJson);
        }
    }
}
