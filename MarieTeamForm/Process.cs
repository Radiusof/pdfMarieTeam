using MarieTeamForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsAppAtlantic
{
    internal class Process
    {
        /// <summary>
        /// initialise à vide les zones de textes contenues dans le controle passé en paramètre
        /// </summary>
        /// <param name="unConteneur">contrôle contenant un ensemble de zones de textes (une feuille, un groupBox, un panel,etc.)</param>
        static public void INIT_ZONES(Control unConteneur)
        {
            foreach (Control unControle in unConteneur.Controls)
            {
                if (unControle is TextBox)
                    unControle.Text = "";

            }
        }

        /// <summary>
        /// annule la saisie si ce n'est un chiffre ou le caractère backspace
        /// </summary>
        /// <param name="e">événement qui a déclenché l'appel</param>
        public static void AUTORISE_CHIFFRE_BACK(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
                //si ce n'est pas un caractère accepté, on annule la saisie
                e.Handled = true;
        }


        /// <summary>
        /// ferme la feuille ouverte précdemment et ouvre la nouvelle feuille
        /// </summary>
        /// <param name="uneForm">la feuille à ouvrir</param>
        /// <param name="laFeuilleMDI">la feuille mdi dans laquelle doit être ouverte la feuille</param>
        public static void OUVRE_UNE_MDI_FILLE(Form uneForm, Form laFeuilleMDI)
        {
            if (Program.frmOuverte != null)
                Program.frmOuverte.Close();

            Program.frmOuverte = uneForm;
            
            uneForm.MdiParent = laFeuilleMDI;
            uneForm.WindowState = FormWindowState.Maximized;
            uneForm.Show(); 
        }
    }
}
