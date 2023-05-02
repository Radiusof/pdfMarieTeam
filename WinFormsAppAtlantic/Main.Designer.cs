namespace WinFormsAppAtlantic
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombresBateauxVoyageursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombresBateauxFrets = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreEquipementBateauxVoyageursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirBateauxRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierInfosBateauxIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerBateauRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiquesToolStripMenuItem,
            this.cRUDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresBateauxVoyageursToolStripMenuItem,
            this.nombresBateauxFrets,
            this.nombreEquipementBateauxVoyageursToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // nombresBateauxVoyageursToolStripMenuItem
            // 
            this.nombresBateauxVoyageursToolStripMenuItem.Name = "nombresBateauxVoyageursToolStripMenuItem";
            this.nombresBateauxVoyageursToolStripMenuItem.Size = new System.Drawing.Size(446, 34);
            this.nombresBateauxVoyageursToolStripMenuItem.Text = "Nombres Bateaux Voyageurs";
            this.nombresBateauxVoyageursToolStripMenuItem.Click += new System.EventHandler(this.nombresBateauxVoyageursToolStripMenuItem_Click);
            // 
            // nombresBateauxFrets
            // 
            this.nombresBateauxFrets.Name = "nombresBateauxFrets";
            this.nombresBateauxFrets.Size = new System.Drawing.Size(446, 34);
            this.nombresBateauxFrets.Text = "Nombres Bateaux Frêts";
            this.nombresBateauxFrets.Click += new System.EventHandler(this.nombresBateauxFrets_Click);
            // 
            // nombreEquipementBateauxVoyageursToolStripMenuItem
            // 
            this.nombreEquipementBateauxVoyageursToolStripMenuItem.Name = "nombreEquipementBateauxVoyageursToolStripMenuItem";
            this.nombreEquipementBateauxVoyageursToolStripMenuItem.Size = new System.Drawing.Size(446, 34);
            this.nombreEquipementBateauxVoyageursToolStripMenuItem.Text = "Nombre Equipement / Bateaux Voyageurs";
            this.nombreEquipementBateauxVoyageursToolStripMenuItem.Click += new System.EventHandler(this.nombreEquipementBateauxVoyageursToolStripMenuItem_Click);
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerBateauToolStripMenuItem,
            this.voirBateauxRToolStripMenuItem,
            this.modifierInfosBateauxIToolStripMenuItem,
            this.supprimerBateauRToolStripMenuItem});
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            // 
            // créerBateauToolStripMenuItem
            // 
            this.créerBateauToolStripMenuItem.Name = "créerBateauToolStripMenuItem";
            this.créerBateauToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.créerBateauToolStripMenuItem.Text = "Créer Bateau (C)";
            this.créerBateauToolStripMenuItem.Click += new System.EventHandler(this.créerBateauToolStripMenuItem_Click);
            // 
            // voirBateauxRToolStripMenuItem
            // 
            this.voirBateauxRToolStripMenuItem.Name = "voirBateauxRToolStripMenuItem";
            this.voirBateauxRToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.voirBateauxRToolStripMenuItem.Text = "Voir Bateaux (R)";
            this.voirBateauxRToolStripMenuItem.Click += new System.EventHandler(this.voirBateauxRToolStripMenuItem_Click);
            // 
            // modifierInfosBateauxIToolStripMenuItem
            // 
            this.modifierInfosBateauxIToolStripMenuItem.Name = "modifierInfosBateauxIToolStripMenuItem";
            this.modifierInfosBateauxIToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.modifierInfosBateauxIToolStripMenuItem.Text = "Modifier Infos Bateaux (U)";
            this.modifierInfosBateauxIToolStripMenuItem.Click += new System.EventHandler(this.modifierInfosBateauxIToolStripMenuItem_Click);
            // 
            // supprimerBateauRToolStripMenuItem
            // 
            this.supprimerBateauRToolStripMenuItem.Name = "supprimerBateauRToolStripMenuItem";
            this.supprimerBateauRToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.supprimerBateauRToolStripMenuItem.Text = "Supprimer Bateau (R)";
            this.supprimerBateauRToolStripMenuItem.Click += new System.EventHandler(this.supprimerBateauRToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem statistiquesToolStripMenuItem;
        private ToolStripMenuItem nombresBateauxVoyageursToolStripMenuItem;
        private ToolStripMenuItem nombresBateauxFrets;
        private ToolStripMenuItem nombreEquipementBateauxVoyageursToolStripMenuItem;
        private ToolStripMenuItem cRUDToolStripMenuItem;
        private ToolStripMenuItem créerBateauToolStripMenuItem;
        private ToolStripMenuItem voirBateauxRToolStripMenuItem;
        private ToolStripMenuItem modifierInfosBateauxIToolStripMenuItem;
        private ToolStripMenuItem supprimerBateauRToolStripMenuItem;
    }
}