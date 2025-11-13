using GrupoC_TP3.Almacenes;

namespace GrupoC_TP3.CU5_GestionCD
{
    internal class GestionCentroDeDistribucionModel
    {
        public int CodigoCDActual => CentroDistribucionAlmacen.centroDistribucionActual?.CodCentroDist ?? 0;

        public List<EncomiendasEnTransporte>? paquetesRecibidos { get; private set; }

        public List<EncomiendasEnTransporte>? paquetesParaEntregar { get; private set; }

        internal void ValidacionPatente(EncomiendasEnTransporte encomiendasEnTransporte)
        {
            //Marco el codigo del CD actual
            int CodigoCDActual = CentroDistribucionAlmacen.centroDistribucionActual.CodCentroDist;

            //Busco cada campo de requerido para llenar las listas

            var patente = encomiendasEnTransporte.Patente?.ToUpperInvariant();

            // Buscar la empresa asociada a la patente
            var empresa = EmpresaOmnibusAlmacen.empresasOmnibus
                .FirstOrDefault(e => e.Unidades.Any(u => u.PatenteMicro.ToUpperInvariant() == patente));

            //var empresa = EmpresaOmnibusAlmacen.empresasOmnibus
            //                                  .Where(e => e.Unidades.Any(u => u.PatenteMicro == encomiendasEnTransporte.Patente));


            if (empresa == null)
            {
                MessageBox.Show($"La patente {patente} no está asociada a ninguna empresa registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar hojas de ruta del micro con esa patente
            var hojasDeRutaFiltradas = HojaRutaMicroAlmacen.hojasRutaMicros
                .Where(h => h.PatenteMicro.ToUpperInvariant() == patente)
                .ToList();

            if (!hojasDeRutaFiltradas.Any())
            {
                MessageBox.Show($"No se encontraron hojas de ruta asociadas a la patente {patente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Función local para obtener paquetes según su estado


            paquetesRecibidos = hojasDeRutaFiltradas
                                    .Where(h => h.CentroDistribucionDestino == CodigoCDActual)
                                    .SelectMany(h => h.NumerosGuiaMicro
                                                            .Select(g => GuiaAlmacen.guias.First(ga => ga.NumeroGuia == g.NumeroGuia))
                                                            .Select(ga => new EncomiendasEnTransporte
                                                            {
                                                                Patente = patente,
                                                                Empresa = empresa.EmpresaOmnibus,
                                                                HojaDeRuta = h.HojaRutaMicro.ToString(),
                                                                NroGuia = ga.NumeroGuia,
                                                                Estado = "En transpote a CD"
                                                            }))
                                    .ToList();

            paquetesParaEntregar = hojasDeRutaFiltradas
                                        .Where(h => h.EstadoHojaRutaMicro == EstadoHojaRutaMicro.ListoParaDespacharEnCentroDeDistribucion)
                                        .Where(h => h.CentroDistribucionOrigen == CodigoCDActual)
                                        .SelectMany(h => h.NumerosGuiaMicro.Select(g => GuiaAlmacen.guias.First(ga => ga.NumeroGuia == g.NumeroGuia))
                                                                           .Select(ga => new EncomiendasEnTransporte
                                                                           {
                                                                               Patente = patente,
                                                                               Empresa = empresa.EmpresaOmnibus,
                                                                               HojaDeRuta = h.HojaRutaMicro.ToString(),
                                                                               NroGuia = ga.NumeroGuia,
                                                                               Estado = "Listo para descpachar en CD"
                                                                           }))
                                        .ToList();

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


                guia.EstadoEncomienda = (EstadoEncomienda)5;
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    EstadoGuiaEnum = (EstadoEncomienda)5,
                    Fecha = DateTime.Now,
                    Descripcion = "Recibido En Centro Distribucion Destino"                   
                });
                //Pasa del estado EnCaminoACentroDeDistribucionDestino a RecibidoEnCentroDeDistribucionDestino
                hojaRuta.EstadoHojaRutaMicro = (EstadoHojaRutaMicro)2;



                //MessageBox.Show(guia.EstadoEncomienda.ToString() + "\n" + guia.HistorialEstadosGuia + "\n" + hojaRuta.EstadoHojaRutaMicro);

            }

            GuiaAlmacen.GuardarGuia();
            HojaRutaMicroAlmacen.GuardarHojaDeRutaMicro();

            foreach (var paquete in paquetesParaEntregar)
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

                guia.EstadoEncomienda = (EstadoEncomienda)4;
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    EstadoGuiaEnum = (EstadoEncomienda)4,
                    Fecha = DateTime.Now,
                    Descripcion = "En Transporte Entre Centro De Distribucion."

                });

                //Pasa del estado ListoParaDespacharEnCentroDeDistribucion a EnCaminoACentroDeDistribucionDestino

                hojaRuta.EstadoHojaRutaMicro = (EstadoHojaRutaMicro)1;

                GuiaAlmacen.GuardarGuia();
                HojaRutaMicroAlmacen.GuardarHojaDeRutaMicro();

                

                //MessageBox.Show(guia.EstadoEncomienda.ToString()+ "\n"+ guia.HistorialEstadosGuia + "\n" + hojaRuta.EstadoHojaRutaMicro);


                ;


                /* ESTE CONDICIONAL SIRVE PARA VALIDAR CP CD vs CP Destino de Guia y seleccionar el estado correcto en caso de multiples CDs
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
                 }*/
            }





            //CODIGO ANTERIOR DE ANDRES
            //recibir todos los "paquetes recibidos"
            //foreach (var paquete in paquetesRecibidos)
            //{
            //    var nroGuia = paquete.NroGuia;
            //    var guia = GuiaAlmacen.guias.Single(g => g.NumeroGuia == nroGuia);
            //    guia.EstadoEncomienda = EstadoEncomienda.EntregadoEnCentroDeDistribucion;
            //    
            //Verificar si el historial se graba antes o despues.
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

            //Verificar si el historial se graba antes o despues.    
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

