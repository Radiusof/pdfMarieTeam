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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nombresBateauxVoyageursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NbBateauxVoyageurs formVoyageur = new NbBateauxVoyageurs();
            Process.OUVRE_UNE_MDI_FILLE(formVoyageur, this);

        }

        private void nombresBateauxFrets_Click(object sender, EventArgs e)
        {
            NbBateauxFrets formFret = new NbBateauxFrets();
            Process.OUVRE_UNE_MDI_FILLE(formFret, this);
        }

        private void nombreEquipementBateauxVoyageursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NbEquipBateauxVoyageurs formNbEquip = new NbEquipBateauxVoyageurs();
            Process.OUVRE_UNE_MDI_FILLE(formNbEquip, this);
        }

        private void créerBateauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreerBateau formCreer = new CreerBateau();
            Process.OUVRE_UNE_MDI_FILLE(formCreer, this);
        }

        private void voirBateauxRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoirBateaux formVoir = new VoirBateaux();
            Process.OUVRE_UNE_MDI_FILLE(formVoir, this);
        }

        private void modifierInfosBateauxIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierInfoBateau formModifier = new ModifierInfoBateau();
            Process.OUVRE_UNE_MDI_FILLE(formModifier, this);
        }

        private void supprimerBateauRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerBateau formSupprimer = new SupprimerBateau();
            Process.OUVRE_UNE_MDI_FILLE(formSupprimer, this);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
