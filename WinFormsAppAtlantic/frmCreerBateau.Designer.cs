namespace WinFormsAppAtlantic
{
    partial class frmCreerBateau
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
            this.lblTitleLargueurBateau = new System.Windows.Forms.Label();
            this.lblTitleLongueurBateau = new System.Windows.Forms.Label();
            this.lblTitleNomBateau = new System.Windows.Forms.Label();
            this.lblTitleIdBateau = new System.Windows.Forms.Label();
            this.txtIdBateau = new System.Windows.Forms.TextBox();
            this.txtNameBateau = new System.Windows.Forms.TextBox();
            this.txtLongueurBateau = new System.Windows.Forms.TextBox();
            this.txtLargeurBateau = new System.Windows.Forms.TextBox();
            this.btnConfirmCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleLargueurBateau
            // 
            this.lblTitleLargueurBateau.AutoSize = true;
            this.lblTitleLargueurBateau.Location = new System.Drawing.Point(42, 234);
            this.lblTitleLargueurBateau.Name = "lblTitleLargueurBateau";
            this.lblTitleLargueurBateau.Size = new System.Drawing.Size(165, 25);
            this.lblTitleLargueurBateau.TabIndex = 7;
            this.lblTitleLargueurBateau.Text = "Largeur du bateau :";
            // 
            // lblTitleLongueurBateau
            // 
            this.lblTitleLongueurBateau.AutoSize = true;
            this.lblTitleLongueurBateau.Location = new System.Drawing.Point(43, 185);
            this.lblTitleLongueurBateau.Name = "lblTitleLongueurBateau";
            this.lblTitleLongueurBateau.Size = new System.Drawing.Size(181, 25);
            this.lblTitleLongueurBateau.TabIndex = 6;
            this.lblTitleLongueurBateau.Text = "Longueur du bateau :";
            // 
            // lblTitleNomBateau
            // 
            this.lblTitleNomBateau.AutoSize = true;
            this.lblTitleNomBateau.Location = new System.Drawing.Point(42, 140);
            this.lblTitleNomBateau.Name = "lblTitleNomBateau";
            this.lblTitleNomBateau.Size = new System.Drawing.Size(146, 25);
            this.lblTitleNomBateau.TabIndex = 5;
            this.lblTitleNomBateau.Text = "Nom du bateau :";
            // 
            // lblTitleIdBateau
            // 
            this.lblTitleIdBateau.AutoSize = true;
            this.lblTitleIdBateau.Location = new System.Drawing.Point(43, 92);
            this.lblTitleIdBateau.Name = "lblTitleIdBateau";
            this.lblTitleIdBateau.Size = new System.Drawing.Size(124, 25);
            this.lblTitleIdBateau.TabIndex = 4;
            this.lblTitleIdBateau.Text = "ID du bateau :";
            // 
            // txtIdBateau
            // 
            this.txtIdBateau.Location = new System.Drawing.Point(230, 92);
            this.txtIdBateau.Name = "txtIdBateau";
            this.txtIdBateau.Size = new System.Drawing.Size(150, 31);
            this.txtIdBateau.TabIndex = 8;
            this.txtIdBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBateau_KeyPress_1);
            // 
            // txtNameBateau
            // 
            this.txtNameBateau.Location = new System.Drawing.Point(230, 140);
            this.txtNameBateau.Name = "txtNameBateau";
            this.txtNameBateau.Size = new System.Drawing.Size(150, 31);
            this.txtNameBateau.TabIndex = 9;
            this.txtNameBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameBateau_KeyPress_1);
            // 
            // txtLongueurBateau
            // 
            this.txtLongueurBateau.Location = new System.Drawing.Point(230, 185);
            this.txtLongueurBateau.Name = "txtLongueurBateau";
            this.txtLongueurBateau.Size = new System.Drawing.Size(150, 31);
            this.txtLongueurBateau.TabIndex = 10;
            this.txtLongueurBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongueurBateau_KeyPress_1);
            // 
            // txtLargeurBateau
            // 
            this.txtLargeurBateau.Location = new System.Drawing.Point(230, 234);
            this.txtLargeurBateau.Name = "txtLargeurBateau";
            this.txtLargeurBateau.Size = new System.Drawing.Size(150, 31);
            this.txtLargeurBateau.TabIndex = 11;
            this.txtLargeurBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargeurBateau_KeyPress_1);
            // 
            // btnConfirmCreate
            // 
            this.btnConfirmCreate.Location = new System.Drawing.Point(563, 155);
            this.btnConfirmCreate.Name = "btnConfirmCreate";
            this.btnConfirmCreate.Size = new System.Drawing.Size(112, 34);
            this.btnConfirmCreate.TabIndex = 12;
            this.btnConfirmCreate.Text = "Créer";
            this.btnConfirmCreate.UseVisualStyleBackColor = true;
            this.btnConfirmCreate.Click += new System.EventHandler(this.btnConfirmCreate_Click);
            // 
            // frmCreerBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmCreate);
            this.Controls.Add(this.txtLargeurBateau);
            this.Controls.Add(this.txtLongueurBateau);
            this.Controls.Add(this.txtNameBateau);
            this.Controls.Add(this.txtIdBateau);
            this.Controls.Add(this.lblTitleLargueurBateau);
            this.Controls.Add(this.lblTitleLongueurBateau);
            this.Controls.Add(this.lblTitleNomBateau);
            this.Controls.Add(this.lblTitleIdBateau);
            this.Name = "frmCreerBateau";
            this.Text = "frmCreerBateau";
            this.Load += new System.EventHandler(this.frmCreerBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleLargueurBateau;
        private Label lblTitleLongueurBateau;
        private Label lblTitleNomBateau;
        private Label lblTitleIdBateau;
        private TextBox txtIdBateau;
        private TextBox txtNameBateau;
        private TextBox txtLongueurBateau;
        private TextBox txtLargeurBateau;
        private Button btnConfirmCreate;
    }
}