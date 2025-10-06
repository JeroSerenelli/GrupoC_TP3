using GrupoC_TP3.CU10_ConfeccionarHDRdeEntregadeEncomiendas;
using GrupoC_TP3.CU11_ConfeccionarHDRdeRetirodeEncomiendas;

namespace GrupoC_TP3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ConsultaEstadoGuiaEnCD.ConsultaEstadoGuiaEnCDForm());
            Application.Run(new RegistrarImposicionRetiroPorDomicilio.RegistrarImposicionRetiroPorDomicilioForm());
            Application.Run(new RegistrarImposicionEnAgencia.RegistrarImposicionEnAgenciaForm());
            Application.Run(new ConsultaEstadoGuiaEnCD.ConsultaEstadoGuiaEnCDForm());
            Application.Run(new ConsultaEstadoGuiaTelefonica.ConsultaEstadoGuiaTelefonicaForm());
            Application.Run(new ResultadoCostosVsVentas.ResultadoCostosVsVentasForm());
            Application.Run(new ConfeccionarHojaDeRuta.ConfeccionarHDRdeTransportedeMediayLargaDistancia());
            Application.Run(new ConfeccionarHDRdeEntregadeEncomiendas());
            Application.Run(new ConfeccionarHDRdeRetirodeEncomiendas());
            
        }
    }
}