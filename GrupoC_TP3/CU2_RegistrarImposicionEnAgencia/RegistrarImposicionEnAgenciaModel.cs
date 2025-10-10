using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU2_RegistrarImposicionEnAgencia
{
    internal class RegistrarImposicionEnAgenciaModel
    {
        private long[] listaClientes = new long[] { 12345678910, 99999999 };
        /*public List<Cliente> Clientes { get; } = new()
    {
        new Cliente { CUITCUIL = 20378401861},
        new Cliente { CUITCUIL = 7312345653 }
    };*/

        internal void ValidarCliente(ValidarCliente validarCliente)
        {
            if (validarCliente.CUITCUIL <= 0) //Lvl 2
            {
                MessageBox.Show("El campo CUIT/CUIL debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
     
            if (validarCliente.CUITCUIL.ToString().Length != 11)
            {
                MessageBox.Show("El campo CUIT/CUIL debe tener 11 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            if (!listaClientes.Contains(validarCliente.CUITCUIL))
            {
                MessageBox.Show("El cliente no se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Cliente valido", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (encomiendas.DNI < 100000 || encomiendas.DNI > 99999999)
            {
                MessageBox.Show("El DNI del destinatario ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encomiendas.CodigoPostal < 1000)
            {
                MessageBox.Show("El Codigo Postal ingresado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //int contador = 1;

            int contador = 1000;
            /*List<int> nroGuias = new List<int>();

            for (int i = 0; i < encomiendas.CantidadCajas; i++)
            {
                nroGuias.Add(contador);
                contador += 1;
            }

            MessageBox.Show("Encomienda creada con exito - numero de guia " + String.Join(", ", encomiendas.NumeroGuia.ToString() + nroGuias));*/

            MessageBox.Show("Encomienda creada con exito - numero de guia " + encomiendas.NumeroGuia.ToString() + contador.ToString());

            contador += 1;
        }

        
    }

    
}
