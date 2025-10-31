using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.Almacenes
{
    internal class EmpresaOmnibusEntidad
    {
        public int CUITEmpresaOmnibus { get; set; }
        public string EmpresaOmnibus { get; set; }
        public decimal PrecioDeArrendamiento { get; set; }
        public List<Unidad> Unidades { get; set; } = new List<Unidad>();

    }
}
