using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Redditor
{
    public partial class Form1 : Form
    {        
        RequestController req;
        HtmlAgility h = new HtmlAgility();
        DB db;

        public static bool isLogged = false;
       

        public static string fPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            req = new RequestController(this);
            ////req.TestControl();
            //MessageBox.Show(fPath);
            //h.ScrapeHtml();
            //db.Subreddit();
            //h.UpvoteBtnId();
            req.Login();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult folder = dialog.ShowDialog();
                if (folder == DialogResult.OK)
                {
                    string folderName = dialog.SelectedPath;
                    txtPath.Text = folderName;
                }
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //lblConnStatus.Text = "Not connected";
            //lblConnStatus.ForeColor = System.Drawing.Color.Red;

            ////Component disabled
            //txtPath.Enabled = false;
            //btnChoosePath.Enabled = false;
            //btnStart.Enabled = false;
            //btnConnect.Enabled = false;
            //chBoxComment.Enabled = false;
            //chBoxThread.Enabled = false;
            //chBoxUpvote.Enabled = false;

            //Form2 f2 = new Form2(this);
            //f2.Show();
            //f2.BringToFront();
            //f2.TopMost = true;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            f2.BringToFront();
            f2.TopMost = true;
        }
    }
}
