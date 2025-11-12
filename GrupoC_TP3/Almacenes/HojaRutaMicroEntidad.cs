using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class HojaRutaMicroEntidad
    {
        public int HojaRutaMicro { get; set; }
        public int CentroDistribucionOrigen { get; set; }
        public int CentroDistribucionDestino { get; set; }
        public List<NumeroGuiaMicro> NumerosGuiaMicro { get; set; } = new List<NumeroGuiaMicro>();
        public string PatenteMicro { get; set; }
        public DateTime FechaEmisionHojaDeRuta { get; set; }
        public EstadoHojaRutaMicro EstadoHojaRutaMicro { get; set; }
    }
}
