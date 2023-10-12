using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using static NPOI.HSSF.Util.HSSFColor;

namespace CapaVista
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
              //Application.Run(new FormPrincipalOpt(null));
              Application.Run(new formUsuarios());
        }

    }
    }
