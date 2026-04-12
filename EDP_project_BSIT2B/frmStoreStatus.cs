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
    public partial class frmStoreStatus : Form
    {
        private Form _home;

        public frmStoreStatus(Form home)
        {
            InitializeComponent();
            _home = home;
        }

        private void frmStoreStatus_FormClosing(object sender, FormClosedEventArgs e)
        {
            _home.Show();
        }
    }
}
