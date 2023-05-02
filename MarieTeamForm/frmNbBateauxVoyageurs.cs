using Atlantic;
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
    public partial class frmNbBateauxVoyageurs : Form
    {
        public frmNbBateauxVoyageurs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NbBateauxVoyageurs_Load(object sender, EventArgs e)
        {
            passerelle initPasserelle = new passerelle();
            initPasserelle.initPasserelle();
            List<BateauVoyageur> listBateau = initPasserelle.getListBateauVoyageur();
            int count = listBateau.Count;
            lblResultNbBateauxVoyageurs.Text = count.ToString();
        }
    }
}
