using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class HojaRutaFleteEntidad
    {
        public int HojaRutaFlete { get; set; }
        public List<NumeroGuiaFlete> NumerosGuiaFlete { get; set; } = new List<NumeroGuiaFlete>();
        public int DNIFletero { get; set; }
        public Enum EstadoHojaRutaFlete { get; set; }
        public Enum TipoHojaRuta { get; set; }
        public int CodPostal { get; set; }

    }
}
