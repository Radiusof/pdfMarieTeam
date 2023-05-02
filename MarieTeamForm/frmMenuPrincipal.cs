using Atlantic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.IO.Image;
using iText.Kernel.Colors;
using WinFormsAppAtlantic;
using iText.StyledXmlParser.Jsoup.Nodes;

namespace MarieTeamForm
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btn_creerPdf_Click(object sender, EventArgs e)
        {
            Connection query = new Connection();
            query.SelectAllBoat(dgv_boat);
            dgv_boat.Visible = true;
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {

            lbl_confirmPDF.Visible = true;

            // Créer un objet PdfWriter pour écrire le document sur le disque
            PdfWriter writer = new PdfWriter("C:\\Users\\Public\\marieteam2023.pdf"); ;
            PdfDocument pdf = new PdfDocument(writer);
            // Créer un nouveau document PDF
            iText.Layout.Document document = new iText.Layout.Document(pdf);

            // Ajouter du texte
            Paragraph header = new Paragraph("Brochure PDF MarieTeam")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);
            document.Add(header);

            Paragraph subheader = new Paragraph(Program.libelleBateau)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);
            document.Add(subheader);

            // Line separator
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            //  Ajouter une image à partir d'un fichier en fonction de l'id bateau
            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory
               .Create($@"..\..\img\boat{Program.idBateau}.jpg"))
               .SetMaxHeight(180)
               .SetMaxWidth(180)
               .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
               .SetTextAlignment(TextAlignment.CENTER);
            document.Add(img);

            // Ajouter du texte
            Paragraph paragraph = new Paragraph("Informations sur le bateau:");
            document.Add(paragraph);

            // Table
            Table table = new Table(2, false);
            Cell cell11 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Longueur"));
            Cell cell12 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(Program.longueurBateau.ToString()));

            Cell cell21 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Largeur"));
            Cell cell22 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(Program.largeurBateau.ToString()));

            Cell cell31 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Vitesse"));
            Cell cell32 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(Program.vitesseBateau.ToString()));

            
            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell21);
            table.AddCell(cell22);
            table.AddCell(cell31);
            table.AddCell(cell32);

            document.Add(table);

            // Ajouter du texte
            Paragraph paragraph2 = new Paragraph("Equipement:");
            document.Add(paragraph2);

            Table table2 = new Table(1, false);

            // Itere si nécessaire pour récupere l'ensemble des equipements
            for (int i = 0; i < Program.equipement.Length; i++)
            {
                Cell forCell = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(Program.equipement[i].ToString()));

                table2.AddCell(forCell);
            }
;
            
            document.Add(table2);

            // Page numbers
            int n = pdf.GetNumberOfPages();
            for (int i = 1; i <= n; i++)
            {
                document.ShowTextAligned(new Paragraph(String
                   .Format("page" + i + " sur " + n)),
                   559, 806, i, TextAlignment.RIGHT,
                   VerticalAlignment.TOP, 0);
            }
            lbl_confirmPDF.Visible = true;
            document.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            panelMain.Visible = true;
        }

        private void dgv_boat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_boat.Rows[e.RowIndex];
                Program.idBateau =int.Parse(row.Cells[0].Value.ToString());

                Program.libelleBateau = row.Cells[1].Value.ToString();
                lbl_selectedBoat.Text = "Bateau sélectionné: " +
                    "" + Program.libelleBateau;
                Connection getDetails = new Connection();
                getDetails.getDetailsBoatById();
                Connection getEquip = new Connection();
                getEquip.getEquipement();
                lbl_selectedBoat.Visible = true;
                btn_pdf.Visible = true;
                btn_ajouterBateau.Visible = true;
                btn_supprimerBoat.Visible = true;
                btn_updateBoat.Visible = true;
            }
            else
            {
                btn_pdf.Visible = false;
                lbl_errorSelectGrid.Visible = true;
                btn_ajouterBateau.Visible = false;
            }
        }

        public void visible()
        {
            panelMain.Visible = true;
        }

        private void lbl_errorSelectGrid_Click(object sender, EventArgs e)
        {

        }

        private void dgv_boat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajouterBateau_Click(object sender, EventArgs e)
        {
            frmCreerBateau child = new frmCreerBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;


        }

        private void creerUnBateauCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreerBateau child = new frmCreerBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;

        }

        private void btn_updateBoat_Click(object sender, EventArgs e)
        {
            frmModifierInfoBateau child = new frmModifierInfoBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;

        }

        private void btn_supprimerBoat_Click(object sender, EventArgs e)
        {
            frmSupprimerBateau child = new frmSupprimerBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;

        }

        private void modifierInfosBateauxUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifierInfoBateau child = new frmModifierInfoBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;

        }

        private void supprimerBateauRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifierInfoBateau child = new frmModifierInfoBateau();
            Process.OUVRE_UNE_MDI_FILLE(child, this);
            panelMain.Visible = false;

        }

        private void voirLesBateauxRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenuPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            panelMain.Visible = true;
        }

        private void menuPrincipaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
        }


        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
