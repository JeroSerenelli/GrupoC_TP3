using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    public class Ubicacion
    {
        public Dictionary<string, List<string>> ProvinciasYLocalidades { get; set; }
        public Dictionary<string, string> CodigoPostalCentroDistribucion { get; set; }

        public string ObtenerCentroDistribucion(string codigoPostal)
        {
            if (CodigoPostalCentroDistribucion.TryGetValue(codigoPostal, out string centro))
            {
                return centro;
            }
            else
            {
                return "Centro de distribución no encontrado";
            }

        }

    }



}

