using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    static class ClienteAlmacen
    {
        public static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        static ClienteAlmacen()
        {
            if (File.Exists("Clientes.json"))
            {
                var clienteJson = File.ReadAllText("Clientes.json");
                clientes = System.Text.Json.JsonSerializer.Deserialize<List<ClienteEntidad>>(clienteJson) ?? new List<ClienteEntidad>();
            }
        }

        public static void GuardarCliente()
        {
            var clienteJson = System.Text.Json.JsonSerializer.Serialize(clientes);
            File.WriteAllText("Clientes.json", clienteJson);

        }
    }
}
