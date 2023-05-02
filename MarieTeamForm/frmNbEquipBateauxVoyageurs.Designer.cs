using System.Windows.Forms;

namespace WinFormsAppAtlantic
{
    partial class frmNbEquipBateauxVoyageurs
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
            this.lblTitleNbEquipement = new System.Windows.Forms.Label();
            this.lblResultNbEquipement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleNbEquipement
            // 
            this.lblTitleNbEquipement.AutoSize = true;
            this.lblTitleNbEquipement.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNbEquipement.Location = new System.Drawing.Point(74, 177);
            this.lblTitleNbEquipement.Name = "lblTitleNbEquipement";
            this.lblTitleNbEquipement.Size = new System.Drawing.Size(209, 21);
            this.lblTitleNbEquipement.TabIndex = 0;
            this.lblTitleNbEquipement.Text = "Nombres d\'équipements :";
            // 
            // lblResultNbEquipement
            // 
            this.lblResultNbEquipement.AutoSize = true;
            this.lblResultNbEquipement.Location = new System.Drawing.Point(309, 176);
            this.lblResultNbEquipement.Name = "lblResultNbEquipement";
            this.lblResultNbEquipement.Size = new System.Drawing.Size(0, 25);
            this.lblResultNbEquipement.TabIndex = 1;
            // 
            // NbEquipBateauxVoyageurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultNbEquipement);
            this.Controls.Add(this.lblTitleNbEquipement);
            this.Name = "NbEquipBateauxVoyageurs";
            this.Text = "NbEquipBateauxVoyageurs";
            this.Load += new System.EventHandler(this.NbEquipBateauxVoyageurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleNbEquipement;
        private Label lblResultNbEquipement;
    }
}