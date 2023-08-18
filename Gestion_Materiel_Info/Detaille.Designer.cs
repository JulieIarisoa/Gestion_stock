namespace Gestion_Materiel_Info
{
    partial class Detaille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detaille));
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.Recherche = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantiteRestantP = new System.Windows.Forms.TextBox();
            this.dateP = new System.Windows.Forms.DateTimePicker();
            this.quantiteSortieP = new System.Windows.Forms.TextBox();
            this.designP = new System.Windows.Forms.TextBox();
            this.puP = new System.Windows.Forms.TextBox();
            this.montantP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantiteInitialP = new System.Windows.Forms.TextBox();
            this.marqueP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListeDetaille = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDetaille)).BeginInit();
            this.SuspendLayout();
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(280, 115);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(212, 20);
            this.date2.TabIndex = 68;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(12, 112);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(218, 20);
            this.date1.TabIndex = 67;
            // 
            // Recherche
            // 
            this.Recherche.AutoEllipsis = true;
            this.Recherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.Recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Recherche.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Recherche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Recherche.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recherche.ForeColor = System.Drawing.Color.White;
            this.Recherche.Location = new System.Drawing.Point(582, 109);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(105, 30);
            this.Recherche.TabIndex = 66;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = false;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Formulaire";
            // 
            // pdf
            // 
            this.pdf.AutoEllipsis = true;
            this.pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pdf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.pdf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf.ForeColor = System.Drawing.Color.White;
            this.pdf.Location = new System.Drawing.Point(109, 433);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(105, 30);
            this.pdf.TabIndex = 41;
            this.pdf.Text = "Pdf";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(15, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Design";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date sortie";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.quantiteRestantP);
            this.panel4.Controls.Add(this.dateP);
            this.panel4.Controls.Add(this.quantiteSortieP);
            this.panel4.Controls.Add(this.designP);
            this.panel4.Controls.Add(this.puP);
            this.panel4.Controls.Add(this.montantP);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.quantiteInitialP);
            this.panel4.Controls.Add(this.marqueP);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pdf);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(810, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 469);
            this.panel4.TabIndex = 65;
            // 
            // quantiteRestantP
            // 
            this.quantiteRestantP.Location = new System.Drawing.Point(18, 407);
            this.quantiteRestantP.Name = "quantiteRestantP";
            this.quantiteRestantP.Size = new System.Drawing.Size(198, 20);
            this.quantiteRestantP.TabIndex = 70;
            // 
            // dateP
            // 
            this.dateP.Location = new System.Drawing.Point(16, 54);
            this.dateP.Name = "dateP";
            this.dateP.Size = new System.Drawing.Size(200, 20);
            this.dateP.TabIndex = 69;
            // 
            // quantiteSortieP
            // 
            this.quantiteSortieP.Location = new System.Drawing.Point(18, 303);
            this.quantiteSortieP.Name = "quantiteSortieP";
            this.quantiteSortieP.Size = new System.Drawing.Size(198, 20);
            this.quantiteSortieP.TabIndex = 55;
            // 
            // designP
            // 
            this.designP.Location = new System.Drawing.Point(16, 99);
            this.designP.Name = "designP";
            this.designP.Size = new System.Drawing.Size(198, 20);
            this.designP.TabIndex = 54;
            // 
            // puP
            // 
            this.puP.Location = new System.Drawing.Point(16, 208);
            this.puP.Name = "puP";
            this.puP.Size = new System.Drawing.Size(198, 20);
            this.puP.TabIndex = 53;
            // 
            // montantP
            // 
            this.montantP.Location = new System.Drawing.Point(16, 359);
            this.montantP.Name = "montantP";
            this.montantP.Size = new System.Drawing.Size(198, 20);
            this.montantP.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(15, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quantité restant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(15, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Quantité sortie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(13, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Montant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(15, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Quantité initial";
            // 
            // quantiteInitialP
            // 
            this.quantiteInitialP.Location = new System.Drawing.Point(18, 256);
            this.quantiteInitialP.Name = "quantiteInitialP";
            this.quantiteInitialP.Size = new System.Drawing.Size(198, 20);
            this.quantiteInitialP.TabIndex = 46;
            // 
            // marqueP
            // 
            this.marqueP.Location = new System.Drawing.Point(16, 156);
            this.marqueP.Name = "marqueP";
            this.marqueP.Size = new System.Drawing.Size(198, 20);
            this.marqueP.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(332, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Développement d\'application avec c#";
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(12, 19);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 28);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 21;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail sortie";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 74);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 59);
            this.panel2.TabIndex = 62;
            // 
            // ListeDetaille
            // 
            this.ListeDetaille.BackgroundColor = System.Drawing.Color.White;
            this.ListeDetaille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeDetaille.Location = new System.Drawing.Point(12, 154);
            this.ListeDetaille.Name = "ListeDetaille";
            this.ListeDetaille.Size = new System.Drawing.Size(779, 383);
            this.ListeDetaille.TabIndex = 64;
            this.ListeDetaille.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeDetaille_CellClick);
            // 
            // Detaille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 602);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ListeDetaille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detaille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detaille";
            this.Load += new System.EventHandler(this.Detaille_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDetaille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox marqueP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListeDetaille;
        private System.Windows.Forms.DateTimePicker dateP;
        private System.Windows.Forms.TextBox quantiteSortieP;
        private System.Windows.Forms.TextBox designP;
        private System.Windows.Forms.TextBox puP;
        private System.Windows.Forms.TextBox montantP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantiteInitialP;
        private System.Windows.Forms.TextBox quantiteRestantP;
    }
}