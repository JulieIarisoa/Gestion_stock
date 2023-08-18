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
    public partial class Deconnecter : Form
    {
        public Deconnecter()
        {
            InitializeComponent();
        }

        private void non_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void oui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
