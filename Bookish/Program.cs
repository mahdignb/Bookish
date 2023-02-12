using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Bookish
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
            if (Helper.LoadToken() != string.Empty)
            {
                Application.Run(new UserPanel());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}