using PUSPITA.Views;

namespace PUSPITA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormLogin());
            //Application.Run(new Shop());
            Application.Run(new Kelola_Produksi());
            //Application.Run(new History_Transaksi_Admin());
            //Application.Run(new Rekomendasi());
            //Application.Run(new Register());
            //Application.Run(new Dashboard_Admin());
            //Application.Run(new Dashboard_Petani());
            //Application.Run(new Transaksi());
        }
    }
}