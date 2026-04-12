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
    public partial class frmUsers : Form
    {
        private Form _home;

        public frmUsers(Form home)
        {
            InitializeComponent();
            _home = home;
        }

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            _home.Show();
        }
    }
}
