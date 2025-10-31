using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class CuentaCorrienteEntidad
    {
        public int CUITCUIL { get; set; }

        public DateTime FechaMovimiento { get; set; }
        public decimal Monto { get; set; }
        
    }
}
