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

        public void vehicles_Add(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)sender;
            addVehicleToView(vehicle);
        }

        public void vehicles_Remove(object sender, EventArgs e)
        {
            var index = (int)sender;
            removeVehicleFromView(index);
        }

        public void vehicles_Modify(object sender, EventArgs e)
        {
            var index = (int)sender;
            modifyVehicleInView(index);
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
            else
            {
                removeEventHandlers();
            }
        }

        private void vehicleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VehicleForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vehicles.Add(frm.vehicle);
                (MdiParent as MainForm).OnVehicleAdded(frm.vehicle);
            }
        }

        private void vehicleRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var index = vehiclesListView.Items.IndexOf(item);
            vehicles.RemoveAt(index);
            (MdiParent as MainForm).OnVehicleRemoved(index);
        }

        private void vehicleModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var index = vehiclesListView.Items.IndexOf(item);
            var frm = new VehicleForm(vehicles[index]);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vehicles[index].Brand = frm.vehicle.Brand;
                vehicles[index].MaxSpeed = frm.vehicle.MaxSpeed;
                vehicles[index].ProductionDate = frm.vehicle.ProductionDate;
                vehicles[index].Type = frm.vehicle.Type;
                (MdiParent as MainForm).OnVehicleModified(index);
            }
        }

        private void addVehicleToView(Vehicle vehicle)
        {
            var item = new ListViewItem();
            item.Tag = vehicle;
            updateItemInView(item);
            vehiclesListView.Items.Add(item);
        }

        private void removeVehicleFromView(int index)
        {
            vehiclesListView.Items.RemoveAt(index);
        }

        private void modifyVehicleInView(int index)
        {
            var item = vehiclesListView.Items[index];
            var vehicle = vehicles[index];
            item.Tag = vehicle;
            updateItemInView(item);
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

        private void removeEventHandlers()
        {
            var parent = MdiParent as MainForm;
            parent.VehicleAdded -= vehicles_Add;
            parent.VehicleRemoved -= vehicles_Remove;
            parent.VehicleModified -= vehicles_Modify;
        }
    }
}
