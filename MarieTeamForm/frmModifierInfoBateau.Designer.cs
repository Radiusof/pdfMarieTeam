using System.Windows.Forms;

namespace WinFormsAppAtlantic
{
    partial class frmModifierInfoBateau
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
            this.lbl_successUpdate = new System.Windows.Forms.Label();
            this.lbl_errorEmptyUpdate = new System.Windows.Forms.Label();
            this.txt_vitesseUpdate = new System.Windows.Forms.TextBox();
            this.lbl_vitesseUpdate = new System.Windows.Forms.Label();
            this.btnConfirmCreateUpdate = new System.Windows.Forms.Button();
            this.txtLargeurBateauUpdate = new System.Windows.Forms.TextBox();
            this.txtLongueurBateauUpdate = new System.Windows.Forms.TextBox();
            this.txtNameBateauUpdate = new System.Windows.Forms.TextBox();
            this.lblTitleLargueurBateauUpdate = new System.Windows.Forms.Label();
            this.lblTitleLongueurBateauUpdate = new System.Windows.Forms.Label();
            this.lblTitleNomBateauUpdate = new System.Windows.Forms.Label();
            this.lblTitleIdBateauUpdate = new System.Windows.Forms.Label();
            this.lbl_idActuel = new System.Windows.Forms.Label();
            this.lbl_libelleActuel = new System.Windows.Forms.Label();
            this.lbl_longueurActuel = new System.Windows.Forms.Label();
            this.lbl_largeurActuel = new System.Windows.Forms.Label();
            this.lbl_vitesseActuel = new System.Windows.Forms.Label();
            this.lbl_columnValeurUpdate = new System.Windows.Forms.Label();
            this.lbl_newValeurUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_successUpdate
            // 
            this.lbl_successUpdate.AutoSize = true;
            this.lbl_successUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_successUpdate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_successUpdate.Location = new System.Drawing.Point(607, 224);
            this.lbl_successUpdate.Name = "lbl_successUpdate";
            this.lbl_successUpdate.Size = new System.Drawing.Size(211, 22);
            this.lbl_successUpdate.TabIndex = 30;
            this.lbl_successUpdate.Text = "Informations Modifiées !";
            this.lbl_successUpdate.Visible = false;
            // 
            // lbl_errorEmptyUpdate
            // 
            this.lbl_errorEmptyUpdate.AutoSize = true;
            this.lbl_errorEmptyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorEmptyUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errorEmptyUpdate.Location = new System.Drawing.Point(269, 313);
            this.lbl_errorEmptyUpdate.Name = "lbl_errorEmptyUpdate";
            this.lbl_errorEmptyUpdate.Size = new System.Drawing.Size(347, 20);
            this.lbl_errorEmptyUpdate.TabIndex = 29;
            this.lbl_errorEmptyUpdate.Text = "Veuillez remplir au moins l\'une des cases !";
            this.lbl_errorEmptyUpdate.Visible = false;
            // 
            // txt_vitesseUpdate
            // 
            this.txt_vitesseUpdate.Location = new System.Drawing.Point(448, 267);
            this.txt_vitesseUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vitesseUpdate.Name = "txt_vitesseUpdate";
            this.txt_vitesseUpdate.Size = new System.Drawing.Size(135, 26);
            this.txt_vitesseUpdate.TabIndex = 28;
            // 
            // lbl_vitesseUpdate
            // 
            this.lbl_vitesseUpdate.AutoSize = true;
            this.lbl_vitesseUpdate.Location = new System.Drawing.Point(91, 273);
            this.lbl_vitesseUpdate.Name = "lbl_vitesseUpdate";
            this.lbl_vitesseUpdate.Size = new System.Drawing.Size(146, 20);
            this.lbl_vitesseUpdate.TabIndex = 27;
            this.lbl_vitesseUpdate.Text = "Vitesse du bateau :";
            // 
            // btnConfirmCreateUpdate
            // 
            this.btnConfirmCreateUpdate.Location = new System.Drawing.Point(664, 163);
            this.btnConfirmCreateUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmCreateUpdate.Name = "btnConfirmCreateUpdate";
            this.btnConfirmCreateUpdate.Size = new System.Drawing.Size(101, 50);
            this.btnConfirmCreateUpdate.TabIndex = 26;
            this.btnConfirmCreateUpdate.Text = "Modifier !";
            this.btnConfirmCreateUpdate.UseVisualStyleBackColor = true;
            this.btnConfirmCreateUpdate.Click += new System.EventHandler(this.btnConfirmCreate_Click);
            // 
            // txtLargeurBateauUpdate
            // 
            this.txtLargeurBateauUpdate.Location = new System.Drawing.Point(447, 226);
            this.txtLargeurBateauUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLargeurBateauUpdate.Name = "txtLargeurBateauUpdate";
            this.txtLargeurBateauUpdate.Size = new System.Drawing.Size(135, 26);
            this.txtLargeurBateauUpdate.TabIndex = 25;
            // 
            // txtLongueurBateauUpdate
            // 
            this.txtLongueurBateauUpdate.Location = new System.Drawing.Point(447, 187);
            this.txtLongueurBateauUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLongueurBateauUpdate.Name = "txtLongueurBateauUpdate";
            this.txtLongueurBateauUpdate.Size = new System.Drawing.Size(135, 26);
            this.txtLongueurBateauUpdate.TabIndex = 24;
            // 
            // txtNameBateauUpdate
            // 
            this.txtNameBateauUpdate.Location = new System.Drawing.Point(447, 151);
            this.txtNameBateauUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameBateauUpdate.Name = "txtNameBateauUpdate";
            this.txtNameBateauUpdate.Size = new System.Drawing.Size(135, 26);
            this.txtNameBateauUpdate.TabIndex = 23;
            // 
            // lblTitleLargueurBateauUpdate
            // 
            this.lblTitleLargueurBateauUpdate.AutoSize = true;
            this.lblTitleLargueurBateauUpdate.Location = new System.Drawing.Point(90, 232);
            this.lblTitleLargueurBateauUpdate.Name = "lblTitleLargueurBateauUpdate";
            this.lblTitleLargueurBateauUpdate.Size = new System.Drawing.Size(148, 20);
            this.lblTitleLargueurBateauUpdate.TabIndex = 21;
            this.lblTitleLargueurBateauUpdate.Text = "Largeur du bateau :";
            // 
            // lblTitleLongueurBateauUpdate
            // 
            this.lblTitleLongueurBateauUpdate.AutoSize = true;
            this.lblTitleLongueurBateauUpdate.Location = new System.Drawing.Point(91, 193);
            this.lblTitleLongueurBateauUpdate.Name = "lblTitleLongueurBateauUpdate";
            this.lblTitleLongueurBateauUpdate.Size = new System.Drawing.Size(161, 20);
            this.lblTitleLongueurBateauUpdate.TabIndex = 20;
            this.lblTitleLongueurBateauUpdate.Text = "Longueur du bateau :";
            // 
            // lblTitleNomBateauUpdate
            // 
            this.lblTitleNomBateauUpdate.AutoSize = true;
            this.lblTitleNomBateauUpdate.Location = new System.Drawing.Point(90, 157);
            this.lblTitleNomBateauUpdate.Name = "lblTitleNomBateauUpdate";
            this.lblTitleNomBateauUpdate.Size = new System.Drawing.Size(126, 20);
            this.lblTitleNomBateauUpdate.TabIndex = 19;
            this.lblTitleNomBateauUpdate.Text = "Nom du bateau :";
            // 
            // lblTitleIdBateauUpdate
            // 
            this.lblTitleIdBateauUpdate.AutoSize = true;
            this.lblTitleIdBateauUpdate.Location = new System.Drawing.Point(91, 119);
            this.lblTitleIdBateauUpdate.Name = "lblTitleIdBateauUpdate";
            this.lblTitleIdBateauUpdate.Size = new System.Drawing.Size(110, 20);
            this.lblTitleIdBateauUpdate.TabIndex = 18;
            this.lblTitleIdBateauUpdate.Text = "ID du bateau :";
            // 
            // lbl_idActuel
            // 
            this.lbl_idActuel.AutoSize = true;
            this.lbl_idActuel.Location = new System.Drawing.Point(269, 119);
            this.lbl_idActuel.Name = "lbl_idActuel";
            this.lbl_idActuel.Size = new System.Drawing.Size(0, 30);
            this.lbl_idActuel.TabIndex = 31;
            // 
            // lbl_libelleActuel
            // 
            this.lbl_libelleActuel.AutoSize = true;
            this.lbl_libelleActuel.Location = new System.Drawing.Point(269, 157);
            this.lbl_libelleActuel.Name = "lbl_libelleActuel";
            this.lbl_libelleActuel.Size = new System.Drawing.Size(0, 20);
            this.lbl_libelleActuel.TabIndex = 32;
            // 
            // lbl_longueurActuel
            // 
            this.lbl_longueurActuel.AutoSize = true;
            this.lbl_longueurActuel.Location = new System.Drawing.Point(269, 193);
            this.lbl_longueurActuel.Name = "lbl_longueurActuel";
            this.lbl_longueurActuel.Size = new System.Drawing.Size(0, 20);
            this.lbl_longueurActuel.TabIndex = 33;
            // 
            // lbl_largeurActuel
            // 
            this.lbl_largeurActuel.AutoSize = true;
            this.lbl_largeurActuel.Location = new System.Drawing.Point(269, 230);
            this.lbl_largeurActuel.Name = "lbl_largeurActuel";
            this.lbl_largeurActuel.Size = new System.Drawing.Size(0, 30);
            this.lbl_largeurActuel.TabIndex = 34;
            // 
            // lbl_vitesseActuel
            // 
            this.lbl_vitesseActuel.AutoSize = true;
            this.lbl_vitesseActuel.Location = new System.Drawing.Point(269, 273);
            this.lbl_vitesseActuel.Name = "lbl_vitesseActuel";
            this.lbl_vitesseActuel.Size = new System.Drawing.Size(0, 20);
            this.lbl_vitesseActuel.TabIndex = 35;
            // 
            // lbl_columnValeurUpdate
            // 
            this.lbl_columnValeurUpdate.AutoSize = true;
            this.lbl_columnValeurUpdate.Location = new System.Drawing.Point(269, 86);
            this.lbl_columnValeurUpdate.Name = "lbl_columnValeurUpdate";
            this.lbl_columnValeurUpdate.Size = new System.Drawing.Size(59, 20);
            this.lbl_columnValeurUpdate.TabIndex = 36;
            this.lbl_columnValeurUpdate.Text = "Valeur ";
            // 
            // lbl_newValeurUpdate
            // 
            this.lbl_newValeurUpdate.AutoSize = true;
            this.lbl_newValeurUpdate.Location = new System.Drawing.Point(458, 80);
            this.lbl_newValeurUpdate.Name = "lbl_newValeurUpdate";
            this.lbl_newValeurUpdate.Size = new System.Drawing.Size(115, 20);
            this.lbl_newValeurUpdate.TabIndex = 37;
            this.lbl_newValeurUpdate.Text = "Nouvelle valeur";
            // 
            // frmModifierInfoBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarieTeamForm.Properties.Resources.logo_color1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_newValeurUpdate);
            this.Controls.Add(this.lbl_columnValeurUpdate);
            this.Controls.Add(this.lbl_vitesseActuel);
            this.Controls.Add(this.lbl_largeurActuel);
            this.Controls.Add(this.lbl_longueurActuel);
            this.Controls.Add(this.lbl_libelleActuel);
            this.Controls.Add(this.lbl_idActuel);
            this.Controls.Add(this.lbl_successUpdate);
            this.Controls.Add(this.lbl_errorEmptyUpdate);
            this.Controls.Add(this.txt_vitesseUpdate);
            this.Controls.Add(this.lbl_vitesseUpdate);
            this.Controls.Add(this.btnConfirmCreateUpdate);
            this.Controls.Add(this.txtLargeurBateauUpdate);
            this.Controls.Add(this.txtLongueurBateauUpdate);
            this.Controls.Add(this.txtNameBateauUpdate);
            this.Controls.Add(this.lblTitleLargueurBateauUpdate);
            this.Controls.Add(this.lblTitleLongueurBateauUpdate);
            this.Controls.Add(this.lblTitleNomBateauUpdate);
            this.Controls.Add(this.lblTitleIdBateauUpdate);
            this.Name = "frmModifierInfoBateau";
            this.Text = "ModifierInfoBateau";
            this.Load += new System.EventHandler(this.frmModifierInfoBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_successUpdate;
        private Label lbl_errorEmptyUpdate;
        private TextBox txt_vitesseUpdate;
        private Label lbl_vitesseUpdate;
        private Button btnConfirmCreateUpdate;
        private TextBox txtLargeurBateauUpdate;
        private TextBox txtLongueurBateauUpdate;
        private TextBox txtNameBateauUpdate;
        private Label lblTitleLargueurBateauUpdate;
        private Label lblTitleLongueurBateauUpdate;
        private Label lblTitleNomBateauUpdate;
        private Label lblTitleIdBateauUpdate;
        private Label lbl_idActuel;
        private Label lbl_libelleActuel;
        private Label lbl_longueurActuel;
        private Label lbl_largeurActuel;
        private Label lbl_vitesseActuel;
        private Label lbl_columnValeurUpdate;
        private Label lbl_newValeurUpdate;
    }
}