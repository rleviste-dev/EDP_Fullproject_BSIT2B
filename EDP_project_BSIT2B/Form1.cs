using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace EDP_project_BSIT2B
{
    
    public partial class Form1 : Form
    {
        string[,] userCredentials =
        {
            {"admin","1234","Admin"},
            {"user","pass","User"}
    };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }
            else
            {
                DataTable dt = db.ExecuteReturnQuery("select * from tblLoginCredentials where user_username = @uname and user_password = @pword",
                    new MySqlParameter("@uname",tbUsername.Text),
                    new MySqlParameter("@pword",tbPassword.Text));

                if (dt.Rows.Count==1) {
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show();
                }
            }
        }
        MyDatabase db = new MyDatabase();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("connected successfully");
            }
            else
            { MessageBox.Show("AYAW"); }

        }
        
    }
}


