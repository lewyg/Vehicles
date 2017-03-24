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
    public partial class VehiclesViewForm : Form
    {
        public List<Vehicle> vehicles
        {
            get
            {
                if (MdiParent != null)
                    return (MdiParent as MainForm).vehicles;
                return new List<Vehicle>();
            }
        }

        public VehiclesViewForm()
        {
            InitializeComponent();
        }

        private void VehiclesViewForm_Load(object sender, EventArgs e)
        {
            foreach (var vehicle in vehicles)
            {
                addVehicleToView(vehicle);
            }
        }

        private void VehiclesViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiParent != null
                && e.CloseReason == CloseReason.UserClosing
                && MdiParent.MdiChildren.Count() == 1)
            {
                e.Cancel = true;
            }
        }

        private void vehicleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VehicleForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                addVehicle(frm.vehicle);
            }
        }

        private void vehicleModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehicleRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count == 0)
            {
                return;
            }

            var item = vehiclesListView.SelectedItems[0];

            removeVehicle(item);
        }

        private void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            addVehicleToView(vehicle);
        }

        private void addVehicleToView(Vehicle vehicle)
        {
            var item = new ListViewItem();
            item.Tag = vehicle;
            updateItemInView(item);
            vehiclesListView.Items.Add(item);
        }

        private void removeVehicle(ListViewItem item)
        {
            var index = vehiclesListView.Items.IndexOf(item);
            vehicles.RemoveAt(index);
            removeVehicleFromView(index);
        }

        private void removeVehicleFromView(int index)
        {
            vehiclesListView.Items.RemoveAt(index);
        }

        private void modifyVehicle(ListViewItem item, Vehicle vehicle)
        {

        }

        private void modifyVehicleInView(int index, Vehicle vehicle)
        {

        }

        private void updateItemInView(ListViewItem item)
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
