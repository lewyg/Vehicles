﻿using System;
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
    public partial class MainForm : Form
    {
        public List<Vehicle> vehicles = null;

        public EventHandler VehicleAdded;
        public void OnVehicleAdded(Vehicle vehicle)
        {
            if (VehicleAdded != null)
                VehicleAdded(vehicle, EventArgs.Empty);
            updateStatusBar();
        }

        public EventHandler VehicleRemoved;
        public void OnVehicleRemoved(int index)
        {
            if (VehicleRemoved != null)
                VehicleRemoved(index, EventArgs.Empty);
            updateStatusBar();
        }

        public EventHandler VehicleModified;
        public void OnVehicleModified(int index)
        {
            if (VehicleModified != null)
                VehicleModified(index, EventArgs.Empty);
            updateStatusBar();
        }

        private void loadVehicles()
        {
            vehicles.Add(new Vehicle("Opel Astra", DateTime.Now.AddYears(-10), 190, (Int32)VehicleType.Car));
            vehicles.Add(new Vehicle("Audi A4", DateTime.Now.AddYears(-7), 200, (Int32)VehicleType.Car));
            vehicles.Add(new Vehicle("Yamaha Neos", DateTime.Now.AddYears(-2), 90, (Int32)VehicleType.Motorbike));
            vehicles.Add(new Vehicle("Skoda Fabia", DateTime.Now.AddYears(-14), 150, (Int32)VehicleType.Car));
            vehicles.Add(new Vehicle("Volvo", DateTime.Now.AddYears(-9), 80, (Int32)VehicleType.Truck));
            vehicles.Add(new Vehicle("Fiat 125p", DateTime.Now.AddYears(-30), 90, (Int32)VehicleType.Car));
        }

        public MainForm()
        {
            vehicles = new List<Vehicle>();
            InitializeComponent();
            loadVehicles();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openNewView();
        }

        private void viewNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewView();
        }

        private void viewCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeActiveView();
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Vehicles List\nAuthor Grzegorz Lewczuk",
                "Vehicles info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnMdiChildrenAmuontChanged(int count)
        {
            viewCloseToolStripMenuItem.Enabled = count > 1;
        }

        private void openNewView()
        {
            var view = new VehiclesViewForm(vehicles);
            view.MdiParent = this;

            addEventHandlers(view);

            view.Show();
            OnMdiChildrenAmuontChanged(MdiChildren.Count());
        }

        private void addEventHandlers(VehiclesViewForm view)
        {
            VehicleAdded += view.vehicles_Add;
            VehicleRemoved += view.vehicles_Remove;
            VehicleModified += view.vehicles_Modify;
        }

        private void closeActiveView()
        {
            var view = ActiveMdiChild;
            if (view != null)
            {
                view.Dispose();
                OnMdiChildrenAmuontChanged(MdiChildren.Count());
            }
        }

        public void updateStatusBar()
        {
            var view = ActiveMdiChild;
            if (view != null)
            {
                numberOfVehiclesStripStatusLabel.Text =
                    String.Format("Number of vehicles in active view: {0}",
                                  (view as VehiclesViewForm).filteredVehicles.Count);
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            updateStatusBar();
        }

        private void viewCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
