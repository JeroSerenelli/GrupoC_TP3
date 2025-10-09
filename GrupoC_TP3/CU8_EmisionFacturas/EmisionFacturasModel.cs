using GrupoC_TP3.CU8_EmisionFacturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU3_EmisionFacturas
{
    internal class EmisionFacturasModel
    {
        public List<Factura> Fac { get;  } = new()
        {
            new Factura{NroGuia= 123, SubTotal= 2500},
            new Factura{NroGuia= 456, SubTotal= 1500},
        };
       
    }
}
