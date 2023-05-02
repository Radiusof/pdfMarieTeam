using iText.Layout.Splitting;
using MarieTeamForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAtlantic
{
    public partial class frmModifierInfoBateau : Form
    {
        public frmModifierInfoBateau()
        {
            InitializeComponent();
        }

        private void btnConfirmCreate_Click(object sender, EventArgs e)
        {
            lbl_successUpdate.Visible = false;
            // Verifie si aucune cases n'est vide
            if (string.IsNullOrWhiteSpace(txtNameBateauUpdate.Text) && string.IsNullOrWhiteSpace(txtLongueurBateauUpdate.Text) && string.IsNullOrWhiteSpace(txtLargeurBateauUpdate.Text) && string.IsNullOrWhiteSpace(txt_vitesseUpdate.Text)){
                lbl_errorEmptyUpdate.Visible = true;
            }
            else
            {

                if (string.IsNullOrWhiteSpace(txtNameBateauUpdate.Text))
                {
                    txtNameBateauUpdate.Text = lbl_libelleActuel.Text;
                }
                if (string.IsNullOrWhiteSpace(txtLongueurBateauUpdate.Text))
                {
                    txtLongueurBateauUpdate.Text = lbl_longueurActuel.Text;
                }
                if (string.IsNullOrWhiteSpace(txtLargeurBateauUpdate.Text))
                {
                    txtLargeurBateauUpdate.Text = lbl_largeurActuel.Text;
                }
                if (string.IsNullOrWhiteSpace(txt_vitesseUpdate.Text))
                {
                    txt_vitesseUpdate.Text = lbl_vitesseActuel.Text;
                }

                string libelle = txtNameBateauUpdate.Text;
                double longueur = Double.Parse(txtLongueurBateauUpdate.Text);
                double largeur = Double.Parse(txtLargeurBateauUpdate.Text);
                int vitesse = int.Parse(txt_vitesseUpdate.Text);

                try
                {
                    Connection query = new Connection();
                    query.Update(libelle, longueur, largeur, vitesse);
                    lbl_successUpdate.Visible = true;
                    lbl_errorEmptyUpdate.Visible = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException err)
                {
                    switch (err.Number)
                    {
                        case 0:
                            MessageBox.Show("Impossible de se connecter au serveur.");
                            break;
                        case 1045:
                            MessageBox.Show("Utilisateur/Mdp incorrect");
                            break;
                        default:
                            MessageBox.Show(err.Message);
                            break;
                    }
                }
            }
        }

        private void frmModifierInfoBateau_Load(object sender, EventArgs e)
        {
            lbl_idActuel.Text = Program.idBateau.ToString();
            lbl_libelleActuel.Text = Program.libelleBateau;
            lbl_longueurActuel.Text = Program.longueurBateau.ToString();
            lbl_largeurActuel.Text = Program.largeurBateau.ToString();
            lbl_vitesseActuel.Text = Program.vitesseBateau.ToString();
        }

        private void btn_backMenuUpdate_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
        }
    }
}
