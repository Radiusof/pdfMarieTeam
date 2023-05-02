
namespace MarieTeamForm
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btn_creerPdf = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.lbl_confirmPDF = new System.Windows.Forms.Label();
            this.dgv_boat = new System.Windows.Forms.DataGridView();
            this.lbl_errorSelectGrid = new System.Windows.Forms.Label();
            this.lbl_selectedBoat = new System.Windows.Forms.Label();
            this.btn_ajouterBateau = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeBateauxVoyageursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDéquipementsBateauxVoyageursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUnBateauCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierInfosBateauxUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerBateauRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_updateBoat = new System.Windows.Forms.Button();
            this.btn_supprimerBoat = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_creerPdf
            // 
            this.btn_creerPdf.Location = new System.Drawing.Point(50, 86);
            this.btn_creerPdf.Name = "btn_creerPdf";
            this.btn_creerPdf.Size = new System.Drawing.Size(165, 74);
            this.btn_creerPdf.TabIndex = 0;
            this.btn_creerPdf.Text = "Afficher tout les bateaux";
            this.btn_creerPdf.UseVisualStyleBackColor = true;
            this.btn_creerPdf.Click += new System.EventHandler(this.btn_creerPdf_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(50, 485);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(165, 65);
            this.btn_pdf.TabIndex = 1;
            this.btn_pdf.Text = "Génerer une brochure";
            this.btn_pdf.UseCompatibleTextRendering = true;
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Visible = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // lbl_confirmPDF
            // 
            this.lbl_confirmPDF.AutoSize = true;
            this.lbl_confirmPDF.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPDF.Location = new System.Drawing.Point(303, 703);
            this.lbl_confirmPDF.Name = "lbl_confirmPDF";
            this.lbl_confirmPDF.Size = new System.Drawing.Size(459, 22);
            this.lbl_confirmPDF.TabIndex = 2;
            this.lbl_confirmPDF.Text = "PDF crée et sauvegardé dans le dossier : C\\Users\\Public";
            this.lbl_confirmPDF.Visible = false;
            // 
            // dgv_boat
            // 
            this.dgv_boat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_boat.Location = new System.Drawing.Point(284, 75);
            this.dgv_boat.Name = "dgv_boat";
            this.dgv_boat.RowHeadersWidth = 62;
            this.dgv_boat.RowTemplate.Height = 28;
            this.dgv_boat.Size = new System.Drawing.Size(722, 452);
            this.dgv_boat.TabIndex = 3;
            this.dgv_boat.Visible = false;
            this.dgv_boat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_boat_CellClick);
            this.dgv_boat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_boat_CellContentClick);
            // 
            // lbl_errorSelectGrid
            // 
            this.lbl_errorSelectGrid.AutoSize = true;
            this.lbl_errorSelectGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorSelectGrid.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errorSelectGrid.Location = new System.Drawing.Point(472, 530);
            this.lbl_errorSelectGrid.Name = "lbl_errorSelectGrid";
            this.lbl_errorSelectGrid.Size = new System.Drawing.Size(382, 20);
            this.lbl_errorSelectGrid.TabIndex = 4;
            this.lbl_errorSelectGrid.Text = "Veuillez sélectionner un bateau pour continuer";
            this.lbl_errorSelectGrid.Visible = false;
            this.lbl_errorSelectGrid.Click += new System.EventHandler(this.lbl_errorSelectGrid_Click);
            // 
            // lbl_selectedBoat
            // 
            this.lbl_selectedBoat.AutoSize = true;
            this.lbl_selectedBoat.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedBoat.Location = new System.Drawing.Point(303, 601);
            this.lbl_selectedBoat.Name = "lbl_selectedBoat";
            this.lbl_selectedBoat.Size = new System.Drawing.Size(0, 22);
            this.lbl_selectedBoat.TabIndex = 5;
            this.lbl_selectedBoat.Visible = false;
            // 
            // btn_ajouterBateau
            // 
            this.btn_ajouterBateau.Location = new System.Drawing.Point(50, 228);
            this.btn_ajouterBateau.Name = "btn_ajouterBateau";
            this.btn_ajouterBateau.Size = new System.Drawing.Size(165, 65);
            this.btn_ajouterBateau.TabIndex = 6;
            this.btn_ajouterBateau.Text = "Ajouter un Bateau";
            this.btn_ajouterBateau.UseCompatibleTextRendering = true;
            this.btn_ajouterBateau.UseVisualStyleBackColor = true;
            this.btn_ajouterBateau.Visible = false;
            this.btn_ajouterBateau.Click += new System.EventHandler(this.btn_ajouterBateau_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.cRUDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipaleToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuPrincipaleToolStripMenuItem
            // 
            this.menuPrincipaleToolStripMenuItem.Name = "menuPrincipaleToolStripMenuItem";
            this.menuPrincipaleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.menuPrincipaleToolStripMenuItem.Text = "Menu Principale";
            this.menuPrincipaleToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipaleToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeBateauxVoyageursToolStripMenuItem,
            this.nombreDeToolStripMenuItem,
            this.nombreDéquipementsBateauxVoyageursToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // nombreDeBateauxVoyageursToolStripMenuItem
            // 
            this.nombreDeBateauxVoyageursToolStripMenuItem.Name = "nombreDeBateauxVoyageursToolStripMenuItem";
            this.nombreDeBateauxVoyageursToolStripMenuItem.Size = new System.Drawing.Size(441, 34);
            this.nombreDeBateauxVoyageursToolStripMenuItem.Text = "Nombre bateaux voyageurs";
            // 
            // nombreDeToolStripMenuItem
            // 
            this.nombreDeToolStripMenuItem.Name = "nombreDeToolStripMenuItem";
            this.nombreDeToolStripMenuItem.Size = new System.Drawing.Size(441, 34);
            this.nombreDeToolStripMenuItem.Text = "Nombre bateaux frets";
            // 
            // nombreDéquipementsBateauxVoyageursToolStripMenuItem
            // 
            this.nombreDéquipementsBateauxVoyageursToolStripMenuItem.Name = "nombreDéquipementsBateauxVoyageursToolStripMenuItem";
            this.nombreDéquipementsBateauxVoyageursToolStripMenuItem.Size = new System.Drawing.Size(441, 34);
            this.nombreDéquipementsBateauxVoyageursToolStripMenuItem.Text = "Nombre equipements Bateaux voyageurs";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnBateauCToolStripMenuItem,
            this.modifierInfosBateauxUToolStripMenuItem,
            this.supprimerBateauRToolStripMenuItem});
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // creerUnBateauCToolStripMenuItem
            // 
            this.creerUnBateauCToolStripMenuItem.Name = "creerUnBateauCToolStripMenuItem";
            this.creerUnBateauCToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.creerUnBateauCToolStripMenuItem.Text = "Creer bateau (C)";
            this.creerUnBateauCToolStripMenuItem.Click += new System.EventHandler(this.creerUnBateauCToolStripMenuItem_Click);
            // 
            // modifierInfosBateauxUToolStripMenuItem
            // 
            this.modifierInfosBateauxUToolStripMenuItem.Name = "modifierInfosBateauxUToolStripMenuItem";
            this.modifierInfosBateauxUToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.modifierInfosBateauxUToolStripMenuItem.Text = "Modifier infos bateaux (U)";
            this.modifierInfosBateauxUToolStripMenuItem.Click += new System.EventHandler(this.modifierInfosBateauxUToolStripMenuItem_Click);
            // 
            // supprimerBateauRToolStripMenuItem
            // 
            this.supprimerBateauRToolStripMenuItem.Name = "supprimerBateauRToolStripMenuItem";
            this.supprimerBateauRToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.supprimerBateauRToolStripMenuItem.Text = "Supprimer Bateau (D)";
            this.supprimerBateauRToolStripMenuItem.Click += new System.EventHandler(this.supprimerBateauRToolStripMenuItem_Click);
            // 
            // btn_updateBoat
            // 
            this.btn_updateBoat.Location = new System.Drawing.Point(50, 299);
            this.btn_updateBoat.Name = "btn_updateBoat";
            this.btn_updateBoat.Size = new System.Drawing.Size(165, 65);
            this.btn_updateBoat.TabIndex = 9;
            this.btn_updateBoat.Text = "Mettre à jour infos bateau";
            this.btn_updateBoat.UseCompatibleTextRendering = true;
            this.btn_updateBoat.UseVisualStyleBackColor = true;
            this.btn_updateBoat.Visible = false;
            this.btn_updateBoat.Click += new System.EventHandler(this.btn_updateBoat_Click);
            // 
            // btn_supprimerBoat
            // 
            this.btn_supprimerBoat.Location = new System.Drawing.Point(50, 369);
            this.btn_supprimerBoat.Name = "btn_supprimerBoat";
            this.btn_supprimerBoat.Size = new System.Drawing.Size(165, 65);
            this.btn_supprimerBoat.TabIndex = 10;
            this.btn_supprimerBoat.Text = "Supprimer un bateau";
            this.btn_supprimerBoat.UseCompatibleTextRendering = true;
            this.btn_supprimerBoat.UseVisualStyleBackColor = true;
            this.btn_supprimerBoat.Visible = false;
            this.btn_supprimerBoat.Click += new System.EventHandler(this.btn_supprimerBoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::MarieTeamForm.Properties.Resources.logo_color1;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.btn_creerPdf);
            this.panelMain.Controls.Add(this.btn_pdf);
            this.panelMain.Controls.Add(this.lbl_selectedBoat);
            this.panelMain.Controls.Add(this.btn_supprimerBoat);
            this.panelMain.Controls.Add(this.lbl_confirmPDF);
            this.panelMain.Controls.Add(this.btn_updateBoat);
            this.panelMain.Controls.Add(this.dgv_boat);
            this.panelMain.Controls.Add(this.lbl_errorSelectGrid);
            this.panelMain.Controls.Add(this.btn_ajouterBateau);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1108, 825);
            this.panelMain.TabIndex = 14;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 858);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principale";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.VisibleChanged += new System.EventHandler(this.frmMenuPrincipal_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_creerPdf;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Label lbl_confirmPDF;
        private System.Windows.Forms.DataGridView dgv_boat;
        private System.Windows.Forms.Label lbl_errorSelectGrid;
        private System.Windows.Forms.Label lbl_selectedBoat;
        private System.Windows.Forms.Button btn_ajouterBateau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeBateauxVoyageursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDéquipementsBateauxVoyageursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerUnBateauCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierInfosBateauxUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerBateauRToolStripMenuItem;
        private System.Windows.Forms.Button btn_updateBoat;
        private System.Windows.Forms.Button btn_supprimerBoat;
        private System.Windows.Forms.Panel panelMain;
    }
}