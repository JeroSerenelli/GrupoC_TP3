using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    internal class Encomienda
    {
        public long Cliente { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string MetodoEntrega { get; set; }
        public int CodigoPostal { get; set; }
        public string CentroDistribucionDestino { get; set; }
        public string Domicilio { get; set; }
        public int CantidadCajas { get; set; }
        public string TipoCaja { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DNI { get; set; }
        public string NumeroGuia { get; set; }
        public int CodigoAgencia { get; set; }

    }
}
