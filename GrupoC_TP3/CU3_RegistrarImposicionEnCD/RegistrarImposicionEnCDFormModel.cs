using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU3_RegistrarImposicionEnCD
{
    internal class RegistrarImposicionEnCDFormModel
    {
        //Vamos a ver que datos necesita este formulario

        //lo que me trae el fomrulario
        public long Cuil { get; set; }

        public int CodigoPostal { get; set; }

        public string CDDestino { get; set; }

        public string Domicilio { get; set; }

        public int CantidadDeCajas { get; set; }

        public string NombreDestinatario { get; set; }

        public string ApellidoDestinatario { get; set; }

        public int DNI { get; set; }

        //FALTARIA AGREGAR: TIPO DE CAJA, PROVINCIA, LOCALIDAD, METODO DE ENTREGA

    }
}
