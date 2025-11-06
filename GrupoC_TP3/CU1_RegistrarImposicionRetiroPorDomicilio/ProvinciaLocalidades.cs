using GrupoC_TP3.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    public class Ubicacion
    {
        public Dictionary<string, List<string>> ProvinciasYLocalidades { get; set; }
        public Dictionary<string, string> CodigoPostalCentroDistribucion { get; set; }

        public Ubicacion()
        {
           
        }

        public static class ProvinciasLocalidades
        {
            // Índice: CP -> Centro de Distribución (se construye una sola vez)
            private static Dictionary<int, CentroDistribucionEntidad> _cdPorCp;
            private static bool _indiceCdConstruido;

        }

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
