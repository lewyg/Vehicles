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

        public List<Vehicle> vehicles;
        public List<Vehicle> filteredVehicles
        {
            get
            {
                var tempVehicles = vehicles;

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
            vehicles.Add(vehicle);
            if (filteredVehicles.Contains(vehicle))
                addVehicleToView(vehicle);
        }

        public void vehicles_Remove(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)sender;
            var index = getIndexInView(vehicle);
            if (getIndexInView(vehicle) != -1)
                removeVehicleFromView(index);
        }

        public void vehicles_Modify(object sender, EventArgs e)
        {
            var vehicle = (Vehicle)sender;
            var index = getIndexInView(vehicle);
            if (getIndexInView(vehicle) != -1)
            {
                if (filteredVehicles.Count < vehiclesListView.Items.Count)
                    removeVehicleFromView(index);
                else
                    modifyVehicleInView(index);
            }
            else if (filteredVehicles.Count > vehiclesListView.Items.Count)
            {
                index = getIndexOfMissingVehicleInView();
                if (index != -1)
                    insertVehicleToView(filteredVehicles[index], index);
            }
        }

        public VehiclesViewForm(List<Vehicle> _vehicles)
        {
            vehicles = _vehicles;
            InitializeComponent();
        }

        private void VehiclesViewForm_Load(object sender, EventArgs e)
        {
            registerEventHandlers();
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
            updateStatusBar();
            Text = "VehiclesList " + getFilterModeString(activeFilterMode);
        }

        private void clearView()
        {
            vehiclesListView.Items.Clear();
            updateStatusBar();
        }

        private void addVehicle()
        {
            var frm = new VehicleForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vehicles.Add(frm.vehicle);
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
            updateStatusBar();
        }

        private void removeVehicle()
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var index = vehicles.IndexOf((Vehicle)item.Tag);

            vehicles.RemoveAt(index);
            (MdiParent as MainForm).OnVehicleRemoved((Vehicle)item.Tag);
        }

        private void removeVehicleFromView(Int32 index)
        {
            vehiclesListView.Items.RemoveAt(index);
            updateStatusBar();
        }

        private void modifyVehicle()
        {
            if (vehiclesListView.SelectedItems.Count == 0)
                return;

            var item = vehiclesListView.SelectedItems[0];
            var index = vehicles.IndexOf((Vehicle)item.Tag);

            var frm = new VehicleForm(vehicles[index]);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vehicles[index] = frm.vehicle;
                (MdiParent as MainForm).OnVehicleModified((Vehicle)item.Tag);
            }
        }

        private void modifyVehicleInView(Int32 index)
        {
            var item = vehiclesListView.Items[index];
            var vehicle = filteredVehicles[index];
            item.Tag = vehicle;
            updateItemInView(item);
            updateStatusBar();
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

        private Int32 getIndexInView(Vehicle vehicle)
        {
            foreach (ListViewItem item in vehiclesListView.Items)
                if (item.Tag == vehicle)
                    return vehiclesListView.Items.IndexOf(item);
            return -1;
        }

        private Int32 getIndexOfMissingVehicleInView()
        {
            foreach (ListViewItem item in vehiclesListView.Items)
                if (item.Tag != filteredVehicles[item.Index])
                    return item.Index;
            return -1;
        }

        private string getFilterModeString(FilterMode filter)
        {
            if (filter == FilterMode.None)
                return "";

            return "Filter: Max Speed " + activeFilterToolStripMenuItem.Text;
        }

        private void registerEventHandlers()
        {
            var parent = MdiParent as MainForm;
            parent.VehicleAdded += vehicles_Add;
            parent.VehicleRemoved += vehicles_Remove;
            parent.VehicleModified += vehicles_Modify;
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


        public void updateStatusBar()
        {
                numberOfVehiclesStripStatusLabel.Text =
                    String.Format("Number of vehicles in active view: {0}",
                                  filteredVehicles.Count);
        }

        private void VehiclesViewForm_Activated(object sender, EventArgs e)
        {
            var parent = MdiParent as MainForm;
            ToolStripManager.RevertMerge(parent.mainStatusStrip);
            ToolStripManager.Merge(vehiclesStatusStrip, parent.mainStatusStrip);
        }
    }
}
