using GrupoC_TP3.Almacenes;
using GrupoC_TP3.CU7_ConsultaEstadoGuia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GrupoC_TP3.CU4_RecepcionFletero
{
    public class RecepcionFleterosModel
    {
        // Dictionary ahora usa DNI (int) como clave en lugar de nombre (string)
        public List<HojasDeRutaAsignadas> Fleteros { get; } = new();
        public Dictionary<int, List<HojasDeRutaPorAsignar>> PorAsignarPorFletero { get; } = new();

        public RecepcionFleterosModel()
        {
            Refresh();
        }

        public void Refresh()
        {
            RefreshFleterosDesdeAlmacen();
            RefreshPorAsignarDesdeAlmacen();
        }

        private void RefreshFleterosDesdeAlmacen()
        {
            Fleteros.Clear();

            var hojas = HojaRutaFleteAlmacen.hojasRutaFletes ?? new List<HojaRutaFleteEntidad>();
            var guias = GuiaAlmacen.guias ?? new List<GuiaEntidad>();

            foreach (var hdr in hojas.Where(h => h.EstadoHojaRutaFlete == EstadoHojaRutaFlete.NoCumplida))
            {
                string estadoStr = hdr.EstadoHojaRutaFlete == EstadoHojaRutaFlete.Cumplida ? "Cumplida" : "No Cumplida";

                foreach (var num in hdr.NumerosGuiaFlete)
                {
                    var guia = guias.FirstOrDefault(g => g.NumeroGuia == num.NumeroGuia);
                    if (guia == null) continue;

                    Fleteros.Add(new HojasDeRutaAsignadas
                    {
                        DNIFletero = hdr.DNIFletero,  // Ahora guardamos DNI
                        HojaDeRuta = hdr.HojaRutaFlete.ToString(),
                        NroGuia = num.NumeroGuia.ToString(),
                        Estado = estadoStr
                    });
                }
            }
        }

        private void RefreshPorAsignarDesdeAlmacen()
        {
            PorAsignarPorFletero.Clear();

            var hojas = HojaRutaFleteAlmacen.hojasRutaFletes ?? new List<HojaRutaFleteEntidad>();
            var guias = GuiaAlmacen.guias ?? new List<GuiaEntidad>();
            var fleterosAlmacen = FleteroAlmacen.fleteros ?? new List<FleteroEntidad>();

            foreach (var hdr in hojas.Where(h => h.EstadoHojaRutaFlete == EstadoHojaRutaFlete.PendienteAsignacion))
            {
                var candidatosDNI = fleterosAlmacen
                    .Where(f => f.CodPostalActividad == hdr.CodPostal)
                    .Select(f => f.DNIFletero)
                    .Distinct()
                    .ToList();

                if (!candidatosDNI.Any()) continue;

                foreach (var dni in candidatosDNI)
                {
                    if (!PorAsignarPorFletero.TryGetValue(dni, out var list))
                    {
                        list = new List<HojasDeRutaPorAsignar>();
                        PorAsignarPorFletero[dni] = list;
                    }

                    foreach (var num in hdr.NumerosGuiaFlete)
                    {
                        var guia = guias.FirstOrDefault(g => g.NumeroGuia == num.NumeroGuia);
                        if (guia == null) continue;

                        list.Add(new HojasDeRutaPorAsignar
                        {
                            DNIFletero = dni,
                            HojaDeRuta = hdr.HojaRutaFlete.ToString(),
                            NroGuia = num.NumeroGuia.ToString()
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Devuelve TODOS los fleteros (entidades completas) para poblar el combo
        /// </summary>
        internal List<FleteroEntidad> ObtenerTodosLosFleteros()
        {
            return FleteroAlmacen.fleteros
                .DistinctBy(f => f.DNIFletero)        //Filtrar duplicados por DNI
                .OrderBy(f => f.NombreFletero)
                .ThenBy(f => f.ApellidoFletero)
                .ToList();
        }

        /// <summary>
        /// Botón "IMPRIMIR DETALLE"
        /// Actualiza HDR -> Cumplida y TODAS las guías de esa HDR -> Entregado
        /// </summary>
        public void ImprimirDetalleHDRAsignadas(List<HojasDeRutaAsignadas> hojasSeleccionadas)
        {
            if (hojasSeleccionadas == null || !hojasSeleccionadas.Any())
                throw new ArgumentException("Debe tildar al menos una Hoja de Ruta asignada");

            // Obtener IDs únicos de las HDR seleccionadas
            var hojasIds = hojasSeleccionadas
                .Select(h => h.HojaDeRuta)
                .Where(s => int.TryParse(s, out _))
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var hojasAlmacen = HojaRutaFleteAlmacen.hojasRutaFletes;
            var guiasAlmacen = GuiaAlmacen.guias;

            // Obtener TODAS las guías de las HDR seleccionadas (no solo las tildadas)
            var todasLasGuiasDeHDR = new List<int>();
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                if (hdr != null)
                {
                    todasLasGuiasDeHDR.AddRange(hdr.NumerosGuiaFlete.Select(n => n.NumeroGuia));
                }
            }

            // ========== DEBUG TEMPORAL - ANTES ==========
            System.Diagnostics.Debug.WriteLine("╔════════════════════════════════════════════╗");
            System.Diagnostics.Debug.WriteLine("║       ANTES DE ACTUALIZAR                  ║");
            System.Diagnostics.Debug.WriteLine("╚════════════════════════════════════════════╝");

            // Mostrar estado de HDR
            System.Diagnostics.Debug.WriteLine("\n--- HOJAS DE RUTA ---");
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                System.Diagnostics.Debug.WriteLine($"HDR {id}: Estado = {hdr?.EstadoHojaRutaFlete}");
                if (hdr != null)
                {
                    System.Diagnostics.Debug.WriteLine($"  Guías en esta HDR: {string.Join(", ", hdr.NumerosGuiaFlete.Select(n => n.NumeroGuia))}");
                }
            }

            // Mostrar estado de TODAS las Guías de las HDR
            System.Diagnostics.Debug.WriteLine("\n--- GUÍAS (TODAS LAS DE LAS HDR SELECCIONADAS) ---");
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null)
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: NO ENCONTRADA");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: Estado = {guia.EstadoEncomienda}");
                    System.Diagnostics.Debug.WriteLine($"  Historial ({guia.HistorialEstadosGuia.Count} entradas):");
                    foreach (var hist in guia.HistorialEstadosGuia)
                    {
                        System.Diagnostics.Debug.WriteLine($"    - {hist.Fecha:yyyy-MM-dd HH:mm:ss}: {hist.EstadoGuiaEnum} - {hist.Descripcion}");
                    }
                }
            }
            // ============================================

            // Actualizar HDR a Cumplida
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                if (hdr != null && hdr.EstadoHojaRutaFlete == EstadoHojaRutaFlete.NoCumplida)
                {
                    hdr.EstadoHojaRutaFlete = EstadoHojaRutaFlete.Cumplida;
                }
            }
            HojaRutaFleteAlmacen.GuardarHojaDeRutaFlete();

            // Actualizar TODAS las guías de las HDR seleccionadas (no solo las tildadas)
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null) continue;

                guia.EstadoEncomienda = EstadoEncomienda.Entregado;
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    EstadoGuiaEnum = EstadoEncomienda.Entregado,
                    Fecha = DateTime.Now,
                    Descripcion = "Entregado por fletero"
                });
            }
            GuiaAlmacen.GuardarGuia();

            // ========== DEBUG TEMPORAL - DESPUÉS ==========
            System.Diagnostics.Debug.WriteLine("\n╔════════════════════════════════════════════╗");
            System.Diagnostics.Debug.WriteLine("║       DESPUÉS DE ACTUALIZAR                ║");
            System.Diagnostics.Debug.WriteLine("╚════════════════════════════════════════════╝");

            // Mostrar estado de HDR
            System.Diagnostics.Debug.WriteLine("\n--- HOJAS DE RUTA ---");
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                System.Diagnostics.Debug.WriteLine($"HDR {id}: Estado = {hdr?.EstadoHojaRutaFlete}");
            }

            // Mostrar estado de TODAS las Guías
            System.Diagnostics.Debug.WriteLine("\n--- GUÍAS (TODAS LAS DE LAS HDR SELECCIONADAS) ---");
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null)
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: NO ENCONTRADA");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: Estado = {guia.EstadoEncomienda}");
                    System.Diagnostics.Debug.WriteLine($"  Historial ({guia.HistorialEstadosGuia.Count} entradas):");
                    foreach (var hist in guia.HistorialEstadosGuia)
                    {
                        System.Diagnostics.Debug.WriteLine($"    - {hist.Fecha:yyyy-MM-dd HH:mm:ss}: {hist.EstadoGuiaEnum} - {hist.Descripcion}");
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("\n════════════════════════════════════════════\n");
            // =============================================

            // refrescar listas públicas para que UI vea los cambios
            Refresh();
        }

        /// <summary>
        /// Botón "ASIGNAR"
        /// Asigna HDR pendientes al fletero y actualiza TODAS las guías de esa HDR
        /// </summary>
        public void AsignarHojasDeRutaAFletero(int dniFletero, List<HojasDeRutaPorAsignar> hojasSeleccionadas)
        {
            if (hojasSeleccionadas == null || !hojasSeleccionadas.Any())
                throw new ArgumentException("Debe seleccionar al menos una Hoja de Ruta para asignar");

            // Obtener IDs únicos de las HDR seleccionadas
            var hojasIds = hojasSeleccionadas
                .Select(h => h.HojaDeRuta)
                .Where(s => int.TryParse(s, out _))
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var hojasAlmacen = HojaRutaFleteAlmacen.hojasRutaFletes;
            var guiasAlmacen = GuiaAlmacen.guias;

            // Obtener TODAS las guías de las HDR seleccionadas (no solo las seleccionadas en el ListView)
            var todasLasGuiasDeHDR = new List<int>();
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                if (hdr != null)
                {
                    todasLasGuiasDeHDR.AddRange(hdr.NumerosGuiaFlete.Select(n => n.NumeroGuia));
                }
            }

            // ========== DEBUG TEMPORAL - ANTES ==========
            System.Diagnostics.Debug.WriteLine("╔════════════════════════════════════════════╗");
            System.Diagnostics.Debug.WriteLine("║       ANTES DE ASIGNAR                     ║");
            System.Diagnostics.Debug.WriteLine("╚════════════════════════════════════════════╝");
            System.Diagnostics.Debug.WriteLine($"DNI Fletero a asignar: {dniFletero}");

            // Mostrar estado de HDR
            System.Diagnostics.Debug.WriteLine("\n--- HOJAS DE RUTA ---");
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                System.Diagnostics.Debug.WriteLine($"HDR {id}: Estado = {hdr?.EstadoHojaRutaFlete}, DNI = {hdr?.DNIFletero}");
                if (hdr != null)
                {
                    System.Diagnostics.Debug.WriteLine($"  Guías en esta HDR: {string.Join(", ", hdr.NumerosGuiaFlete.Select(n => n.NumeroGuia))}");
                }
            }

            // Mostrar estado de TODAS las Guías de las HDR
            System.Diagnostics.Debug.WriteLine("\n--- GUÍAS (TODAS LAS DE LAS HDR SELECCIONADAS) ---");
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null)
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: NO ENCONTRADA");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: Estado = {guia.EstadoEncomienda}");
                    System.Diagnostics.Debug.WriteLine($"  Historial ({guia.HistorialEstadosGuia.Count} entradas):");
                    foreach (var hist in guia.HistorialEstadosGuia)
                    {
                        System.Diagnostics.Debug.WriteLine($"    - {hist.Fecha:yyyy-MM-dd HH:mm:ss}: {hist.EstadoGuiaEnum} - {hist.Descripcion}");
                    }
                }
            }
            // ============================================

            // Actualizar HDR: PendienteAsignacion -> NoCumplida + asignar DNI
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                if (hdr != null && hdr.EstadoHojaRutaFlete == EstadoHojaRutaFlete.PendienteAsignacion)
                {
                    hdr.EstadoHojaRutaFlete = EstadoHojaRutaFlete.NoCumplida;
                    hdr.DNIFletero = dniFletero;
                }
            }
            HojaRutaFleteAlmacen.GuardarHojaDeRutaFlete();

            // Actualizar TODAS las guías de las HDR seleccionadas
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null) continue;

                guia.EstadoEncomienda = EstadoEncomienda.EnCaminoADomicilioDestino;
                guia.HistorialEstadosGuia.Add(new HistorialEstadoGuia
                {
                    EstadoGuiaEnum = EstadoEncomienda.EnCaminoADomicilioDestino,
                    Fecha = DateTime.Now,
                    Descripcion = "Asignado a fletero"
                });
            }
            GuiaAlmacen.GuardarGuia();

            // ========== DEBUG TEMPORAL - DESPUÉS ==========
            System.Diagnostics.Debug.WriteLine("\n╔════════════════════════════════════════════╗");
            System.Diagnostics.Debug.WriteLine("║       DESPUÉS DE ASIGNAR                   ║");
            System.Diagnostics.Debug.WriteLine("╚════════════════════════════════════════════╝");

            // Mostrar estado de HDR
            System.Diagnostics.Debug.WriteLine("\n--- HOJAS DE RUTA ---");
            foreach (var id in hojasIds)
            {
                var hdr = hojasAlmacen.FirstOrDefault(h => h.HojaRutaFlete == id);
                System.Diagnostics.Debug.WriteLine($"HDR {id}: Estado = {hdr?.EstadoHojaRutaFlete}, DNI = {hdr?.DNIFletero}");
            }

            // Mostrar estado de TODAS las Guías
            System.Diagnostics.Debug.WriteLine("\n--- GUÍAS (TODAS LAS DE LAS HDR SELECCIONADAS) ---");
            foreach (var nro in todasLasGuiasDeHDR)
            {
                var guia = guiasAlmacen.FirstOrDefault(g => g.NumeroGuia == nro);
                if (guia == null)
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: NO ENCONTRADA");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Guía {nro}: Estado = {guia.EstadoEncomienda}");
                    System.Diagnostics.Debug.WriteLine($"  Historial ({guia.HistorialEstadosGuia.Count} entradas):");
                    foreach (var hist in guia.HistorialEstadosGuia)
                    {
                        System.Diagnostics.Debug.WriteLine($"    - {hist.Fecha:yyyy-MM-dd HH:mm:ss}: {hist.EstadoGuiaEnum} - {hist.Descripcion}");
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("\n════════════════════════════════════════════\n");
            // =============================================

            // refrescar listas públicas para que UI vea los cambios
            Refresh();
        }
    }
}