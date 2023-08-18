using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Materiel_Info
{
    class Fonction
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private String ConStr;
        private SqlDataAdapter sda;
        public Fonction()
        {
            //ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juju\Documents\Gestion_Materiel_Info.mdf;Integrated Security=True;Connect Timeout=30";
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juju\Documents\Gestion_stock_materiel_info.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable RecupererData(String Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConStr);
            sda.Fill(dt);
            return dt;
        }

        public int EnvoyerData(String Req)
        {
            int cnt = 0;
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            cmd.CommandText = Req;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
    }
}
