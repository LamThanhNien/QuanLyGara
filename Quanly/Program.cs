namespace Quanly
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
            //Application.Run(new fManage());
            //Application.Run(new fCar());
            //Application.Run(new fDichVu());
            //Application.Run(new fCustomer());
            //Application.Run(new fThanhToan());

            Application.Run(new fMain());
        }
    }
}