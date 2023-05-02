using System.Windows.Forms;
namespace WinFormsAppAtlantic
{
    partial class frmSupprimerBateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupprimerBateau));
            this.lbl_titleSelectBoat = new System.Windows.Forms.Label();
            this.lbl_selectBoat = new System.Windows.Forms.Label();
            this.lbl_errorEmpty = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titleSelectBoat
            // 
            this.lbl_titleSelectBoat.AutoSize = true;
            this.lbl_titleSelectBoat.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleSelectBoat.Location = new System.Drawing.Point(51, 61);
            this.lbl_titleSelectBoat.Name = "lbl_titleSelectBoat";
            this.lbl_titleSelectBoat.Size = new System.Drawing.Size(280, 22);
            this.lbl_titleSelectBoat.TabIndex = 0;
            this.lbl_titleSelectBoat.Text = "Bateau actuellement sélectionné :";
            // 
            // lbl_selectBoat
            // 
            this.lbl_selectBoat.AutoSize = true;
            this.lbl_selectBoat.Location = new System.Drawing.Point(348, 61);
            this.lbl_selectBoat.Name = "lbl_selectBoat";
            this.lbl_selectBoat.Size = new System.Drawing.Size(0, 30);
            this.lbl_selectBoat.TabIndex = 1;
            // 
            // lbl_errorEmpty
            // 
            this.lbl_errorEmpty.AutoSize = true;
            this.lbl_errorEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorEmpty.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errorEmpty.Location = new System.Drawing.Point(50, 112);
            this.lbl_errorEmpty.Name = "lbl_errorEmpty";
            this.lbl_errorEmpty.Size = new System.Drawing.Size(393, 50);
            this.lbl_errorEmpty.TabIndex = 2;
            this.lbl_errorEmpty.Text = "Veuillez dabord sélectionner un bateau \r\navant de vouloir le supprimer !";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(138, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 94);
            this.button1.TabIndex = 3;
            this.button1.Text = "Supprimer ce bateau \r\nde la base de données ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSupprimerBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarieTeamForm.Properties.Resources.logo_color1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_errorEmpty);
            this.Controls.Add(this.lbl_selectBoat);
            this.Controls.Add(this.lbl_titleSelectBoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupprimerBateau";
            this.Text = "SupprimerBateau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSupprimerBateau_FormClosed);
            this.Load += new System.EventHandler(this.frmSupprimerBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_titleSelectBoat;
        private Label lbl_selectBoat;
        private Label lbl_errorEmpty;
        private Button button1;
    }
}