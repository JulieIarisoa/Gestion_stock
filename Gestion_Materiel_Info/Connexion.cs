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
    public partial class Connexion : Form
    {
        Fonction Con;
        public Connexion()
        {
            InitializeComponent();
            Con = new Fonction();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomUser.Text == "" || passUser.Text == "" || nomUser.Text != "Admin" || passUser.Text != "Admin")
            {
                if (nomUser.Text != "Admin" || passUser.Text != "Admin")
                {
                    if (nomUser.Text != "Admin" || nomUser.Text == "")
                    {
                        incorrecteNom.Show();
                    }
                    else
                    {
                        incorrecteNom.Hide();
                    }
                    if (passUser.Text != "Admin" || passUser.Text == "")
                    {
                        IncorrectPass.Show();
                    }
                    else
                    {
                        IncorrectPass.Hide();
                    }
                }
            }
            else
            {
                Menu obj = new Menu();
                obj.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close obj = new Close();
            obj.Show();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            if (nomUser.Text == "" || passUser.Text == "")
            {

            }
            else
            {
                try
                {
                    Random rand = new Random();
                    int i = rand.Next(1, 101);
                    String nom = nomUser.Text;
                    String pass = passUser.Text;

                    String Req = "Insert into User values('{0}','{1}','{2}')";
                    Req = String.Format(Req, i, nom, pass);
                    Con.EnvoyerData(Req);
                    MessageBox.Show("User enregistrer!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
