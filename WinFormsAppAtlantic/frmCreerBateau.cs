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
    public partial class frmCreerBateau : Form
    {
        public frmCreerBateau()
        {
            InitializeComponent();
        }

        private void frmCreerBateau_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmCreate_Visible(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIdBateau.Text) && string.IsNullOrEmpty(txtLargeurBateau.Text) && string.IsNullOrEmpty(txtLongueurBateau.Text) && string.IsNullOrEmpty(txtNameBateau.Text))
            {
                btnConfirmCreate.Visible = false;
            }
            
            else
            {
                btnConfirmCreate.Visible = true;
            }
        }

        private void btnConfirmCreate_Click(object sender, EventArgs e)
        {
            string id = lblTitleIdBateau.Text;
            string nom = lblTitleNomBateau.Text;
            double longueur = Double.Parse(lblTitleLongueurBateau.Text);
            double largeur = Double.Parse(lblTitleLargueurBateau.Text);
        }

        private void txtIdBateau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Process.AUTORISE_CHIFFRE_BACK(e);
        }

        private void txtNameBateau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Process.AUTORISE_CHIFFRE_BACK(e);
        }

        private void txtLongueurBateau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Process.AUTORISE_CHIFFRE_BACK(e);
        }

        private void txtLargeurBateau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Process.AUTORISE_CHIFFRE_BACK(e);
        }
    }
}
