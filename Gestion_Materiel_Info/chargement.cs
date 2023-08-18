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
    public partial class chargement : Form
    {
        public chargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int debut = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            debut += 1;
            progress.Value = debut;
            pourcentage.Text = debut + "%";
            if(progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                Connexion obj = new Connexion();
                obj.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close obj = new Close();
            obj.Show();
        }
    }
}
