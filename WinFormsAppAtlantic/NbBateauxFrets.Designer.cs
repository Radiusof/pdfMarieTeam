namespace WinFormsAppAtlantic
{
    partial class NbBateauxFrets
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
            this.lblTitleNbBateauxFrets = new System.Windows.Forms.Label();
            this.lblResultNbBateauxFrets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleNbBateauxFrets
            // 
            this.lblTitleNbBateauxFrets.AutoSize = true;
            this.lblTitleNbBateauxFrets.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNbBateauxFrets.Location = new System.Drawing.Point(61, 198);
            this.lblTitleNbBateauxFrets.Name = "lblTitleNbBateauxFrets";
            this.lblTitleNbBateauxFrets.Size = new System.Drawing.Size(263, 24);
            this.lblTitleNbBateauxFrets.TabIndex = 0;
            this.lblTitleNbBateauxFrets.Text = "Nombres Bateaux Frêts :";
            this.lblTitleNbBateauxFrets.Click += new System.EventHandler(this.lblTitleNbBateauxFrets_Click);
            // 
            // lblResultNbBateauxFrets
            // 
            this.lblResultNbBateauxFrets.AutoSize = true;
            this.lblResultNbBateauxFrets.Location = new System.Drawing.Point(361, 199);
            this.lblResultNbBateauxFrets.Name = "lblResultNbBateauxFrets";
            this.lblResultNbBateauxFrets.Size = new System.Drawing.Size(0, 25);
            this.lblResultNbBateauxFrets.TabIndex = 1;
            // 
            // NbBateauxFrets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultNbBateauxFrets);
            this.Controls.Add(this.lblTitleNbBateauxFrets);
            this.Name = "NbBateauxFrets";
            this.Text = "NbBateauxFrets";
            this.Load += new System.EventHandler(this.NbBateauxFrets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleNbBateauxFrets;
        private Label lblResultNbBateauxFrets;
    }
}