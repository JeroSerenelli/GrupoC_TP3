using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    internal class RegistrarImposicionEnAgenciaModel
    {
        private long[] listaClientes = new long[] { 12345678910, 99999999999 };
        public List<Cliente> Clientes { get; } = new()
    {
        new Cliente { CUITCUIL = 20378401861},
        new Cliente { CUITCUIL = 7312345653 }
    };

        internal void ValidarCliente(ValidarCliente validarCliente)
        {

            if (!listaClientes.Contains(validarCliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                MessageBox.Show("Cliente valido - puede continuar con la operacion", "Cliente valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        
        internal void CrearEncomienda(Encomienda encomiendas)
        {
            //A este metodo le tenemos que pasar la cantidad de cajas para uqe genere una guía por caja.
            encomiendas.NumeroGuia = encomiendas.NumeroGuia;

            int contador = 1000;

            MessageBox.Show("Encomienda creada con exito - numero de guia " + encomiendas.NumeroGuia.ToString() + contador.ToString());

            contador += 1;
        }

        
    }

    
}
