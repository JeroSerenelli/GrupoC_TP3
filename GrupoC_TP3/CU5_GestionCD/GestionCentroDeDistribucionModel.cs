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


        public List<EncomiendasEnTransporte>? paquetesRecibidos { get; private set; }

        /*= new List<EncomiendasEnTransporte>()
    {
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR001", NroGuia = 1001, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche",HojaDeRuta = "HDR002", NroGuia = 1002, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "ViaBariloche", HojaDeRuta = "HDR003", NroGuia = 1003, Estado = "En camino al CD" },
        new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "Plusmar", HojaDeRuta = "HDR004", NroGuia = 1004, Estado = "En camino al CD" }, // No se muestra si filtrás por ABC123
    };*/


        public List<EncomiendasEnTransporte>? paquetesParaEntregar { get; private set; } /*= new List<EncomiendasEnTransporte>()
        {
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR010", NroGuia = 2001, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR011", NroGuia = 2002, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR012", NroGuia = 2003, Estado = "En CD. Listo para despachar." },
            new EncomiendasEnTransporte { Patente = "XYZ789", Empresa = "ViaBariloche", HojaDeRuta = "HDR013", NroGuia = 2004, Estado = "En CD. Listo para despachar." }, // No se muestra si filtrás por ABC123
        };*/

        internal void ValidacionPatente(EncomiendasEnTransporte encomiendasEnTransporte)
        {


            //{ Patente = "ABC123", Empresa = "El Rapido", HojaDeRuta = "HDR010", NroGuia = 2001, Estado = "En CD. Listo para despachar." }

            //Busco cada campo de requerido para llenar las listas

            var patente = encomiendasEnTransporte.Patente?.ToUpperInvariant();

            // Buscar la empresa asociada a la patente
            var empresa = EmpresaOmnibusAlmacen.empresasOmnibus
                .FirstOrDefault(e => e.Unidades.Any(u => u.PatenteMicro.ToUpperInvariant() == patente));
            //var empresa = EmpresaOmnibusAlmacen.empresasOmnibus
            //                                  .Where(e => e.Unidades.Any(u => u.PatenteMicro == encomiendasEnTransporte.Patente))
                                              ;


            if (empresa == null)
            {
                MessageBox.Show($"La patente {patente} no está asociada a ninguna empresa registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar hojas de ruta del micro con esa patente
            var hojasDeRuta = HojaRutaMicroAlmacen.hojasRutaMicros
                .Where(h => h.PatenteMicro.ToUpperInvariant() == patente)
                .ToList();

            if (!hojasDeRuta.Any())
            {
                MessageBox.Show($"No se encontraron hojas de ruta asociadas a la patente {patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Función local para obtener paquetes según su estado



            List<EncomiendasEnTransporte> ObtenerPaquetesPorEstado(EstadoEncomienda estado, string estadoTexto)
            {
                return hojasDeRuta
                    .SelectMany(h => h.NumerosGuiaMicro
                        .Select(g => GuiaAlmacen.guias
                            .FirstOrDefault(ga => ga.NumeroGuia == g.NumeroGuia))
                        .Where(ga => ga != null && ga.EstadoEncomienda == estado)
                        .Select(ga => new EncomiendasEnTransporte
                        {
                            Patente = patente,
                            Empresa = empresa.EmpresaOmnibus,
                            HojaDeRuta = h.HojaRutaMicro.ToString(),
                            NroGuia = ga.NumeroGuia,
                            Estado = estadoTexto
                        })
                    )
                    .ToList();
            }

            // Construir las dos listas

            paquetesRecibidos = ObtenerPaquetesPorEstado(
            EstadoEncomienda.EnTransporteEntreCentroDeDistribucion,
            "En camino al CD"
            );

            paquetesParaEntregar = ObtenerPaquetesPorEstado(
            EstadoEncomienda.EntregadoEnCentroDeDistribucion,
            "Entregado en CD"
            );



            if (!paquetesRecibidos.Any())
            {
                MessageBox.Show($"No hay encomiendas para recibir del vehículo {patente}.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!paquetesParaEntregar.Any())
            {
                MessageBox.Show($"No hay encomiendas para entregar al vehículo {patente}.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // COdigo Andres

            // ahora valido si hay encomiendas para recibir o entregar

            /*
            if (!paquetesRecibidos.Any())
            {
                MessageBox.Show($"No hay encomiendas para recibir del vehiculo {encomiendasEnTransporte.Patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!paquetesParaEntregar.Any())
            {
                MessageBox.Show($"No hay encomiendas para entregar al vehiculo {encomiendasEnTransporte.Patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

            if (!paquetesRecibidos.Any())
            {
                MessageBox.Show($"No hay encomiendas para recibir del vehículo {patente}.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!paquetesParaEntregar.Any())
            {
                MessageBox.Show($"No hay encomiendas para entregar al vehículo {patente}.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            */

            return;
        }


        internal void Actualizar()
        {
            foreach (var paquete in paquetesRecibidos)
            {
                var guia = GuiaAlmacen.guias.SingleOrDefault(g => g.NumeroGuia == paquete.NroGuia);
                if (guia == null) continue;//Si no se encontró la guía en el almacén, paso al siguiente paquete


                var hojaRuta = HojaRutaMicroAlmacen.hojasRutaMicros
                    .FirstOrDefault(h => h.HojaRutaMicro.ToString() == paquete.HojaDeRuta);
                if (hojaRuta == null) continue; //Si no encuentro la hoja de ruta correspondiente, salto este paquete


                var centroDestino = CentroDistribucionAlmacen.centrosDistribucion
                    .FirstOrDefault(cd => cd.CodCentroDist == hojaRuta.CentroDistribucionDestino);
                
                if (centroDestino == null)  //Si la hoja de ruta apunta a un centro de distribución que no existe, también lo salto
                {
                    MessageBox.Show($"No se encontró el centro de distribución destino (Código: {hojaRuta.CentroDistribucionDestino}) " +
                                    $"para la hoja de ruta {hojaRuta.HojaRutaMicro}.",
                        "Advertencia - Centro de distribución no encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                int codigoPostalCDActual = centroDestino.CodPostal;

                if (codigoPostalCDActual == guia.CodPostalDest)
                {
                    guia.EstadoEncomienda = EstadoEncomienda.RecibidoEnCentroDistribucionDestino;
                    guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                    {
                        EstadoGuiaEnum = EstadoEncomienda.RecibidoEnCentroDistribucionDestino,
                        Fecha = DateTime.Now,
                        Descripcion = $"Recibido en centro de distribución destino (CD {centroDestino.Nombre})."
                    });
                }
                else
                {
                    guia.EstadoEncomienda = EstadoEncomienda.EntregadoEnCentroDeDistribucion;
                    guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                    {
                        EstadoGuiaEnum = EstadoEncomienda.EntregadoEnCentroDeDistribucion,
                        Fecha = DateTime.Now,
                        Descripcion = $"Recibido en centro de distribución intermedio (CD {centroDestino.Nombre})."
                    });
                }
            }



            //CODIGO ANTERIOR DE ANDRES
            //recibir todos los "paquetes recibidos"
            //foreach (var paquete in paquetesRecibidos)
            //{
            //    var nroGuia = paquete.NroGuia;
            //    var guia = GuiaAlmacen.guias.Single(g => g.NumeroGuia == nroGuia);
            //    guia.EstadoEncomienda = EstadoEncomienda.EntregadoEnCentroDeDistribucion;
            //    //TODO: verificar si el historial se graba antes o despues.
            //    guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
            //    {
            //        Descripcion = "En camino a domicilio o agencia.",
            //        Fecha = DateTime.Now,
            //        EstadoGuiaEnum = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion
            //    });
            //}


            //foreach (var paquete in paquetesParaEntregar)
            //{
            //    var nroGuia = paquete.NroGuia;
            //    var guia = GuiaAlmacen.guias.Single(g => g.NumeroGuia == nroGuia);
            //    guia.EstadoEncomienda = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion;
            //    //TODO: verificar si el historial se graba antes o despues.
            //    guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
            //    {
            //        Descripcion = "En transporte entre centros de distribucion",
            //        Fecha = DateTime.Now,
            //        EstadoGuiaEnum = EstadoEncomienda.EnTransporteEntreCentroDeDistribucion
            //    });
            //}


            //... y eso es todo amigos?
        }

    };


}

