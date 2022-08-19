using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redditor
{
    internal class DB
    {
        Form1 f;
        Form2 f2;

        public static bool isConnected = false;

        public DB(Form1 f)
        {
            this.f = f;
        }

        public DB(Form2 f2)
        {
            this.f2 = f2;
        }

        public void Login()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:redditor.database.windows.net,1433;Initial Catalog=Redditor1;Persist Security Info=False;User ID=xxx;Password=xxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con.Open();

            SqlCommand cmd = new SqlCommand("select username,password from logins where username='" + f2.txtUsername.Text + "'and Password='" + f2.txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isConnected = true;
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
                con.Close();
            }

            con.Close();
        }

        public string[] Subreddit()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:redditor.database.windows.net,1433;Initial Catalog=Redditor1;Persist Security Info=False;User ID=lookdadon;Password=Fresc@13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from subreddit1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int nbOfRows = dt.Rows.Count;
            string[] linkArr = new string[nbOfRows];

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < nbOfRows; i++)
                {
                    linkArr[i] = dt.Rows[i]["links"].ToString();
                }
            }

            con.Close();

            return linkArr;
        }

        public bool IsConnected()
        {
            return isConnected;
        }
    }

    
}
