using CapaVista.FormConfiguracion;

namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(null, true));
            //Application.Run(new formLogin());
        }
    }
}
