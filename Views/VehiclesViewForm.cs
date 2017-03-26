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
        private enum FilterMode
        {   
            None = 0,
            MaxSpeedAbove = 1,
            MaxSpeedBelow = 2
        }

        private int filterMaxSpeed = 100;
        private ToolStripMenuItem activeFilterToolStripMenuItem;
        private FilterMode activeFilterMode
        {
            get
            {
                if (filterMaxSpeedAboveToolStripMenuItem.Checked)
                    return FilterMode.MaxSpeedAbove;
                else if (filterMaxSpeedBelowToolStripMenuItem.Checked)
                    return FilterMode.MaxSpeedBelow;
                else
                    return FilterMode.None;
            }
        }

        public List<Vehicle> globalVehicles;
        private List<Vehicle> localVehicles;
        public List<Vehicle> filteredVehicles
        {
            get
            {
                var tempVehicles = localVehicles;

                if (activeFilterMode == FilterMode.MaxSpeedAbove)
                    tempVehicles = tempVehicles.Where(v => v.MaxSpeed >= filterMaxSpeed).ToList();
                else if (activeFilterMode == FilterMode.MaxSpeedBelow)
                    tempVehicles = tempVehicles.Where(v => v.MaxSpeed < filterMaxSpeed).ToList();
                return tempVehicles;
            }
        }

        public void vehicles_Add(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)sender;
            localVehicles.Add(vehicle);
            if (filteredVehicles.Contains(vehicle))
                addVehicleToView(vehicle);
        }

        public void vehicles_Remove(object sender, EventArgs e)
        {
            var index = (Int32)sender;
            var vehicle = localVehicles[index];
            var indexInFilteredVehicles = filteredVehicles.IndexOf(vehicle);
            if (indexInFilteredVehicles != -1)
                removeVehicleFromView(indexInFilteredVehicles);
            localVehicles.RemoveAt(index);
        }

        public void vehicles_Modify(object sender, EventArgs e)
        {
            var index = (Int32)sender;
            var vehicleLocal = localVehicles[index];
            var vehicleGlobal = globalVehicles[index];
            var indexInLocalFilteredVehicles = filteredVehicles.IndexOf(vehicleLocal);

            localVehicles[index] = vehicleGlobal;

            var indexInGlobalFilteredVehicles = filteredVehicles.IndexOf(vehicleGlobal);

            if (indexInLocalFilteredVehicles != -1)
            {
                if (filteredVehicles.Count < vehiclesListView.Items.Count)
                    removeVehicleFromView(indexInLocalFilteredVehicles);
                else
                    modifyVehicleInView(indexInLocalFilteredVehicles);
            }

            if (indexInGlobalFilteredVehicles != -1)
            {
                if (filteredVehicles.Count > vehiclesListView.Items.Count)
                    insertVehicleToView(vehicleGlobal, indexInGlobalFilteredVehicles);
            }
        }

        public VehiclesViewForm(List<Vehicle> _vehicles)
        {
            globalVehicles = _vehicles;
            localVehicles = _vehicles.Select(v => new Vehicle(v)).ToList();
            InitializeComponent();
        }

        private void VehiclesViewForm_Load(object sender, EventArgs e)
        {
            activeFilterToolStripMenuItem = filterMaxSpeedNoneToolStripMenuItem;
            refreshView();
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
                unregisterEventHandlers();
            }
        }

        private void vehicleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addVehicle();
        }

        private void vehicleRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeVehicle();
        }

        private void vehicleModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyVehicle();
        }

        private void filterMaxSpeedFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeFilterToolStripMenuItem.CheckState = CheckState.Unchecked;
            activeFilterToolStripMenuItem = (ToolStripMenuItem)sender;
            activeFilterToolStripMenuItem.CheckState = CheckState.Checked;
            refreshView();
        }

        private void filterMaxSpeedToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as ToolStripTextBox).Text))
                return;

            Int32 maxSpeed;
            if (Int32.TryParse((sender as ToolStripTextBox).Text, out maxSpeed))
            {
                if (maxSpeed > 0)
                {
                    filterMaxSpeed = maxSpeed;
                    updateFilterMaxSpeed();
                }
                else
                {
                    MessageBox.Show("Max Speed has to be greater than 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Not a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vehiclesListView_DoubleClick(object sender, EventArgs e)
        {
            modifyVehicle();
        }

        private void refreshView()
        {
            clearView();
            foreach (var vehicle in filteredVehicles)
            {
                addVehicleToView(vehicle);
            }
            (MdiParent as MainForm).updateStatusBar();
            Text = "VehiclesList " + getFilterModeString(activeFilterMode);
        }

        private void clearView()
        {
            vehiclesListView.Items.Clear();
        }

        private void addVehicle()
        {
            var frm = new VehicleForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                globalVehicles.Add(frm.vehicle);
                (MdiParent as MainForm).OnVehicleAdded(frm.vehicle);
            }
        }

        private void addVehicleToView(Vehicle vehicle)
        {
            insertVehicleToView(vehicle, vehiclesListView.Items.Count);
        }

        private void insertVehicleToView(Vehicle vehicle, Int32 index)
        {
            var item = new ListViewItem();
            item.Tag = vehicle;
            updateItemInView(item);
            vehiclesListView.Items.Insert(index, item);
        }


        private void removeVehicle()
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var indexInFilteredVehicles = vehiclesListView.Items.IndexOf(item);
            var vehicle = filteredVehicles[indexInFilteredVehicles];
            var index = localVehicles.IndexOf(vehicle);

            globalVehicles.RemoveAt(index);
            (MdiParent as MainForm).OnVehicleRemoved(index);
        }

        private void removeVehicleFromView(Int32 index)
        {
            vehiclesListView.Items.RemoveAt(index);
        }

        private void modifyVehicle()
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var indexInFilteredVehicles = vehiclesListView.Items.IndexOf(item);
            var vehicle = filteredVehicles[indexInFilteredVehicles];
            var index = localVehicles.IndexOf(vehicle);

            var frm = new VehicleForm(globalVehicles[index]);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                globalVehicles[index] = frm.vehicle;
                (MdiParent as MainForm).OnVehicleModified(index);
            }
        }

        private void modifyVehicleInView(Int32 index)
        {
            var item = vehiclesListView.Items[index];
            var vehicle = filteredVehicles[index];
            item.Tag = vehicle;
            updateItemInView(item);
        }

        private void updateItemInView(ListViewItem item)
        {
            Vehicle vehicle = (Vehicle)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = vehicle.Brand;
            item.SubItems[1].Text = vehicle.MaxSpeed.ToString() + " km/h";
            item.SubItems[2].Text = vehicle.ProductionDate.ToShortDateString();
            item.SubItems[3].Text = ((VehicleType)vehicle.Type).ToString();
        }

        private string getFilterModeString(FilterMode filter)
        {
            if (filter == FilterMode.None)
                return "";

            return "Filter: Max Speed " + activeFilterToolStripMenuItem.Text;
        }

        private void unregisterEventHandlers()
        {
            var parent = MdiParent as MainForm;
            parent.VehicleAdded -= vehicles_Add;
            parent.VehicleRemoved -= vehicles_Remove;
            parent.VehicleModified -= vehicles_Modify;
        }

        private void updateFilterMaxSpeed()
        {
            filterMaxSpeedAboveToolStripMenuItem.Text = ">= " + filterMaxSpeed + " km/h";
            filterMaxSpeedBelowToolStripMenuItem.Text = "< " + filterMaxSpeed + " km/h";
            refreshView();
        }

        private void filterMaxSpeedToolStripTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
