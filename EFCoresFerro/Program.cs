using EFCoresFerro.loc;
using EFCoresFerro.Windows;
using System;

namespace EFCoresFerro
{
    internal static class Program
    {
        public static IServiceProvider? serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            serviceProvider = DI.ConfigurarServicios();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal(serviceProvider));
        }
    }
}