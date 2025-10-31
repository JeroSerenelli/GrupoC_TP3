using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class ClienteEntidad
    {
        public int CUITCUIL { get; set; }
        public string RazonSocial { get; set; }
        public Enum CondicionCliente { get; set; }
        public List<Autorizados> AutorizadosImposicion { get; set; } = new List<Autorizados>();

    }
}
