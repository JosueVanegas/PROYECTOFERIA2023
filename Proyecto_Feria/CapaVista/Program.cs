using CapaVista.FormConfiguracion;

namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmPrincipal(null, formConfiguraciones.Mod));
            Application.Run(new formLogin());
        }
    }
}
