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
    public partial class frmTimeClock : Form
    {
        private Form _home;

        public frmTimeClock(Form home)
        {
            InitializeComponent();
            _home = home;
        }

        private void frmTimeClock_FormClosing(object sender, FormClosingEventArgs e)
        {
            _home.Show();
        }
    }
}
