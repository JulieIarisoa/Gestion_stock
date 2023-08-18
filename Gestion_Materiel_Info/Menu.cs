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
    public partial class Menu : Form
    {
        Fonction Con;
        public Menu()
        {
            InitializeComponent();
            Con = new Fonction();
            Afficher();
            table(ListeMateriel);
        }

        private void Afficher()
        {
            String Requete = "select num_m As 'Numero materiel', design_m As 'Designation', pu_m As 'Prix unitaire ', marque_m As 'Marque' from Materiel";
            ListeMateriel.DataSource = Con.RecupererData(Requete);
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

        private void close_Click(object sender, EventArgs e)
        {
            Close obj = new Close();
            obj.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void Deconnecter_Click(object sender, EventArgs e)
        {
            Deconnecter obj = new Deconnecter();
            obj.Show();
        }

        private void entre_Click(object sender, EventArgs e)
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

        private void sortie_Click(object sender, EventArgs e)
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

        private void Ajouter_m_Click(object sender, EventArgs e)
        {
            if (num_m.Text == "" || design_m.Text == "" || pu_m.Text == "" || marque_m.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(num_m.Text);
                    String design = design_m.Text.ToString();
                    int pu = int.Parse(pu_m.Text.ToString());
                    String marque = marque_m.Text.ToString();

                    String Req = "insert into Materiel values('{0}','{1}','{2}','{3}')";
                    Req = String.Format(Req, num, design, pu, marque);
                    Con.EnvoyerData(Req);
                    Afficher();
                    MessageBox.Show("Materiel enregistrer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ListeMateriel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            string identifiant = ListeMateriel.CurrentRow.Cells[0].Value.ToString();
            if (e.RowIndex >= 0)
            {
                ListeMateriel.ClearSelection();
                ListeMateriel.Rows[e.RowIndex].Selected = true;
            }
            num_m.Text = ListeMateriel.Rows[e.RowIndex].Cells[0].Value.ToString();
            design_m.Text = ListeMateriel.Rows[e.RowIndex].Cells[1].Value.ToString();
            pu_m.Text = ListeMateriel.Rows[e.RowIndex].Cells[2].Value.ToString();
            marque_m.Text = ListeMateriel.Rows[e.RowIndex].Cells[3].Value.ToString();
            if(identifiant !="")
            {
                num_m.Enabled = false;
                Ajouter_m.Enabled = false;
            }
            else
            {
                num_m.Enabled = true;
                Ajouter_m.Enabled = true;
            }
        }

        private void supprimer_m_Click(object sender, EventArgs e)
        {
            if (num_m.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(num_m.Text);

                    String Req = "delete from Materiel Where num_m ='{0}'";
                    Req = String.Format(Req, num);
                    Con.EnvoyerData(Req);
                    Afficher();
                    MessageBox.Show("Materiel supprimer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void modifier_m_Click(object sender, EventArgs e)
        {
            if (num_m.Text == "" || design_m.Text == "" || pu_m.Text == "" || marque_m.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(num_m.Text);
                    String design = design_m.Text.ToString();
                    int pu = int.Parse(pu_m.Text.ToString());
                    String marque = marque_m.Text.ToString();

                    String Req = "update Materiel set design_m = '{0}', pu_m = '{1}', marque_m = '{2}' where num_m = '{3}'";
                    Req = String.Format(Req, design, pu, marque, num);
                    Con.EnvoyerData(Req);
                    Afficher();
                    MessageBox.Show("Materiel modifier!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            if ( rech.SelectedIndex == -1 || reche.Text == "")
            {
                MessageBox.Show("Information incomplete!!!");
            }
            else if (rech.SelectedIndex == 0)
            {
                int num = Convert.ToInt32(reche.Text);
                String Requete = "select num_m As 'Numero matier', design_m As 'Designation', pu_m As 'Prix unitaire ', marque_m As 'Marque' from Materiel where num_m = '{0}'";
                Requete = String.Format(Requete, num);
                ListeMateriel.DataSource = Con.RecupererData(Requete);
            }
            else if (rech.SelectedIndex == 1)
            {
                try { 
                String design = reche.Text;
                String Requete = "select num_m As 'Numero materiel', pu_m As 'Prix unitaire ', marque_m As 'Marque',design_m As 'Designation'  from Materiel where design_m like '%" + design+"%'";
                ListeMateriel.DataSource = Con.RecupererData(Requete);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (rech.SelectedIndex == 2)
            {
                try { 
                String marque = reche.Text;
                String Requete = "select num_m As 'Numero materiel', design_m As 'Designation', pu_m As 'Prix unitaire ', marque_m As 'Marque' from Materiel where marque_m  like '%" + marque+"%'";
                ListeMateriel.DataSource = Con.RecupererData(Requete);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void Menu_Load(object sender, EventArgs e)
        {
            ListeMateriel.ClearSelection();
        }
    }
}
