using DAT_Services.IServices;
using DAT_Services.Services;

namespace DAT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< Updated upstream
            Application.Run(new FormDangNhap());
=======
            Application.Run(new FrmSinhVien());
>>>>>>> Stashed changes
        }
    }
}