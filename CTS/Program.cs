using System;
using System.Windows.Forms;
namespace CTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!Properties.Settings.Default.apiKey.ToString().Equals(""))
                Application.Run(new DashboardUser(new UILogin()));
            else
            Application.Run(new UILogin());
        }
    }
}
