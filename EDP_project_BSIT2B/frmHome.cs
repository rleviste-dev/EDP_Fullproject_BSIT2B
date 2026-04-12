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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister(this);
            this.Hide();
            reg.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnStoreStatus_Click(object sender, EventArgs e)
        {
            frmStoreStatus store = new frmStoreStatus(this);
            this.Hide();
            store.Show();
        }

        private void btnPricebook_Click(object sender, EventArgs e)
        {
            frmPricebook price = new frmPricebook(this);
            this.Hide();
            price.Show();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            frmVendors vendors = new frmVendors(this);
            this.Hide(); 
            vendors.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers(this);
            this.Hide();
            users.Show();
        }

        private void btnTimeCheck_Click(object sender, EventArgs e)
        {
            frmTimeClock time = new frmTimeClock(this);
            this.Hide();
            time.Show();
           
        }
    }
}
