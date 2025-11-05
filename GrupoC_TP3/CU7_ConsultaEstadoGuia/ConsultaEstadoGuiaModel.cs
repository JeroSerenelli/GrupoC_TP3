using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU1_RegistrarImposicionRetiroPorDomicilio;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrupoC_TP3.CU7_ConsultaEstadoGuia
{
    public class EstadoGuiaDTO
    {
        public string EstadoEncomienda { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public EstadoGuiaDTO(string estado, DateTime fecha)
        {
            EstadoEncomienda = estado;
            FechaActualizacion = fecha;
        }
    }
    internal class ConsultaEstadoGuiaModel
    {

        public List<Guia> Guias { get; set; } = new()
        {
            new Guia { NumeroGuia = 1111, EstadoGuia = "Entregado", UltActualizacion = "2025-10-08" },
            new Guia { NumeroGuia = 1111, EstadoGuia = "En camino a CD", UltActualizacion = "2025-10-07" },
            new Guia { NumeroGuia = 4444, EstadoGuia = "En Agencia", UltActualizacion = "2023-10-08" },
        };


        internal void ValidacionGuia(Guia guias)
        {
            //SEA POSITIVO 
            if (guias.NumeroGuia <= 0) //Lvl 2
            {
                MessageBox.Show("El numero de guía debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBoxDNIDestinatario.Focus();
                return;
            }

            //Que exista el nro de guia ingresado
            bool existe = Guias.Any(g => g.NumeroGuia == guias.NumeroGuia);

            if (existe == false)
            {
                MessageBox.Show("El numero de guia ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public List<EstadoGuiaDTO> ObtenerHistorialPorNumero(long numeroGuia)
        {
            if (numeroGuia <= 0)
                throw new ArgumentException("El número de guía debe ser positivo.");

            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == (int)numeroGuia);
            if (guia == null)
                throw new KeyNotFoundException("El número de guía ingresado no existe.");

            var historial = guia.HistorialEstadosGuia
                .OrderByDescending(h => h.Fecha)
                .Select(h => new EstadoGuiaDTO(h.EstadoGuiaEnum.ToString(), h.Fecha))
                .ToList();

            return historial;
        }


    }
}

