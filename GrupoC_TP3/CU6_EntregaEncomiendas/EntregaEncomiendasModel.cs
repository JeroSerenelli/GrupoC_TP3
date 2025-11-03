using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU6_EntregaEncomiendas;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static GrupoC_TP3.CU6_EntregaEncomiendas.Encomienda;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GrupoC_TP3.Entrega_de_Encomiendas_en_Agencia
{
    internal class EntregaEncomiendasModel
    {

        // LISTA ESTATICA DE ENCOMIENDAS PARA PRUEBAS, LA COMENTO PARA REMPLAZARLA CON UNA LISTA DINAMICA
        /*
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
        */
        

        public List<Encomienda> Encomiendas { get; set; } = new List<Encomienda> ();

        internal void ConsultaDNI(Encomienda cliente)
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

            // BUSQUEDA EN LISTA ESTATICA, COMENTO PARA REMPLAZARLA POR BUSQUEDA EN JSON
            /*
            bool existe = Encomiendas.Any(g => g.Dni == cliente.Dni);

            if (!existe)
            {
                MessageBox.Show("El DNI ingresado no tiene paquetes para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;
            */
            

            // Buscar en el JSON las guías con ese DNI y estado "ListoParaRetiroEnAgencia". Compara el DNI recibido del FORM con el DNI de las guías en el almacen JSON y a su vez que tenga el estado de lista para retirar en agencia
            var guiasCliente = GuiaAlmacen.guias
                .Where(g => g.DNIDestinatario == cliente.Dni
                         && g.EstadoEncomienda == EstadoEncomienda.ListoParaRetiroEnAgencia)
                .ToList();

            // Error de si no hay guías que concuerden
            if (guiasCliente.Count == 0)
            {
                MessageBox.Show("El DNI ingresado no tiene paquetes para retirar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mapear a la clase Encomienda (la que usa el form). Asigna las variables necesarias para mostrar en el form
            Encomiendas = guiasCliente.Select(g => new Encomienda
            {
                Dni = g.DNIDestinatario,
                Nombre = g.NombreDestinatario,
                Apellido = g.ApellidoDestinatario,
                NroGuia = g.NumeroGuia.ToString(),
                Estado = "Listo para Retiro en Agencia"
            }).ToList();

        }

        // --- CONFIRMAR ENTREGA ---
        // Recibe una lista de números de guía a confirmar como entregadas
        internal void ConfirmarEntrega(IEnumerable<int> numerosGuia)
        {
            // Usar un HashSet para búsqueda rápida. Si la lista es vacía, retornar directamente y saltea el resto del metodo
            var set = new HashSet<int>(numerosGuia);
            if (set.Count == 0) return;

            // Obtener la hora actual para el historial
            var HoraActual = DateTime.Now;

            // Recorrer las guías en el almacen JSON que coincidan con los números de guía recibidos
            foreach (var g in GuiaAlmacen.guias.Where(x => set.Contains(x.NumeroGuia)))
            {
                // Cambiar el estado de la guía
                g.EstadoEncomienda = EstadoEncomienda.Entregado;

                // Registrar en el historial
                g.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    EstadoGuiaEnum = EstadoEncomienda.Entregado,
                    Fecha = HoraActual,
                    Descripcion = "Entrega confirmada en agencia"
                });
            }

            // Guardar cambios en el JSON
            // ESTO LUEGO HAY QUE PASARLO AL CODIGO DEL PROGRAM Y QUE LO GUARDE CUANDO SE CIERRE LA APLICACION. AHORA LO HICE ASI PARA PROBARLO SIN NECESIDAD DE QUE ESTE HECHO EL CU1, CU2, CU3 QUE GENERAN LAS GUIAS.
            GuiaAlmacen.GuardarGuia();

            // Quitar de la lista local las entregadas (para refrescar UI)
            Encomiendas.RemoveAll(e =>
            {
                if (int.TryParse(e.NroGuia, out var n))
                    return set.Contains(n);
                return false;
            });
        }




    }


}


