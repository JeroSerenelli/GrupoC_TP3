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

        public long[] listaClientes = new long[] { 123456789, 99999999 };
        public List<Cliente> Clientes { get; } = new()
        {
            new Cliente { CUITCUIL = 2037840186},
            new Cliente { CUITCUIL = 123456789 },
            new Cliente { CUITCUIL = 11111111111},
            new Cliente { CUITCUIL = 1111},

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


        }

        internal void CrearEncomienda(Encomienda encomiendas, int cantCajas)
        {
            //A este metodo le tenemos que pasar la cantidad de cajas para uqe genere una guía por caja.
            //encomiendas.NumeroGuia = encomiendas.NumeroGuia;

            int contador = 100;
            List<int> nroGuias = new List<int>();

            for (int i = 0; i < cantCajas; i++)
            {
                nroGuias.Add(contador);
                contador += 1;
            }
            
            MessageBox.Show("Encomienda creada con exito - numero de guia " + String.Join(", ", nroGuias));

            
        }
    }
}

