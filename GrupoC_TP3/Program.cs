

using GrupoC_TP3.CU3_RegistrarImposicionEnCD;
using GrupoC_TP3.RegistrarImposicionRetiroPorDomicilio;

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
            //Application.Run(new RegistrarImposicionRetiroPorDomicilioForm());
            //Application.Run(new CU2_RegistrarImposicionEnAgencia.RegistrarImposicionEnAgenciaForm());
            //Application.Run(new CU7_ConsultaEstadoGuia.ConsultaEstadoGuiaForm());
            //Application.Run(new CU10_ResultadoCostosVsVentas.ResultadoCostosVsVentasForm());
            //Application.Run(new CU3_RegistrarImposicionEnCD.RegistrarImposicionEnCDForm());
            //Application.Run(new CU10_ResultadoCostosVsVentas.ResultadoCostosVsVentasForm());
            Application.Run(new RegistrarImposicionRetiroPorDomicilioForm());

        }
    }
}