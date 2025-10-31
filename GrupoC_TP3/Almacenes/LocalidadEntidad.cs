using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class LocalidadEntidad
    {
        public int CodLocalidad { get; set; }
        public int CodProv { get; set; }
        public string Nombre { get; set; }
        public List<CodigosPostales> CodigosPostales { get; set; } = new List<CodigosPostales>();

    }
}
