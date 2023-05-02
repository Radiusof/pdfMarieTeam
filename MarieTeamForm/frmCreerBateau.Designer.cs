using System.Windows.Forms;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreerBateau));
            this.lblTitleLargueurBateau = new System.Windows.Forms.Label();
            this.lblTitleLongueurBateau = new System.Windows.Forms.Label();
            this.lblTitleNomBateau = new System.Windows.Forms.Label();
            this.lblTitleIdBateau = new System.Windows.Forms.Label();
            this.txtIdBateau = new System.Windows.Forms.TextBox();
            this.txtNameBateau = new System.Windows.Forms.TextBox();
            this.txtLongueurBateau = new System.Windows.Forms.TextBox();
            this.btnConfirmCreate = new System.Windows.Forms.Button();
            this.txtLargeurBateau = new System.Windows.Forms.TextBox();
            this.txt_vitesse = new System.Windows.Forms.TextBox();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.lbl_errorEmpty = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.lbl_ajouterImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleLargueurBateau
            // 
            this.lblTitleLargueurBateau.AutoSize = true;
            this.lblTitleLargueurBateau.Location = new System.Drawing.Point(96, 252);
            this.lblTitleLargueurBateau.Name = "lblTitleLargueurBateau";
            this.lblTitleLargueurBateau.Size = new System.Drawing.Size(148, 20);
            this.lblTitleLargueurBateau.TabIndex = 7;
            this.lblTitleLargueurBateau.Text = "Largeur du bateau :";
            // 
            // lblTitleLongueurBateau
            // 
            this.lblTitleLongueurBateau.AutoSize = true;
            this.lblTitleLongueurBateau.Location = new System.Drawing.Point(97, 213);
            this.lblTitleLongueurBateau.Name = "lblTitleLongueurBateau";
            this.lblTitleLongueurBateau.Size = new System.Drawing.Size(161, 20);
            this.lblTitleLongueurBateau.TabIndex = 6;
            this.lblTitleLongueurBateau.Text = "Longueur du bateau :";
            // 
            // lblTitleNomBateau
            // 
            this.lblTitleNomBateau.AutoSize = true;
            this.lblTitleNomBateau.Location = new System.Drawing.Point(96, 177);
            this.lblTitleNomBateau.Name = "lblTitleNomBateau";
            this.lblTitleNomBateau.Size = new System.Drawing.Size(126, 20);
            this.lblTitleNomBateau.TabIndex = 5;
            this.lblTitleNomBateau.Text = "Nom du bateau :";
            // 
            // lblTitleIdBateau
            // 
            this.lblTitleIdBateau.AutoSize = true;
            this.lblTitleIdBateau.Location = new System.Drawing.Point(97, 139);
            this.lblTitleIdBateau.Name = "lblTitleIdBateau";
            this.lblTitleIdBateau.Size = new System.Drawing.Size(110, 20);
            this.lblTitleIdBateau.TabIndex = 4;
            this.lblTitleIdBateau.Text = "ID du bateau :";
            // 
            // txtIdBateau
            // 
            this.txtIdBateau.Location = new System.Drawing.Point(265, 139);
            this.txtIdBateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdBateau.Name = "txtIdBateau";
            this.txtIdBateau.Size = new System.Drawing.Size(135, 26);
            this.txtIdBateau.TabIndex = 8;
            this.txtIdBateau.TextChanged += new System.EventHandler(this.txtIdBateau_TextChanged);
            this.txtIdBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBateau_KeyPress_1);
            this.txtIdBateau.Leave += new System.EventHandler(this.txtIdBateau_Leave);
            this.txtIdBateau.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdBateau_Validating);
            this.txtIdBateau.Validated += new System.EventHandler(this.txtIdBateau_Validated);
            // 
            // txtNameBateau
            // 
            this.txtNameBateau.Location = new System.Drawing.Point(265, 177);
            this.txtNameBateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameBateau.Name = "txtNameBateau";
            this.txtNameBateau.Size = new System.Drawing.Size(135, 26);
            this.txtNameBateau.TabIndex = 9;
            // 
            // txtLongueurBateau
            // 
            this.txtLongueurBateau.Location = new System.Drawing.Point(265, 213);
            this.txtLongueurBateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLongueurBateau.Name = "txtLongueurBateau";
            this.txtLongueurBateau.Size = new System.Drawing.Size(135, 26);
            this.txtLongueurBateau.TabIndex = 10;
            this.txtLongueurBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongueurBateau_KeyPress_1);
            // 
            // btnConfirmCreate
            // 
            this.btnConfirmCreate.Location = new System.Drawing.Point(385, 388);
            this.btnConfirmCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmCreate.Name = "btnConfirmCreate";
            this.btnConfirmCreate.Size = new System.Drawing.Size(101, 50);
            this.btnConfirmCreate.TabIndex = 12;
            this.btnConfirmCreate.Text = "Créer";
            this.btnConfirmCreate.UseVisualStyleBackColor = true;
            this.btnConfirmCreate.Click += new System.EventHandler(this.btnConfirmCreate_Click);
            // 
            // txtLargeurBateau
            // 
            this.txtLargeurBateau.Location = new System.Drawing.Point(265, 252);
            this.txtLargeurBateau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLargeurBateau.Name = "txtLargeurBateau";
            this.txtLargeurBateau.Size = new System.Drawing.Size(135, 26);
            this.txtLargeurBateau.TabIndex = 11;
            this.txtLargeurBateau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargeurBateau_KeyPress_1);
            // 
            // txt_vitesse
            // 
            this.txt_vitesse.Location = new System.Drawing.Point(266, 293);
            this.txt_vitesse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vitesse.Name = "txt_vitesse";
            this.txt_vitesse.Size = new System.Drawing.Size(135, 26);
            this.txt_vitesse.TabIndex = 15;
            this.txt_vitesse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vitesse_KeyPress);
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Location = new System.Drawing.Point(97, 293);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(146, 20);
            this.lbl_vitesse.TabIndex = 14;
            this.lbl_vitesse.Text = "Vitesse du bateau :";
            // 
            // lbl_errorEmpty
            // 
            this.lbl_errorEmpty.AutoSize = true;
            this.lbl_errorEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorEmpty.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errorEmpty.Location = new System.Drawing.Point(97, 331);
            this.lbl_errorEmpty.Name = "lbl_errorEmpty";
            this.lbl_errorEmpty.Size = new System.Drawing.Size(312, 20);
            this.lbl_errorEmpty.TabIndex = 16;
            this.lbl_errorEmpty.Text = "Veuillez remplir l\'ensemble des cases!";
            this.lbl_errorEmpty.Visible = false;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_success.Location = new System.Drawing.Point(336, 452);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(209, 22);
            this.lbl_success.TabIndex = 17;
            this.lbl_success.Text = "Nouveau bateau ajouté !";
            this.lbl_success.Visible = false;
            this.lbl_success.Click += new System.EventHandler(this.lbl_success_Click);
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picturebox.Location = new System.Drawing.Point(479, 139);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(282, 180);
            this.picturebox.TabIndex = 19;
            this.picturebox.TabStop = false;
            this.picturebox.Visible = false;
            this.picturebox.WaitOnLoad = true;
            this.picturebox.DragDrop += new System.Windows.Forms.DragEventHandler(this.picturebox_DragDrop);
            this.picturebox.DragEnter += new System.Windows.Forms.DragEventHandler(this.picturebox_DragEnter);

            // 
            // lbl_ajouterImage
            // 
            this.lbl_ajouterImage.AutoSize = true;
            this.lbl_ajouterImage.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajouterImage.Location = new System.Drawing.Point(452, 328);
            this.lbl_ajouterImage.Name = "lbl_ajouterImage";
            this.lbl_ajouterImage.Size = new System.Drawing.Size(344, 25);
            this.lbl_ajouterImage.TabIndex = 20;
            this.lbl_ajouterImage.Text = "Veuillez ajouter une photo du bateau";
            this.lbl_ajouterImage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(193, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Veuillez par commencer par indiquer l\'id du bateau!";
            // 
            // frmCreerBateau
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarieTeamForm.Properties.Resources.logo_color1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ajouterImage);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_errorEmpty);
            this.Controls.Add(this.txt_vitesse);
            this.Controls.Add(this.lbl_vitesse);
            this.Controls.Add(this.btnConfirmCreate);
            this.Controls.Add(this.txtLargeurBateau);
            this.Controls.Add(this.txtLongueurBateau);
            this.Controls.Add(this.txtNameBateau);
            this.Controls.Add(this.txtIdBateau);
            this.Controls.Add(this.lblTitleLargueurBateau);
            this.Controls.Add(this.lblTitleLongueurBateau);
            this.Controls.Add(this.lblTitleNomBateau);
            this.Controls.Add(this.lblTitleIdBateau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreerBateau";
            this.Text = "frmCreerBateau";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreerBateau_FormClosed);
            this.Load += new System.EventHandler(this.frmCreerBateau_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmCreerBateau_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmCreerBateau_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
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
        private Button btnConfirmCreate;
        private TextBox txtLargeurBateau;
        private TextBox txt_vitesse;
        private Label lbl_vitesse;
        private Label lbl_errorEmpty;
        private Label lbl_success;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox picturebox;
        private Label lbl_ajouterImage;
        private Label label1;
    }
}