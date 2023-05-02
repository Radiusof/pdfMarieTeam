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
    public partial class NbEquipBateauxVoyageurs : Form
    {
        public NbEquipBateauxVoyageurs()
        {
            InitializeComponent();
        }

        private void NbEquipBateauxVoyageurs_Load(object sender, EventArgs e)
        {
            passerelle initPasserelle = new passerelle();
            initPasserelle.initPasserelle();
            List<Equipement> listEquipement = initPasserelle.getEquipementList();
            int count = listEquipement.Count;
            lblResultNbEquipement.Text = count.ToString();
        }
    }
}
