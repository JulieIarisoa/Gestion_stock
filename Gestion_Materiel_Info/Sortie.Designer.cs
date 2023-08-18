namespace Gestion_Materiel_Info
{
    partial class Sortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortie));
            this.quantite_s = new System.Windows.Forms.NumericUpDown();
            this.date_s = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.detaile = new System.Windows.Forms.PictureBox();
            this.detailLab = new System.Windows.Forms.Label();
            this.materiel = new System.Windows.Forms.PictureBox();
            this.SeDeconnecter = new System.Windows.Forms.Label();
            this.Deconnecter = new System.Windows.Forms.PictureBox();
            this.materiels = new System.Windows.Forms.Label();
            this.sortiep = new System.Windows.Forms.PictureBox();
            this.sortieLab = new System.Windows.Forms.Label();
            this.entreLab = new System.Windows.Forms.Label();
            this.entrer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.num_m = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Ajouter_s = new System.Windows.Forms.Button();
            this.modifier_s = new System.Windows.Forms.Button();
            this.supprimer_s = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_s = new System.Windows.Forms.TextBox();
            this.ListeSortie = new System.Windows.Forms.DataGridView();
            this.Recherche = new System.Windows.Forms.Button();
            this.date_s1 = new System.Windows.Forms.DateTimePicker();
            this.date_s2 = new System.Windows.Forms.DateTimePicker();
            this.Graphe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantite_s)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detaile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnecter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortiep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSortie)).BeginInit();
            this.SuspendLayout();
            // 
            // quantite_s
            // 
            this.quantite_s.Location = new System.Drawing.Point(14, 313);
            this.quantite_s.Name = "quantite_s";
            this.quantite_s.Size = new System.Drawing.Size(198, 20);
            this.quantite_s.TabIndex = 45;
            // 
            // date_s
            // 
            this.date_s.Location = new System.Drawing.Point(14, 167);
            this.date_s.Name = "date_s";
            this.date_s.Size = new System.Drawing.Size(198, 20);
            this.date_s.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.detaile);
            this.panel3.Controls.Add(this.detailLab);
            this.panel3.Controls.Add(this.materiel);
            this.panel3.Controls.Add(this.SeDeconnecter);
            this.panel3.Controls.Add(this.Deconnecter);
            this.panel3.Controls.Add(this.materiels);
            this.panel3.Controls.Add(this.sortiep);
            this.panel3.Controls.Add(this.sortieLab);
            this.panel3.Controls.Add(this.entreLab);
            this.panel3.Controls.Add(this.entrer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 469);
            this.panel3.TabIndex = 54;
            // 
            // detaile
            // 
            this.detaile.Image = ((System.Drawing.Image)(resources.GetObject("detaile.Image")));
            this.detaile.Location = new System.Drawing.Point(44, 165);
            this.detaile.Name = "detaile";
            this.detaile.Size = new System.Drawing.Size(26, 37);
            this.detaile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detaile.TabIndex = 22;
            this.detaile.TabStop = false;
            this.detaile.Click += new System.EventHandler(this.detaile_Click);
            // 
            // detailLab
            // 
            this.detailLab.AutoSize = true;
            this.detailLab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.detailLab.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.detailLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailLab.Location = new System.Drawing.Point(76, 184);
            this.detailLab.Name = "detailLab";
            this.detailLab.Size = new System.Drawing.Size(94, 18);
            this.detailLab.TabIndex = 21;
            this.detailLab.Text = "Detail sortie";
            this.detailLab.Click += new System.EventHandler(this.detailLab_Click);
            // 
            // materiel
            // 
            this.materiel.Image = ((System.Drawing.Image)(resources.GetObject("materiel.Image")));
            this.materiel.Location = new System.Drawing.Point(12, 33);
            this.materiel.Name = "materiel";
            this.materiel.Size = new System.Drawing.Size(44, 30);
            this.materiel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.materiel.TabIndex = 11;
            this.materiel.TabStop = false;
            this.materiel.Click += new System.EventHandler(this.materiel_Click);
            // 
            // SeDeconnecter
            // 
            this.SeDeconnecter.AutoSize = true;
            this.SeDeconnecter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SeDeconnecter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SeDeconnecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.SeDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeDeconnecter.Location = new System.Drawing.Point(50, 226);
            this.SeDeconnecter.Name = "SeDeconnecter";
            this.SeDeconnecter.Size = new System.Drawing.Size(129, 19);
            this.SeDeconnecter.TabIndex = 20;
            this.SeDeconnecter.Text = "Se deconnecter";
            this.SeDeconnecter.Click += new System.EventHandler(this.SeDeconnecter_Click);
            // 
            // Deconnecter
            // 
            this.Deconnecter.Image = ((System.Drawing.Image)(resources.GetObject("Deconnecter.Image")));
            this.Deconnecter.Location = new System.Drawing.Point(16, 209);
            this.Deconnecter.Name = "Deconnecter";
            this.Deconnecter.Size = new System.Drawing.Size(31, 36);
            this.Deconnecter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Deconnecter.TabIndex = 19;
            this.Deconnecter.TabStop = false;
            this.Deconnecter.Click += new System.EventHandler(this.Deconnecter_Click);
            // 
            // materiels
            // 
            this.materiels.AutoSize = true;
            this.materiels.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.materiels.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.materiels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.materiels.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materiels.Location = new System.Drawing.Point(53, 44);
            this.materiels.Name = "materiels";
            this.materiels.Size = new System.Drawing.Size(77, 19);
            this.materiels.TabIndex = 13;
            this.materiels.Text = "Materiels";
            this.materiels.Click += new System.EventHandler(this.materiels_Click);
            // 
            // sortiep
            // 
            this.sortiep.Image = ((System.Drawing.Image)(resources.GetObject("sortiep.Image")));
            this.sortiep.Location = new System.Drawing.Point(12, 125);
            this.sortiep.Name = "sortiep";
            this.sortiep.Size = new System.Drawing.Size(41, 37);
            this.sortiep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sortiep.TabIndex = 10;
            this.sortiep.TabStop = false;
            this.sortiep.Click += new System.EventHandler(this.sortiep_Click);
            // 
            // sortieLab
            // 
            this.sortieLab.AutoSize = true;
            this.sortieLab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sortieLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.sortieLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.sortieLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortieLab.Location = new System.Drawing.Point(53, 143);
            this.sortieLab.Name = "sortieLab";
            this.sortieLab.Size = new System.Drawing.Size(54, 19);
            this.sortieLab.TabIndex = 16;
            this.sortieLab.Text = "Sortie";
            this.sortieLab.Click += new System.EventHandler(this.sortieLab_Click);
            // 
            // entreLab
            // 
            this.entreLab.AutoSize = true;
            this.entreLab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.entreLab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.entreLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.entreLab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entreLab.Location = new System.Drawing.Point(57, 91);
            this.entreLab.Name = "entreLab";
            this.entreLab.Size = new System.Drawing.Size(50, 19);
            this.entreLab.TabIndex = 17;
            this.entreLab.Text = "Entre";
            this.entreLab.Click += new System.EventHandler(this.entreLab_Click);
            // 
            // entrer
            // 
            this.entrer.Image = ((System.Drawing.Image)(resources.GetObject("entrer.Image")));
            this.entrer.Location = new System.Drawing.Point(12, 71);
            this.entrer.Name = "entrer";
            this.entrer.Size = new System.Drawing.Size(41, 39);
            this.entrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.entrer.TabIndex = 8;
            this.entrer.TabStop = false;
            this.entrer.Click += new System.EventHandler(this.entrer_Click);
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
            this.panel1.TabIndex = 52;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1030, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 40);
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
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu pour les sorties";
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
            this.panel2.TabIndex = 53;
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
            // num_m
            // 
            this.num_m.Location = new System.Drawing.Point(14, 239);
            this.num_m.Name = "num_m";
            this.num_m.Size = new System.Drawing.Size(198, 20);
            this.num_m.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.quantite_s);
            this.panel4.Controls.Add(this.num_m);
            this.panel4.Controls.Add(this.date_s);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Ajouter_s);
            this.panel4.Controls.Add(this.modifier_s);
            this.panel4.Controls.Add(this.supprimer_s);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.num_s);
            this.panel4.Location = new System.Drawing.Point(810, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 469);
            this.panel4.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Formulaire";
            // 
            // Ajouter_s
            // 
            this.Ajouter_s.AutoEllipsis = true;
            this.Ajouter_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.Ajouter_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ajouter_s.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ajouter_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Ajouter_s.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_s.ForeColor = System.Drawing.Color.White;
            this.Ajouter_s.Location = new System.Drawing.Point(14, 386);
            this.Ajouter_s.Name = "Ajouter_s";
            this.Ajouter_s.Size = new System.Drawing.Size(105, 30);
            this.Ajouter_s.TabIndex = 41;
            this.Ajouter_s.Text = "Ajouter";
            this.Ajouter_s.UseVisualStyleBackColor = false;
            this.Ajouter_s.Click += new System.EventHandler(this.Ajouter_s_Click);
            // 
            // modifier_s
            // 
            this.modifier_s.AutoEllipsis = true;
            this.modifier_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.modifier_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modifier_s.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.modifier_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.modifier_s.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_s.ForeColor = System.Drawing.Color.White;
            this.modifier_s.Location = new System.Drawing.Point(153, 386);
            this.modifier_s.Name = "modifier_s";
            this.modifier_s.Size = new System.Drawing.Size(105, 30);
            this.modifier_s.TabIndex = 40;
            this.modifier_s.Text = "Modifier";
            this.modifier_s.UseVisualStyleBackColor = false;
            this.modifier_s.Click += new System.EventHandler(this.modifier_s_Click);
            // 
            // supprimer_s
            // 
            this.supprimer_s.AutoEllipsis = true;
            this.supprimer_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.supprimer_s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.supprimer_s.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.supprimer_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.supprimer_s.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_s.ForeColor = System.Drawing.Color.White;
            this.supprimer_s.Location = new System.Drawing.Point(92, 422);
            this.supprimer_s.Name = "supprimer_s";
            this.supprimer_s.Size = new System.Drawing.Size(105, 30);
            this.supprimer_s.TabIndex = 39;
            this.supprimer_s.Text = "Supprimer";
            this.supprimer_s.UseVisualStyleBackColor = false;
            this.supprimer_s.Click += new System.EventHandler(this.supprimer_s_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(11, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quantité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(11, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "N° materiel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "N° sortie";
            // 
            // num_s
            // 
            this.num_s.Location = new System.Drawing.Point(14, 103);
            this.num_s.Name = "num_s";
            this.num_s.Size = new System.Drawing.Size(198, 20);
            this.num_s.TabIndex = 29;
            // 
            // ListeSortie
            // 
            this.ListeSortie.BackgroundColor = System.Drawing.Color.White;
            this.ListeSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeSortie.Location = new System.Drawing.Point(191, 143);
            this.ListeSortie.Name = "ListeSortie";
            this.ListeSortie.Size = new System.Drawing.Size(613, 383);
            this.ListeSortie.TabIndex = 55;
            this.ListeSortie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeSortie_CellClick);
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
            this.Recherche.Location = new System.Drawing.Point(567, 102);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(105, 30);
            this.Recherche.TabIndex = 58;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = false;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // date_s1
            // 
            this.date_s1.Location = new System.Drawing.Point(191, 105);
            this.date_s1.Name = "date_s1";
            this.date_s1.Size = new System.Drawing.Size(180, 20);
            this.date_s1.TabIndex = 59;
            // 
            // date_s2
            // 
            this.date_s2.Location = new System.Drawing.Point(377, 107);
            this.date_s2.Name = "date_s2";
            this.date_s2.Size = new System.Drawing.Size(184, 20);
            this.date_s2.TabIndex = 60;
            // 
            // Graphe
            // 
            this.Graphe.AutoEllipsis = true;
            this.Graphe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.Graphe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Graphe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Graphe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Graphe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphe.ForeColor = System.Drawing.Color.White;
            this.Graphe.Location = new System.Drawing.Point(687, 102);
            this.Graphe.Name = "Graphe";
            this.Graphe.Size = new System.Drawing.Size(105, 30);
            this.Graphe.TabIndex = 61;
            this.Graphe.Text = "Graphe";
            this.Graphe.UseVisualStyleBackColor = false;
            this.Graphe.Click += new System.EventHandler(this.Graphe_Click);
            // 
            // Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 602);
            this.Controls.Add(this.Graphe);
            this.Controls.Add(this.date_s2);
            this.Controls.Add(this.date_s1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ListeSortie);
            this.Controls.Add(this.Recherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortie";
            this.Load += new System.EventHandler(this.Sortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantite_s)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detaile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnecter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortiep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSortie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown quantite_s;
        private System.Windows.Forms.DateTimePicker date_s;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox materiel;
        private System.Windows.Forms.Label SeDeconnecter;
        private System.Windows.Forms.PictureBox Deconnecter;
        private System.Windows.Forms.Label materiels;
        private System.Windows.Forms.PictureBox sortiep;
        private System.Windows.Forms.Label sortieLab;
        private System.Windows.Forms.Label entreLab;
        private System.Windows.Forms.PictureBox entrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox num_m;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ajouter_s;
        private System.Windows.Forms.Button modifier_s;
        private System.Windows.Forms.Button supprimer_s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_s;
        private System.Windows.Forms.DataGridView ListeSortie;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.DateTimePicker date_s1;
        private System.Windows.Forms.DateTimePicker date_s2;
        private System.Windows.Forms.PictureBox detaile;
        private System.Windows.Forms.Label detailLab;
        private System.Windows.Forms.Button Graphe;
    }
}