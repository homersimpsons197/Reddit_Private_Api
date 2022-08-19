using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redditor
{
    public partial class Form2 : Form
    {
        Form1 f;
        DB db;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new DB(this);
            db.Login();

            if (db.IsConnected())
            {
                this.Close();
                f.BringToFront();
                f.TopMost = true;
                f.lblConnStatus.Text = "Connected";
                f.lblConnStatus.ForeColor = System.Drawing.Color.Green;
                f.btnConnect.Enabled = false;
                f.btnConnect.Text = "Connected";

                //Components Form1 enabled
                f.btnStart.Enabled = true;
                f.txtPath.Enabled = true;
                f.btnChoosePath.Enabled = true;
                f.chBoxComment.Enabled = true;
                f.chBoxThread.Enabled = true;
                f.chBoxUpvote.Enabled = true;
            }            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.btnConnect.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f.btnConnect.Enabled = false;
        }
    }
}
