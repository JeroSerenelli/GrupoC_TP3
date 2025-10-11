using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio
{
    public class Ubicacion
    {
        //TODO: Esto no se debería ir al modelo? Que hago con la declaracion de los diccionarios?
        public Dictionary<string, List<string>> ProvinciasYLocalidades { get; set; }
        public Dictionary<string, string> CodigoPostalCentroDistribucion { get; set; }

        public Ubicacion()
        {
            ProvinciasYLocalidades = new Dictionary<string, List<string>>
                {
                    { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
                    { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
                    { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },

                };

            CodigoPostalCentroDistribucion = new Dictionary<string, string>
                {
                    { "1900", "Centro La Plata" },
                    { "7600", "Centro Mar del Plata" },
                    { "8000", "Centro Bahía Blanca" },
                    { "5000", "Centro Córdoba Capital" },
                    { "5900", "Centro Villa María" },
                    { "5800", "Centro Río Cuarto" },
                    { "2000", "Centro Rosario" },
                    { "3000", "Centro Santa Fe Capital" },
                    { "2300", "Centro Rafaela" }
                };
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
