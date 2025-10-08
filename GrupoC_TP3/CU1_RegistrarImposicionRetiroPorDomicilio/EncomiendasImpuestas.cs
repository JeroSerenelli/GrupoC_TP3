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

         public int NroCUITCUIL {  get; set; }

        //Informacion Destino
        public string ProvinciaDestino { get; set; }
        public string LocalidadDestino { get; set; }

        public string MetodoEntrega { get; set; }

        public int CPDestino { get; set; }

        public string CdDestino { get; set; }

        public string DomicilioDestinatario { get; set; }

        


        //Datos Encomienda
        public int CantCajas{ get; set; }

        public string TipoCaja { get; set; }

        //Datos Retiro

        public string ProvinciaRetiro { get; set; }
        public string LocalidadRetiro { get; set; }

        public int CPRetiro { get; set; }

        public string CdOrigen { get; set; }

        public string DomicilioRetiro { get; set; }

        //Datos Destinatario
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DNIDestinatario { get; set;  }


        public EncomiendasImpuestas(int CUITCUIL, string provDestino, string localidadDestino, string metodoEntrega, int cpDestino, string cdDestino, string domicilioDestinatario, int cantCajas, string tipoCaja, string provinciaRetiro, string localidadRetiro, int cpRetiro, string cdOrigen, string domicilioRetiro, string nombreDestinatario, string apellidoDestinatario, int dniDestinatario)
        {
            //Datos Destino
            NroCUITCUIL = CUITCUIL;
            ProvinciaDestino = provDestino;
            LocalidadDestino = localidadDestino;
            MetodoEntrega = metodoEntrega;
            CPDestino = cpDestino;
            DomicilioDestinatario = domicilioDestinatario;
            //Datos Encomienda
            CantCajas = cantCajas;
            TipoCaja = tipoCaja; 

            //Datos Retiro
            ProvinciaRetiro = provinciaRetiro;
            LocalidadRetiro = localidadRetiro;
            CPRetiro = cpRetiro;
            CdOrigen = cdOrigen;
            DomicilioRetiro = domicilioRetiro;

            //Datos Destinatario
            NombreDestinatario = nombreDestinatario;
            ApellidoDestinatario = apellidoDestinatario;
            DNIDestinatario = dniDestinatario; 


        }



    }
}
