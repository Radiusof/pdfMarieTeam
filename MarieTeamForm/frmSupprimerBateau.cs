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
    public partial class frmSupprimerBateau : Form
    {
        public frmSupprimerBateau()
        {
            InitializeComponent();
        }
        private frmMenuPrincipal mainForm = new frmMenuPrincipal();
        public frmSupprimerBateau(Form callingForm)
        {
            mainForm = callingForm as frmMenuPrincipal;
            InitializeComponent();

        }

        private void frmSupprimerBateau_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            if (string.IsNullOrWhiteSpace(Program.libelleBateau))
            {
                lbl_selectBoat.Text = "Aucun";
                lbl_errorEmpty.Visible = true;
                button1.Visible = false;
            } else
            {
                lbl_selectBoat.Text = Program.libelleBateau;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection query = new Connection();
            query.Delete();
        }

        private void frmSupprimerBateau_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.mainForm.visible();
        }
    }
}
