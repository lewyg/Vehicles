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

namespace Vehicles.Forms
{
    public partial class frmVehicle : Form
    {
        public Vehicle vehicle
        {
            get;
            set;
        }

        public frmVehicle(Vehicle _vehicle = null)
        {
            InitializeComponent();
            vehicle = _vehicle ?? new Vehicle();
            bsVehicle.DataSource = vehicle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsVehicle.EndEdit();
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsVehicle.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
