namespace Gestion_Materiel_Info
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.close = new System.Windows.Forms.PictureBox();
            this.nomUser = new System.Windows.Forms.TextBox();
            this.passUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeConnecter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.incorrecteNom = new System.Windows.Forms.Label();
            this.IncorrectPass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(477, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 19);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // nomUser
            // 
            this.nomUser.Location = new System.Drawing.Point(242, 188);
            this.nomUser.Multiline = true;
            this.nomUser.Name = "nomUser";
            this.nomUser.Size = new System.Drawing.Size(213, 31);
            this.nomUser.TabIndex = 2;
            // 
            // passUser
            // 
            this.passUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passUser.Location = new System.Drawing.Point(242, 254);
            this.passUser.Multiline = true;
            this.passUser.Name = "passUser";
            this.passUser.PasswordChar = '*';
            this.passUser.Size = new System.Drawing.Size(213, 31);
            this.passUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(239, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(240, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe";
            // 
            // SeConnecter
            // 
            this.SeConnecter.AutoEllipsis = true;
            this.SeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.SeConnecter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SeConnecter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SeConnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SeConnecter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeConnecter.ForeColor = System.Drawing.Color.White;
            this.SeConnecter.Location = new System.Drawing.Point(346, 328);
            this.SeConnecter.Name = "SeConnecter";
            this.SeConnecter.Size = new System.Drawing.Size(109, 30);
            this.SeConnecter.TabIndex = 6;
            this.SeConnecter.Text = "Se connecter";
            this.SeConnecter.UseVisualStyleBackColor = false;
            this.SeConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // incorrecteNom
            // 
            this.incorrecteNom.AutoSize = true;
            this.incorrecteNom.BackColor = System.Drawing.Color.White;
            this.incorrecteNom.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.incorrecteNom.ForeColor = System.Drawing.Color.Red;
            this.incorrecteNom.Location = new System.Drawing.Point(278, 222);
            this.incorrecteNom.Name = "incorrecteNom";
            this.incorrecteNom.Size = new System.Drawing.Size(177, 14);
            this.incorrecteNom.TabIndex = 8;
            this.incorrecteNom.Text = "*nom de l\'utilisateur incorrect !";
            this.incorrecteNom.Visible = false;
            // 
            // IncorrectPass
            // 
            this.IncorrectPass.AutoSize = true;
            this.IncorrectPass.BackColor = System.Drawing.Color.White;
            this.IncorrectPass.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.IncorrectPass.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPass.Location = new System.Drawing.Point(316, 289);
            this.IncorrectPass.Name = "IncorrectPass";
            this.IncorrectPass.Size = new System.Drawing.Size(139, 14);
            this.IncorrectPass.TabIndex = 9;
            this.IncorrectPass.Text = "*mot de pass incorrect !";
            this.IncorrectPass.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Authentification";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 381);
            this.panel1.TabIndex = 0;
            // 
            // nouveau
            // 
            this.nouveau.AutoEllipsis = true;
            this.nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.nouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nouveau.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nouveau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.nouveau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.White;
            this.nouveau.Location = new System.Drawing.Point(242, 328);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(98, 30);
            this.nouveau.TabIndex = 10;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = false;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 379);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.close);
            this.Controls.Add(this.IncorrectPass);
            this.Controls.Add(this.incorrecteNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SeConnecter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passUser);
            this.Controls.Add(this.nomUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomUser;
        private System.Windows.Forms.TextBox passUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SeConnecter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label incorrecteNom;
        private System.Windows.Forms.Label IncorrectPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nouveau;
    }
}