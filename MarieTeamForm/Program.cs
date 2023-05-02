using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MarieTeamForm
{
    static class Program
    {
        public static string libelleBateau;
        public static int idBateau;
        public static double longueurBateau;
        public static double largeurBateau;
        public static int vitesseBateau;
        public static string[] equipement;

        public static Form frmOuverte;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());
        }
    }
}
