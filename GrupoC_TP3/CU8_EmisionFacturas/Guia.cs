using GrupoC_TP3.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU8_EmisionFacturas
{
    public class Guia
    {
        public int NumeroGuia { get; set; }
        public long CUITCUIL { get; set; }
        public string RazonSocial { get; set; }
        public int CodPostalDest { get; set; }
        public string DomicilioDest { get; set; }
        public decimal Importe { get; set; }

    }
}
