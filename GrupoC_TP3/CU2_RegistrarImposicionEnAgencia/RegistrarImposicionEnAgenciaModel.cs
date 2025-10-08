using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    internal class RegistrarImposicionEnAgenciaModel
    {
        private long[] listaClientes = new long[] { 123456789, 99999999 };
        public List<Cliente> Clientes { get; } = new()
    {
        new Cliente { CUITCUIL = 20378401861},
        new Cliente { CUITCUIL = 7312345653 }
    };

        internal void ValidarCliente(ValidarCliente validarCliente)
        {

            if (!listaClientes.Contains(validarCliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado");
                return;
            }

            else
            {
                MessageBox.Show("Cliente valido - puede continuar con la operacion");
                return;
            }

            /*foreach(long Cliente in Clientes)
            {
                if (Cliente != validarCliente.CUITCUIL)
                {
                    MessageBox.Show("El cliente no se encuentra registrado");
                }
            }*/



            /*if (Clientes. != cliente.CUITCUIL);
            {
                MessageBox.Show("El cliente ingresado no existe");
                return;
            }*/
        }

        public Dictionary<string, List<string>> provinciasLocalidades { get; } = new Dictionary<string, List<string>>()
        {
            { "Buenos Aires", new List<string> { "La Plata", "Mar del Plata", "Bahía Blanca" } },
            { "Córdoba", new List<string> { "Córdoba Capital", "Villa María", "Río Cuarto" } },
            { "Santa Fe", new List<string> { "Rosario", "Santa Fe Capital", "Rafaela" } },
            { "Mendoza", new List<string> { "Mendoza Capital", "San Rafael", "Godoy Cruz" } },
            { "Tucumán", new List<string> { "San Miguel de Tucumán", "Tafí Viejo", "Yerba Buena" } }
        };


        internal void CrearEncomienda(Encomienda encomiendas)
        {
            encomiendas.NumeroGuia = encomiendas.NumeroGuia;

            MessageBox.Show("Encomienda creada con exito - numero de guia " + encomiendas.NumeroGuia.ToString() + "9999");
        }

        
    }

    
}
