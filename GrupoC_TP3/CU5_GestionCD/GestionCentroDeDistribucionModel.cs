using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoC_TP3.CU5_GestionCD
{
    internal class GestionCentroDeDistribucionModel
    {



        public List<EncomiendasEnTransporte> paquetesRecibidos { get; } = new List<EncomiendasEnTransporte>()
        {
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR001", NroGuia = 1001, Estado = "En camino al CD" },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche",HojaDeRuta = "HDR002", NroGuia = 1002, Estado = "En camino al CD" },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR003", NroGuia = 1003, Estado = "En camino al CD" },
            new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "Plusmar", HojaDeRuta = "HDR004", NroGuia = 1004, Estado = "En camino al CD" }, // No se muestra si filtrás por ABC123
        };


        public List<EncomiendasEnTransporte> paquetesParaEntregar { get; } = new List<EncomiendasEnTransporte>()
        {
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR010", NroGuia = 2001, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR011", NroGuia = 2002, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR012", NroGuia = 2003, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "ViaBariloche", HojaDeRuta = "HDR013", NroGuia = 2004, Estado = "En CD. Listo para despachar." }, // No se muestra si filtrás por ABC123
        };


        internal void ValidacionPatente(EncomiendasEnTransporte encomiendasEnTransporte)
        {
            bool recibir = paquetesRecibidos.Any(g => g.Patente == encomiendasEnTransporte.Patente.ToUpper());

            if (!recibir)
            {
                MessageBox.Show($"No hay encomiendas para recibir del vehiculo {encomiendasEnTransporte}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool entregar = paquetesParaEntregar.Any(e => e.Patente == encomiendasEnTransporte.Patente.ToUpper());
            if (!entregar)
            {
                MessageBox.Show($"No hay encomiendas para entregar al vehiculo {encomiendasEnTransporte}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;
        }

    };

    
}

