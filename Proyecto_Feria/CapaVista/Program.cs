using CapaControlador;
using CapaDatos;
using CapaPresentacion;
using CapaPresentacion.FormUsuarios;
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
           //recordar pedir el id del usuario que esta usando la app en el momento para que no halla conflicto
            ApplicationConfiguration.Initialize();
             // Application.Run(new FormPrincipal(null));
              Application.Run(new formLogin());
        }

    }
    }
