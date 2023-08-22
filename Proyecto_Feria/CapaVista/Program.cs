namespace CapaVista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormPrincipal(null));
            Application.Run(new formLogin());
        }
    }
}
