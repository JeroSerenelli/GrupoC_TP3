using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU6_EntregaEncomiendas;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GrupoC_TP3.CU6_EntregaEncomiendas.Encomienda;

namespace GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia
{
    internal class EntregaEncomiendasModel
    {
        public List<Encomienda> Encomiendas { get; } = new List<Encomienda>()
        {
            new Encomienda { Dni = 11111111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234" , Estado = "Listo para Entregar" },
            new Encomienda { Dni = 11111111, Nombre = "Juan", Apellido = "Perez", NroGuia = "1234", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 22222222, Nombre = "Maria", Apellido = "Gomez", NroGuia = "1235", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 33333333, Nombre = "Carlos", Apellido = "Lopez", NroGuia = "1236", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 44444444, Nombre = "Ana", Apellido = "Martinez", NroGuia = "1237", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 44444444, Nombre = "Luis", Apellido = "Fernandez", NroGuia = "1238", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 33333333, Nombre = "Carlos", Apellido = "Lopez", NroGuia = "1239", Estado = "Listo para Entregar" },
            new Encomienda { Dni = 39465514, Nombre = "Jeronimo", Apellido = "Sere", NroGuia = "1240", Estado = "Listo para Entregar" }


        };

        internal void ValidacionCliente(Encomienda cliente)
        {
            //SEA POSITIVO 
            if (cliente.Dni <= 0) //Lvl 2
            {
                MessageBox.Show("El campo DNI debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SEA DE 8 DIGITOS
            if (cliente.Dni.ToString().Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }

            bool existe = Encomiendas.Any(g => g.Dni == cliente.Dni);

            if (!existe)
            {
                MessageBox.Show("El cliente ingresado no tiene paquetes para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;


            
        }
       
    }


}


