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
using Vehicles.Forms;

namespace Vehicles.Views
{
    public partial class viewVehicles : Form
    {
        public List<Vehicle> vehicles
        {
            get
            {
                return (MdiParent as frmMain).vehicles;
            }
        }

        public viewVehicles()
        {
            InitializeComponent();
        }

        private void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            var item = new ListViewItem();
            item.Tag = vehicle;
            updateItem(item);
            lvVehicles.Items.Add(item);
        }

        private void mitVehicleAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmVehicle();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                addVehicle(frm.vehicle);
            }
        }

        private void updateItem(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.Brand;
            item.SubItems[1].Text = vehicle.MaxSpeed.ToString();
            item.SubItems[2].Text = vehicle.ProductionDate.ToShortDateString();
            item.SubItems[3].Text = vehicle.Type.ToString();
        }
    }
}
