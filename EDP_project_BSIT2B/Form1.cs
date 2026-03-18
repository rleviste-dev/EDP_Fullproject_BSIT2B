using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                bool isValid = false;

                for (int x = 0; x < userCredentials.GetLength(0); x++)
                {
                    if (tbUsername.Text == userCredentials[x, 0] &&
                        tbPassword.Text == userCredentials[x, 1])
                    {
                        frmHome frm = new frmHome();
                        MessageBox.Show("Welcome " + userCredentials[x, 2]);

                        this.Hide();
                        frm.Show();

                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                {
                    MessageBox.Show("Invalid Username/Password");
                }
            }
        }
    }
}


