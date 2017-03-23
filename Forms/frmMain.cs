using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicles.Classes;
using Vehicles.Views;

namespace Vehicles.Forms
{
    public partial class frmMain : Form
    {
        public List<Vehicle> vehicles = null;


        private void OnMdiChildrenChanged(int count)
        {
            mitViewClose.Enabled = count > 1;
        }

        public frmMain()
        {
            vehicles = new List<Vehicle>();
            InitializeComponent();
            checkIfMdiChildExists();
        }

        private void checkIfMdiChildExists()
        {
            if (!MdiChildren.Any())
                openNewView();
        }

        private void mitViewNew_Click(object sender, EventArgs e)
        {
            openNewView();
        }

        private void mitViewClose_Click(object sender, EventArgs e)
        {
            closeActiveView();
        }

        private void openNewView()
        {
            var view = new viewVehicles();
            view.MdiParent = this;
            view.Show();
            OnMdiChildrenChanged(MdiChildren.Count());
        }

        private void closeActiveView()
        {
            var view = ActiveMdiChild;
            if (view != null)
            {
                view.Dispose();
                OnMdiChildrenChanged(MdiChildren.Count());
            }
        }

        private void mitHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Vehicles List created as project for subjectPAIN\nAuthor Grzegorz Lewczuk", 
                            "Vehicles info",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }
    }
}
