using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Materiel_Info
{
    public partial class Sortie : Form
    {
        Fonction Con;
        public Sortie()
        {
            InitializeComponent();
            Con = new Fonction();
            Afficher_s();
            table(ListeSortie);
            ListeSortie.ClearSelection();
        }

        private void Afficher_s()
        {
            String Requete = "select num_s As 'Numero Sortie', date_s As 'Date Sortie', num_m As 'Numero Materiel', quantite_s As 'Quantite Sortie' from Sortie";
            ListeSortie.DataSource = Con.RecupererData(Requete);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close obj = new Close();
            obj.Show();
        }

        private void materiel_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void materiels_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void entrer_Click(object sender, EventArgs e)
        {
            Entre obj = new Entre();
            obj.Show();
            this.Hide();
        }

        private void entreLab_Click(object sender, EventArgs e)
        {
            Entre obj = new Entre();
            obj.Show();
            this.Hide();
        }

        private void sortiep_Click(object sender, EventArgs e)
        {
            Sortie obj = new Sortie();
            obj.Show();
            this.Hide();
        }

        private void sortieLab_Click(object sender, EventArgs e)
        {
            Sortie obj = new Sortie();
            obj.Show();
            this.Hide();
        }

        private void Deconnecter_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void SeDeconnecter_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void Ajouter_s_Click(object sender, EventArgs e)
        {
            if (num_s.Text == "" || num_m.Text == "" || quantite_s.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int numS = Convert.ToInt32(num_s.Text);
                    int numM = Convert.ToInt32(num_m.Text);
                    String date = date_s.Value.ToString("yyyy-MM-dd");
                    String quantite = quantite_s.Value.ToString();

                    String Req = "insert into Sortie values('{0}','{1}','{2}','{3}')";
                    Req = String.Format(Req, numS, date, numM, quantite);
                    Con.EnvoyerData(Req);
                    Afficher_s();
                    MessageBox.Show("Sortie enregistrer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void supprimer_s_Click(object sender, EventArgs e)
        {
            if (num_s.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(num_s.Text);

                    String Req = "delete from Sortie Where num_s ='{0}'";
                    Req = String.Format(Req, num);
                    Con.EnvoyerData(Req);
                    Afficher_s();
                    MessageBox.Show("Entre supprimer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ListeSortie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string identifiant = ListeSortie.CurrentRow.Cells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                ListeSortie.ClearSelection();
                ListeSortie.Rows[e.RowIndex].Selected=true;
            }
            num_s.Text = ListeSortie.CurrentRow.Cells[0].Value.ToString();
            date_s.Text = ListeSortie.CurrentRow.Cells[1].Value.ToString();
            num_m.Text = ListeSortie.CurrentRow.Cells[2].Value.ToString();
            quantite_s.Text = ListeSortie.CurrentRow.Cells[3].Value.ToString();
            if (identifiant != "")
            {
                num_s.Enabled = false;
                Ajouter_s.Enabled = false;
            }
            else
            {
                num_s.Enabled = true;
                Ajouter_s.Enabled = true;
            }
        }

        private void modifier_s_Click(object sender, EventArgs e)
        {
            if (num_s.Text == "" || num_m.Text == "" || quantite_s.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int numS = Convert.ToInt32(num_s.Text);
                    int numM = Convert.ToInt32(num_m.Text);
                    String date = date_s.Value.ToString("yyyy-MM-dd");
                    String quantite = quantite_s.Value.ToString();

                    String Req = "update Sortie set date_s = '{0}', num_m = '{1}', quantite_s = '{2}' where num_s = '{3}'";
                    Req = String.Format(Req, date, numM, quantite, numS);
                    Con.EnvoyerData(Req);
                    Afficher_s();
                    MessageBox.Show("Sortie modifier!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            try
            { 
                String date_1 = date_s1.Value.ToString("yyyy-MM-dd");
                String date_2 = date_s2.Value.ToString("yyyy-MM-dd");
                String Requete = "select  num_s As 'Numero Sortie',date_s As 'Date sortie', num_m As 'Numero Materiel', quantite_s As 'Quantite Sortie' from Sortie where date_s between '" + date_1 + "' and '" + date_2 + "'";
                ListeSortie.DataSource = Con.RecupererData(Requete);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detailLab_Click(object sender, EventArgs e)
        {
            Detaille obj = new Detaille();
            obj.Show();
            this.Hide();
        }

        private void detaile_Click(object sender, EventArgs e)
        {
            Detaille obj = new Detaille();
            obj.Show();
            this.Hide();
        }

        private void Graphe_Click(object sender, EventArgs e)
        {
            String date_1 = date_s1.Value.ToString("yyyy-MM-dd");
            String date_2 = date_s2.Value.ToString("yyyy-MM-dd");
            Graph obj = new Graph(date_1, date_2);
            obj.Show();
        }

        void table(DataGridView d)
        {
            foreach (DataGridViewRow row in d.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            foreach(DataGridViewColumn column in d.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            d.RowHeadersVisible = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Sortie_Load(object sender, EventArgs e)
        {
            ListeSortie.ClearSelection();
        }
    }
}