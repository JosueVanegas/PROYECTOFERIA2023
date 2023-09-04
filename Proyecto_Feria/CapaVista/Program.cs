using CapaControlador;
using CapaDatos;
using Microcharts;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using System.Data.Common;
using System.Globalization;

namespace CapaVista
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
           Application.Run(new FormPrincipal(null));
          // Application.Run(new formLogin());
        }

    }
}
/*
 *  string tituloRango = "Nómina realizada el " + DateTime.Now.ToString($"dddd dd MMMM año yyyy");
             Empresa empresa = new ControlEmpresa().datosEmpresa();
             string colorFondoNomina = "#CCCAFE ";

             QuestPDF.Fluent.Document.Create(doc =>
             {
                 doc.Page(page =>
                 {
                     page.Size(PageSizes.Letter);
                     page.Margin(10);

                     page.DefaultTextStyle(TextStyle.Default.FontSize(12));
                     page.PageColor(Colors.White);
                     page.Background().AlignTop().ExtendHorizontal().Height(100).Background(colorFondoNomina);
                     page.Header().Element(Encabezado);
                     page.Footer().Element(piePagina);
                     page.Content().Element(contenidoNomina);
                 });
             }).ShowInPreviewer();
             void Encabezado(IContainer content)
             {
                 content.Row(row =>
                 {
                     row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                     {
                         col.Spacing(10);
                         col
                             .Item()
                             .Image(empresa.imagen).FitArea()
                             .WithCompressionQuality(ImageCompressionQuality.VeryLow);
                     });
                     row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80).Column(col =>
                     {
                         col.Item().AlignCenter().Text(empresa.nombre).FontSize(28).Bold();
                         col.Item().AlignCenter().Text("Teléfono: " + empresa.telefono).FontSize(7);
                         col.Item().AlignCenter().Text("Correo electronico: " + empresa.email).FontSize(7);
                         col.Item().AlignCenter().Text("Direccion: " + empresa.direccion + "/" + empresa.departamento).FontSize(7);
                     });
                     row.RelativeItem().Border(0).Background(Colors.Transparent).Height(80);
                 });
             }
             void piePagina(IContainer content)
             {
                 content.AlignCenter().Text(txt =>
                 {
                     txt.Span("Pagina  ").FontSize(10);
                     txt.CurrentPageNumber().FontSize(10);
                     txt.Span("  de  ").FontSize(10);
                     txt.TotalPages().FontSize(10);

                 });
             }
             void contenidoNomina(IContainer content)
             {

                 List<Empleado> lista = new ControlEmpleados().listarEmpleados();
                 content.PaddingVertical(25).Column(column =>
                 {
                     column.Item().AlignCenter().Text("Nómina de pago al personal").FontSize(25);
                     column.Item().AlignCenter().Text("Expresada en Cordobas(C$)").FontSize(15);
                     column.Item().AlignCenter().Text(txt =>
                     {

                         txt.Span(tituloRango).FontSize(15);

                     });
                     column.Spacing(30);

                     column.Item().LineHorizontal(0.5f);
                     //nomina
                     column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                     {
                         tab.ColumnsDefinition(columns =>
                         {
                             columns.RelativeColumn(4);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                             columns.RelativeColumn(3);
                         });

                         tab.Header(het =>
                         {
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Nombre del trabajador").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Cargo").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Salario por hora").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Horas trabajadas").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Monto horas trabajadas").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Horas extras trabajadas ").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Monto horas extras").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Salario devengado").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Inss laboral").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("IR laboral").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Total deducciones").FontSize(10);
                             het.Cell().Border(1).Background(colorFondoNomina).Padding(1).Text("Neto a recibir").FontSize(10);
                         });
                         foreach (Empleado i in lista)
                         {

                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.nombres + " "+i.apellidos).FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.cargo).FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.salarioHora).FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                             tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text("").FontSize(9);
                         }
                     });
                     column.Item().Row(row =>
                     {
                         row.RelativeItem().Column(col =>
                         {
                             col.Item().AlignCenter().Text(txt =>
                             {
                                 txt.Span("Total a pagar en nómina: C$").FontSize(15);
                             });
                         });
                     });
                 });
             } 
             

 */
