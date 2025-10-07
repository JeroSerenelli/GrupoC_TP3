using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_CuentaCorriente
{
    internal class CuentaCorrienteModel
    {
        public List<Cliente> Clientes { get; } = new()
        {
            new Cliente { RazonSocial= "LA Anonima", CUITCUIL = "23-34143433-6", NombreSocilitante = "Juan", ApellidoSolicitante = "Cito"},
            new Cliente { RazonSocial= "LA Anonima", CUITCUIL = "23-34143433-6", NombreSocilitante = "Juan", ApellidoSolicitante = "Cito"}
        }; 
    }
}
