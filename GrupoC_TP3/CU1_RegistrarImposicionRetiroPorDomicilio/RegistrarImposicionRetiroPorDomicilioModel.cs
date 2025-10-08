using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU2_RegistrarImposicionEnAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.RegistrarImposicionRetiroPorDomicilio
{
    internal class RegistrarImposicionRetiroPorDomicilioModel
    {
        // Nivel de clase (para que puedas accederlo desde cualquier método del formulario)
        public Dictionary<string, List<string>> provinciasLocalidades { get; } = new Dictionary<string, List<string>>()
        {
            { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
            { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
            { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },
            { "Mendoza", new List<string> { "Mendoza Capital", "San Rafael", "Godoy Cruz" } },
            { "Tucumán", new List<string> { "San Miguel de Tucumán", "Tafí Viejo", "Yerba Buena" } }
        };

        public int[] listaClientes = new int[] { 123456789, 99999999 };
        public List<Cliente> Clientes { get; } = new()
        {
            new Cliente { CUITCUIL = 2037840186},
            new Cliente { CUITCUIL = 123456789 }
        };

        internal void ValidarCliente(ValidarCliente validarCliente)
        {

            //if (listaClientes.Contains(validarCliente.CUITCUIL))
            //{
            //    MessageBox.Show("Cliente valido - puede continuar con la operacion");
            //    return;
            //}

            //else
            //{
            //    MessageBox.Show("El cliente no se encuentra registrado");
            //    return;
            //}





            //};


            //internal void ImponerEncomienda(EncomiendasImpuestas nuevaEncomienda)
            // {
            /*Sigue validando*/
            //DNI unico en los almacenes?


            /*Y finalmente realiza la operacion.*/
            /*Por ejemplo, lo graba en un almacen.*/

        }
}

