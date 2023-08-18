using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Gestion_Materiel_Info
{
    public partial class Detaille : Form
    {
        private String chemin;
        Fonction Con;
        public Detaille()
        {
            InitializeComponent();
            Con = new Fonction();
            Afficher_d();
            table(ListeDetaille);
        }

        private void Afficher_d()
        {
            String Requete = "select Sortie.date_s As 'Date sortie', MAteriel.design_m As 'Designation', Materiel.marque_m AS 'Marque', Materiel.pu_m As 'Prix Unitaire', Entre.quantite_e As 'Quantite entre', Sortie.quantite_s As 'Quantite sortie', Sortie.quantite_s * Materiel.pu_m As 'Montant', Entre.quantite_e - Sortie.quantite_s As 'Quantite restant' from Materiel join Sortie on(Materiel.num_m = Sortie.num_m) join Entre on(Materiel.num_m = Entre.num_m)";
            ListeDetaille.DataSource = Con.RecupererData(Requete);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Sortie obj = new Sortie();
            obj.Show();
            this.Hide();
        }

        private void Recherche_Click(object sender, EventArgs e)
        {

            try
            {
                String date_1 = date1.Value.ToString("yyyy-MM-dd");
                String date_2 = date2.Value.ToString("yyyy-MM-dd");
                String Requete = "select Sortie.date_s As 'Date sortie', MAteriel.design_m As 'Designation', Materiel.marque_m As 'Marque', Materiel.pu_m As 'Prix Unitaire', Entre.quantite_e As 'Quantite entre', Sortie.quantite_s As 'Quantite sortie', Sortie.quantite_s * Materiel.pu_m As 'Montant', Entre.quantite_e - Sortie.quantite_s As 'Quantite restant' from Materiel join Sortie on(Materiel.num_m = Sortie.num_m) join Entre on(Materiel.num_m = Entre.num_m) where Sortie.date_s between '" + date_1 + "' and '" + date_2 + "'";
                ListeDetaille.DataSource = Con.RecupererData(Requete);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListeDetaille_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ListeDetaille.ClearSelection();
                ListeDetaille.Rows[e.RowIndex].Selected = true;
            }
            dateP.Text = ListeDetaille.CurrentRow.Cells[0].Value.ToString();
            designP.Text = ListeDetaille.CurrentRow.Cells[1].Value.ToString();
            marqueP.Text = ListeDetaille.CurrentRow.Cells[2].Value.ToString();
            puP.Text = ListeDetaille.CurrentRow.Cells[3].Value.ToString();
            quantiteInitialP.Text = ListeDetaille.CurrentRow.Cells[4].Value.ToString();
            quantiteSortieP.Text = ListeDetaille.CurrentRow.Cells[5].Value.ToString();
            montantP.Text = ListeDetaille.CurrentRow.Cells[6].Value.ToString();
            quantiteRestantP.Text = ListeDetaille.CurrentRow.Cells[7].Value.ToString();
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            if (dateP.Text == "" || designP.Text == "" || marqueP.Text == "" || puP.Text == "" || quantiteInitialP.Text == "" || quantiteSortieP.Text == "" || montantP.Text == "" || quantiteRestantP.Text == "")
            {
                MessageBox.Show("Information Incomplete");
            }
            else
            {
                String date = dateP.Value.ToString("yyyy-MM-dd");
                String design = designP.Text;
                String marque = marqueP.Text;
                String pu = puP.Text;
                String quantiteI = quantiteInitialP.Text;
                String quantiteS = quantiteSortieP.Text;
                String montant = montantP.Text;
                String quantiteR = quantiteRestantP.Text;

                Document document = new Document();
                chemin = @"D:\PROJET\L2\c#\FActure.pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(chemin, FileMode.Create));
                document.Open();
                Paragraph para0 = new Paragraph("                                                           Gestion des materiels informatique");
                Paragraph para1 = new Paragraph("   Date de sortie :............................................................................................................" + date);
                Paragraph para2 = new Paragraph("   Designation :................................................................................................................" + design);
                Paragraph para3 = new Paragraph("   Marque :......................................................................................................................." + marque);
                Paragraph para4 = new Paragraph("   Prix unitaire de cette materiel :...................................................................................." + pu);
                Paragraph para5 = new Paragraph("   Quantité initial de cette materiel :................................................................................" + quantiteI);
                Paragraph para6 = new Paragraph("   Quantité sortie :..........................................................................................................." + quantiteS);
                Paragraph para7 = new Paragraph("   Montant :....................................................................................................................."+ montant);
                Paragraph para8 = new Paragraph("   Quantité restant :........................................................................................................." + quantiteR);
                document.Add(para0);
                document.Add(para1);
                document.Add(para2);
                document.Add(para3);
                document.Add(para4);
                document.Add(para5);
                document.Add(para6);
                document.Add(para7);
                document.Add(para8);
                document.Close();
                //MessageBox.Show("pdf generer");
                Process.Start(chemin);
            }
        }

        void table(DataGridView d)
        {
            foreach (DataGridViewRow row in d.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            foreach (DataGridViewColumn column in d.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            d.RowHeadersVisible = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Detaille_Load(object sender, EventArgs e)
        {
            designP.Enabled = false;
            marqueP.Enabled = false;
            puP.Enabled = false;
            quantiteInitialP.Enabled = false;
            quantiteRestantP.Enabled = false;
            quantiteSortieP.Enabled = false;
            montantP.Enabled = false;

        }
    }
}