using PUSPITA.Views;

namespace PUSPITA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
            //Application.Run(new Register());
            //Application.Run(new Dashboard_Admin());
        }
    }
}