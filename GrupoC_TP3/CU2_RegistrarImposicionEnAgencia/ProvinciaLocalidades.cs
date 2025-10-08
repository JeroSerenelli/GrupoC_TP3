using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    internal class ProvinciaLocalidades
    {
        public class Ubicacion
        {
            public Dictionary<string, List<string>> ProvinciasYLocalidades { get; }

            public Ubicacion()
            {
                ProvinciasYLocalidades = new Dictionary<string, List<string>>
                {
                    { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
                    { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
                    { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },

                };
            }
        }
    }
}
