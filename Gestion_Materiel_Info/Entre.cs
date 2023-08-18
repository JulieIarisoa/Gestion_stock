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
    public partial class Entre : Form
    {
        Fonction Con;
        public Entre()
        {
            InitializeComponent();
            Con = new Fonction();
            Afficher_e();
            table(ListeEntre);
            ListeEntre.ClearSelection();
        }

        private void Afficher_e()
        {
            String Requete = "select num_e As 'Numero entre', date_e As 'Date entre', num_m As 'Numero materiel', quantite_e As 'Qantite entre' from Entre";
            ListeEntre.DataSource = Con.RecupererData(Requete);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close obj = new Close();
            obj.Show();
        }

        private void materiels_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void materiel_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void entreLab_Click(object sender, EventArgs e)
        {
            Entre obj = new Entre();
            obj.Show();
            this.Hide();
        }

        private void entrer_Click(object sender, EventArgs e)
        {
            Entre obj = new Entre();
            obj.Show();
            this.Hide();
        }

        private void sortieLab_Click(object sender, EventArgs e)
        {
            Sortie obj = new Sortie();
            obj.Show();
            this.Hide();
        }

        private void sortie_Click(object sender, EventArgs e)
        {
            Sortie obj = new Sortie();
            obj.Show();
            this.Hide();
        }

        private void SeDeconnecter_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void Deconnecter_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void Ajouter_e_Click(object sender, EventArgs e)
        {
            if (num_e.Text == ""  || num_m.Text == "" || quantite_e.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int numE = Convert.ToInt32(num_e.Text);
                    int numM = Convert.ToInt32(num_m.Text);
                    String date = date_e.Value.ToString("yyyy-MM-dd");
                    String quantite = quantite_e.Value.ToString();

                    String Req = "insert into Entre values('{0}','{1}','{2}','{3}')";
                    Req = String.Format(Req, numE, date, numM, quantite);
                    Con.EnvoyerData(Req);
                    Afficher_e();
                    MessageBox.Show("Entre enregistrer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void supprimer_e_Click(object sender, EventArgs e)
        {
            if (num_e.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(num_e.Text);

                    String Req = "delete from Entre Where num_e ='{0}'";
                    Req = String.Format(Req, num);
                    Con.EnvoyerData(Req);
                    Afficher_e();
                    MessageBox.Show("Entre supprimer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ListeEntre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string identifiant = ListeEntre.CurrentRow.Cells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                ListeEntre.ClearSelection();
                ListeEntre.Rows[e.RowIndex].Selected = true;
            }
            num_e.Text = ListeEntre.CurrentRow.Cells[0].Value.ToString();
            date_e.Text = ListeEntre.CurrentRow.Cells[1].Value.ToString();
            num_m.Text = ListeEntre.CurrentRow.Cells[2].Value.ToString();
            quantite_e.Text = ListeEntre.CurrentRow.Cells[3].Value.ToString();
            if (identifiant != "")
            {
                num_e.Enabled = false;
                Ajouter_e.Enabled = false;
            }
            else
            {
                num_e.Enabled = true;
                Ajouter_e.Enabled = true;
            }
        }

        private void modifier_e_Click(object sender, EventArgs e)
        {
            if (num_e.Text == "" || num_m.Text == "" || quantite_e.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int numE = Convert.ToInt32(num_e.Text);
                    int numM = Convert.ToInt32(num_m.Text);
                    String date = date_e.Value.ToString("yyyy-MM-dd");
                    String quantite = quantite_e.Value.ToString();

                    String Req = "update Entre set date_e = '{0}', num_m = '{1}', quantite_e = '{2}' where num_e = '{3}'";
                    Req = String.Format(Req, date, numM, quantite, numE);
                    Con.EnvoyerData(Req);
                    Afficher_e();
                    MessageBox.Show("Entre modifier!!!");
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
                String date_1 = date1.Value.ToString("yyyy-MM-dd");
                String date_2 = date2.Value.ToString("yyyy-MM-dd");
                String Requete = "select num_e As 'Numero entre',date_e AS 'Date entre',  num_m As 'Numero materiel', quantite_e As 'Qantite entre' from Entre where date_e between '" + date_1+"' and '"+date_2+"'";
                ListeEntre.DataSource = Con.RecupererData(Requete);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Entre_Load(object sender, EventArgs e)
        {
            ListeEntre.ClearSelection();
        }
    }
}