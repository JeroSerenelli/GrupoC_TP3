using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class GuiaEntidad
    {
        public int NumeroGuia { get; set; }
        public long CUITCUIL { get; set; }
        public int CodPostalDest { get; set; }
        public MetodoEntrega MetodoEntrega { get; set; }
        public string DomicilioDest { get; set; }
        public TamañoCaja TamañoCaja { get; set; }
        public int CodPostalOrig { get; set; }
        public string DomicilioOrigen { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DNIDestinatario { get; set; }
        public decimal Importe { get; set; }
        public int CargosFleteros { get; set; }
        public int CargosAgencia { get; set; }
        public int CodAgenciaOrigen { get; set; }
        public int CodCentroDistOrigen { get; set; }
        public EstadoEncomienda EstadoEncomienda { get; set; }
        public List<HistorialEstadoGuia> HistorialEstadosGuia { get; set; } = new List<HistorialEstadoGuia>();  

    }
}
