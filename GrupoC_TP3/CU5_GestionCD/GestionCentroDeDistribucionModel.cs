using GrupoC_TP3.Almacenes;
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


        public List<EncomiendasEnTransporte> paquetesRecibidos { get; private set; }

        /*= new List<EncomiendasEnTransporte>()
    {
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR001", NroGuia = 1001, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche",HojaDeRuta = "HDR002", NroGuia = 1002, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR003", NroGuia = 1003, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "Plusmar", HojaDeRuta = "HDR004", NroGuia = 1004, Estado = "En camino al CD" }, // No se muestra si filtrás por ABC123
    };*/


        public List<EncomiendasEnTransporte> paquetesParaEntregar { get; private set; } /*= new List<EncomiendasEnTransporte>()
        {
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR010", NroGuia = 2001, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR011", NroGuia = 2002, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR012", NroGuia = 2003, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "ViaBariloche", HojaDeRuta = "HDR013", NroGuia = 2004, Estado = "En CD. Listo para despachar." }, // No se muestra si filtrás por ABC123
        };*/

        internal void ValidacionPatente(EncomiendasEnTransporte encomiendasEnTransporte)
        {
            bool recibir = paquetesRecibidos.Any(g => g.Patente == encomiendasEnTransporte.Patente.ToUpper());

            if (!recibir)
            {
                MessageBox.Show($"No hay encomiendas para recibir del vehiculo {encomiendasEnTransporte.Patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool entregar = paquetesParaEntregar.Any(e => e.Patente == encomiendasEnTransporte.Patente.ToUpper());
            if (!entregar)
            {
                MessageBox.Show($"No hay encomiendas para entregar al vehiculo {encomiendasEnTransporte.Patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //TODO: con los datos que me vienen en encomiendasEnTranspore tengo que llenar las listas paquetesRecibidos y paquetesParaEntregar            

            /*            
                        EmpresaOmnibusEntidad empresaEntidad = null;
                        foreach (var empresa in EmpresaOmnibusAlmacen.empresasOmnibus)
                        {
                            foreach (var unidad in empresa.Unidades)
                            {
                                if (unidad.PatenteMicro == encomiendasEnTransporte.Patente)
                                {
                                    empresaEntidad = empresa;
                                }
                            }
                        }
            */
            //Acá empresaEntidad tiene la empresa que corresponde a la patente


            //{ Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR010", NroGuia = 2001, Estado = "En CD. Listo para despachar." }

            var empresa = EmpresaOmnibusAlmacen.empresasOmnibus
                                               .Where(e => e.Unidades.Any(u => u.PatenteMicro == encomiendasEnTransporte.Patente))
                                               .Single();

            var hojaDeRutaDeMicro = HojaRutaMicroAlmacen.hojasRutaMicros
                                                .Where(p => p.PatenteMicro == encomiendasEnTransporte.Patente)
                                                .ToList();

            paquetesRecibidos = hojaDeRutaDeMicro.Select(h => new
            {
                h.HojaRutaMicro,
                Guias = h.NumerosGuiaMicro
                            .Select(g => GuiaAlmacen.guias.Single(ga => ga.NumeroGuia == g.NumeroGuia))
                            .Where(g => g.EstadoEncomienda == EstadoEncomienda.EnTransporteEntreCentroDeDistribucion)
                            .ToList()
            })
            .Where(h => h.Guias.Any()) //las que tengan alguna guia a recibir.
            .SelectMany(h => h.Guias.Select(hg => new { h.HojaRutaMicro, hg.NumeroGuia, hg.EstadoEncomienda }))
            .Select(h => new EncomiendasEnTransporte
            {
                Patente = encomiendasEnTransporte.Patente,
                Empresa = empresa.EmpresaOmnibus,
                HojaDeRuta = h.HojaRutaMicro.ToString(),
                NroGuia = h.NumeroGuia,
                Estado = "En camino al CD"
            }).ToList();



            paquetesParaEntregar = hojaDeRutaDeMicro.Select(h => new
            {
                h.HojaRutaMicro,
                Guias = h.NumerosGuiaMicro
                            .Select(g => GuiaAlmacen.guias.Single(ga => ga.NumeroGuia == g.NumeroGuia))
                            .Where(g => g.EstadoEncomienda == EstadoEncomienda.EntregadoEnCentroDeDistribucion)
                            .ToList()
            })
            .Where(h => h.Guias.Any()) //las que tengan alguna guia a recibir.
            .SelectMany(h => h.Guias.Select(hg => new { h.HojaRutaMicro, hg.NumeroGuia, hg.EstadoEncomienda }))
            .Select(h => new EncomiendasEnTransporte
            {
                Patente = encomiendasEnTransporte.Patente,
                Empresa = empresa.EmpresaOmnibus,
                HojaDeRuta = h.HojaRutaMicro.ToString(),
                NroGuia = h.NumeroGuia,
                Estado = "En camino al CD"
            }).ToList();




            return;
        }


        internal void Actualizar()
        {
            //recibir todos los "paquetes recibidos"
            foreach (var paquete in paquetesRecibidos)
            {
                var nroGuia = paquete.NroGuia;
                var guia = GuiaAlmacen.guias.Single(g => g.NumeroGuia == nroGuia);
                guia.EstadoEncomienda = EstadoEncomienda.EntregadoEnCentroDeDistribucion;
                //TODO: verificar si el historial se graba antes o despues.
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    Descripcion = "En camino a domicilio o agencia.",
                    Fecha = DateTime.Now,
                    EstadoGuiaEnum = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion
                });
            }


            foreach (var paquete in paquetesParaEntregar)
            {
                var nroGuia = paquete.NroGuia;
                var guia = GuiaAlmacen.guias.Single(g => g.NumeroGuia == nroGuia);
                guia.EstadoEncomienda = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion;
                //TODO: verificar si el historial se graba antes o despues.
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    Descripcion = "En transporte entre centros de distribucion",
                    Fecha = DateTime.Now,
                    EstadoGuiaEnum = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion
                });
            }


            //... y eso es todo amigos?
        }

    };


}

