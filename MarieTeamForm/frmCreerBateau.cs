using iText.StyledXmlParser.Jsoup.Helper;
using MarieTeamForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsAppAtlantic
{
    public partial class frmCreerBateau : Form
    {
        protected bool validData;

        string path;
        protected Image image;
        protected Thread getImageThread;
        public frmCreerBateau()
        {
            InitializeComponent();

        }
        private frmMenuPrincipal mainForm = new frmMenuPrincipal();
        public frmCreerBateau(Form callingForm)
        {
            mainForm = callingForm as frmMenuPrincipal;
            InitializeComponent();

        }
        private void frmCreerBateau_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Activate();
            picturebox.AllowDrop = true;
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
            lbl_success.Visible = false;
            lbl_ajouterImage.Visible = false;
            int equipid;

            if (picturebox.Image == null)
            {
                lbl_ajouterImage.Visible = true;
            }
            // Verifie si aucune cases n'est vide
            if (string.IsNullOrWhiteSpace(txtIdBateau.Text) || string.IsNullOrWhiteSpace(txtNameBateau.Text) || string.IsNullOrWhiteSpace(txtLongueurBateau.Text) || string.IsNullOrWhiteSpace(txtLargeurBateau.Text) || string.IsNullOrWhiteSpace(txt_vitesse.Text) || picturebox.Image == null)
            {
                lbl_errorEmpty.Visible = true;
            }
            else
            {
                int id = int.Parse(txtIdBateau.Text);
                string libelle = txtNameBateau.Text;
                double longueur = Double.Parse(txtLongueurBateau.Text);
                double largeur = Double.Parse(txtLargeurBateau.Text);
                int vitesse = int.Parse(txt_vitesse.Text);

                try
                {
                    Connection query = new Connection();
                    query.insertBoat(id, libelle, longueur, largeur, vitesse);
                    lbl_success.Visible = true;
                    lbl_errorEmpty.Visible = false;
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

                if (cb_equipHandi.Checked)
                {
                    equipid = 1;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);         
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
                if (cb_equipBar.Checked)
                {
                    equipid = 2;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipPont.Checked)
                {
                    equipid = 3;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipSalon.Checked)
                {
                    equipid = 4;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipToilettes.Checked)
                {
                    equipid = 5;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipResto.Checked)
                {
                    equipid = 6;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipCasino.Checked)
                {
                    equipid = 7;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
                if (cb_equipChambres.Checked)
                {
                    equipid = 8;
                    try
                    {
                        Connection query = new Connection();
                        query.insertEquip(equipid, id);
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
            
            
        }

        private void txtIdBateau_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txt_vitesse_KeyPress(object sender, KeyPressEventArgs e)
        {
            Process.AUTORISE_CHIFFRE_BACK(e);
        }


        private void txtIdBateau_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine(txtIdBateau.Text);
        }



        private void frmCreerBateau_FormClosed(object sender, FormClosedEventArgs e)
        {
             this.mainForm.visible();
        }

        private void lbl_success_Click(object sender, EventArgs e)
        {

        }
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = $"boat{txtIdBateau.Text}";
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }


        protected void LoadImage()

        {
            image = new Bitmap(path);
        }

        private void txtIdBateau_TextChanged(object sender, EventArgs e)
        {
            picturebox.Visible = true;
            lbl_ajouterImage.Visible = true;
        }

        private void txtIdBateau_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBateau.Text))
            {
                picturebox.Visible = false;
                lbl_ajouterImage.Visible = false;
                picturebox.ImageLocation = null; picturebox.Image = null;
            }
        }

        private void txtIdBateau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdBateau.Text))
            {
                picturebox.Visible = false;
                lbl_ajouterImage.Visible = false;
                picturebox.ImageLocation = null; picturebox.Image = null;
            }
        }

        private void frmCreerBateau_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            picturebox.Image = Image.FromFile(files[0]);
        }

        private void frmCreerBateau_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }


        private void picturebox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    picturebox.Image = Image.FromFile(fileNames[0]);
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.Image.Save($@"..\..\img\boat{txtIdBateau.Text}.jpg");
            }
        }

        private void picturebox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_equipChambres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_equipCasino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_equipResto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_equipToilettes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_equipHandi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_equipHandi_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_equipBar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_equipPont_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_equipSalon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_equipToilettes_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cb_equipResto_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_equipCasino_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cb_equipChambres_CheckedChanged_1(object sender, EventArgs e)
        {

           
        }
    }
}
