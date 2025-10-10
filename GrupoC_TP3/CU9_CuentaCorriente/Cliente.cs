using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU9_CuentaCorriente
{
    public class Cliente
    {
        public string CUITCUIL { get; set; } = "";
        public string RazonSocial { get; set; } = "";
        public List<MovimientoCC> Movimientos { get; set; } = new();
    }
}

