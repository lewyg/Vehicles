using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class frmMain : Form
    {
        public List<Vehicle> vehicles = null;

        public frmMain()
        {
            vehicles = new List<Vehicle>();
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmVehicles();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
