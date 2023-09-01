using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System.Data.Common;

namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(null));
            //Application.Run(new formLogin());
        }
    }
}
