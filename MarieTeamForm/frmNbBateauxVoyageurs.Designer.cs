using System.Windows.Forms;

namespace WinFormsAppAtlantic
{
    partial class frmNbBateauxVoyageurs
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
            this.lblTitleNbBateauxVoyageurs = new System.Windows.Forms.Label();
            this.lblResultNbBateauxVoyageurs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleNbBateauxVoyageurs
            // 
            this.lblTitleNbBateauxVoyageurs.AutoSize = true;
            this.lblTitleNbBateauxVoyageurs.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNbBateauxVoyageurs.Location = new System.Drawing.Point(53, 196);
            this.lblTitleNbBateauxVoyageurs.Name = "lblTitleNbBateauxVoyageurs";
            this.lblTitleNbBateauxVoyageurs.Size = new System.Drawing.Size(281, 22);
            this.lblTitleNbBateauxVoyageurs.TabIndex = 0;
            this.lblTitleNbBateauxVoyageurs.Text = "Nombres de Bateaux Voyageurs :";
            this.lblTitleNbBateauxVoyageurs.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResultNbBateauxVoyageurs
            // 
            this.lblResultNbBateauxVoyageurs.AutoSize = true;
            this.lblResultNbBateauxVoyageurs.Location = new System.Drawing.Point(358, 194);
            this.lblResultNbBateauxVoyageurs.Name = "lblResultNbBateauxVoyageurs";
            this.lblResultNbBateauxVoyageurs.Size = new System.Drawing.Size(12, 25);
            this.lblResultNbBateauxVoyageurs.TabIndex = 1;
            this.lblResultNbBateauxVoyageurs.Text = "\r\n";
            // 
            // NbBateauxVoyageurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultNbBateauxVoyageurs);
            this.Controls.Add(this.lblTitleNbBateauxVoyageurs);
            this.Name = "NbBateauxVoyageurs";
            this.Text = "NbBateauxVoyageurs";
            this.Load += new System.EventHandler(this.NbBateauxVoyageurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleNbBateauxVoyageurs;
        private Label lblResultNbBateauxVoyageurs;
    }
}