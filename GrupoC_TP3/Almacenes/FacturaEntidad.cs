using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class FacturaEntidad
    {
        public int NumeroFactura { get; set; }
        public long CUITCUIL { get; set; }
        public decimal Total { get; set; }
        public TipoFactura TipoFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public EstadoFactura EstadoFactura { get; set; }
    }
}
