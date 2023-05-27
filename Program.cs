using Logitop.Services;
using Logitop.Utils;

namespace Logitop
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
            DbHelper.Initialize(Global.DatabaseHost, Global.DatabasePort, Global.DatabaseUsername, Global.DatabasePassword, Global.DatabaseName, Global.DatabaseSchema);
            Application.Run(new Homepage());
        }
    }
}