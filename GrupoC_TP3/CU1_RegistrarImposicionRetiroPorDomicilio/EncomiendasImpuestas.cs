using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    internal class EncomiendasImpuestas
    {

         // CUIT/CUIL

         public int CUITCUIL {  get; set; }

        //Informacion Destino
        public string ProvinciaDestino { get; set; }
        public string LocalidadDestino { get; set; }

        public string MetodoEntrega { get; set; }

        public int CPDestino { get; set; }

        public string CdDestino { get; set; }

        public string DomicilioDestinatario { get; set; }


        //Datos Encomienda
        public int CantCajas{ get; set; }

        public string tipoCaja { get; set; }

        //Datos Retiro

        public string ProvinciaRetiro { get; set; }
        public string LocalidadRetiro { get; set; }

        public int CPRetiro { get; set; }

        public string CdOrigen { get; set; }

        public string DomicilioRetiro { get; set; }

        //Datos Destinatario



    }
}
