using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU6_EntregaEncomiendas
{
    internal class EmpleadosCliente
    {
        public class Empleado
        {
            public string Dni { get; }
            public string Nombre { get; }
            public string Apellido { get; }

            public override string ToString()
            {
                return $"{Nombre} {Apellido} (DNI: {Dni})";
            }
        }
        public class Cliente
        {
            public string Cuit { get; }
            public string RazonSocial { get; }
            public List<Empleado> Empleados { get; } = new List<Empleado>();
        }

        

    }
}
