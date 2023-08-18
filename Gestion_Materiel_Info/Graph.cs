using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Materiel_Info
{
    public partial class Graph : Form
    {
        private String dat1;
        private String dat2;
        public Graph(String d1,String d2)
        {
            InitializeComponent();
            dat1 = d1;
            dat2 = d2;
            dt1.Text = dat1;
            dt2.Text = dat2;
        }

        void FillChart()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juju\Documents\Gestion_stock_materiel_info.mdf;Integrated Security=True;Connect Timeout=30");
                DataTable dt = new DataTable();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select num_s,quantite_s from Sortie where date_s between '"+dat1+"' and '"+dat2+"'", con);
                da.Fill(dt);
                chart.DataSource = dt;
                con.Close();
                chart.Series["Sortie"].XValueMember = "num_s";
                chart.Series["Sortie"].YValueMembers = "quantite_s";
                chart.Titles.Add("sortie");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
