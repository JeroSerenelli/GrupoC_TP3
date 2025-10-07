using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU4_RegistrarImposicionEnAgencia
{
    internal class GenerarNuevaSolicitud
    {
        //Datos Solicitante
        public string textBoxNombreSolicitante { get; set; }

        public string textBoxApellidoSolicitante { get; set; }
        public string textBoxRazonSocial { get; set; }
        public string textBoxCUITCUIL { get; set; }

        // Datos Destinatario
        public string textBoxNombreDestinatario { get; set; }

        public string textBoxApellidoDestinatario { get; set; }
        public int textBoxDNI { get; set; }

        public string textBoxDomicilioDestinatario { get; set; }


        // Datos Encomineda

        public int textBoxCantidadCaja { get; set; }
        public string comboBoxTipoCaja { get; set; }

        public string textBoxCodigoPostOrigen { get; set; }
        public string comboBoxCentroDistOrigen { get; set; }

        public string textBoxDestinoEncomienda { get; set; }

        public string textBoxCodPostDestino {  get; set; }

        public string comboBoxCentroDistDestino { get; set; }

        public string comboBoxMetodoEntrega { get; set; }




    }
}
