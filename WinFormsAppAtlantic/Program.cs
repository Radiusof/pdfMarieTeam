using System.Windows.Forms;
using Atlantic;
using System.Collections.Generic;


namespace WinFormsAppAtlantic
{
    internal static class Program
    {
        public static Form frmOuverte;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            passerelle Passerelle = new passerelle();
            Passerelle.initPasserelle();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}