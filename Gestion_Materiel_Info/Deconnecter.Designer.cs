﻿namespace Gestion_Materiel_Info
{
    partial class Deconnecter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.non = new System.Windows.Forms.Button();
            this.oui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.non);
            this.panel1.Controls.Add(this.oui);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 120);
            this.panel1.TabIndex = 0;
            // 
            // non
            // 
            this.non.BackColor = System.Drawing.Color.White;
            this.non.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.ForeColor = System.Drawing.Color.Black;
            this.non.Location = new System.Drawing.Point(159, 77);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(75, 23);
            this.non.TabIndex = 2;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = false;
            this.non.Click += new System.EventHandler(this.non_Click);
            // 
            // oui
            // 
            this.oui.BackColor = System.Drawing.Color.White;
            this.oui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oui.ForeColor = System.Drawing.Color.Black;
            this.oui.Location = new System.Drawing.Point(57, 77);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(75, 23);
            this.oui.TabIndex = 1;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = false;
            this.oui.Click += new System.EventHandler(this.oui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vous voulez deconnecter vraiment ?";
            // 
            // Deconnecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 120);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deconnecter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deconnecter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button non;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Label label1;
    }
}