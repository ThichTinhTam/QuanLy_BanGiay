using _20T1020639_doan.GUI;

namespace _20T1020639_doan
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
             Application.Run(new FormDangNhap());
          //  Application.Run(new FormDangKi());
            //Application.Run(new FormDanhSachNhanVien());
        }
    }
}