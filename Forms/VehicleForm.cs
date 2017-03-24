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
    public partial class VehicleForm : Form
    {
        public Vehicle vehicle { get; set; }

        public VehicleForm(Vehicle _vehicle = null)
        {
            InitializeComponent();
            vehicle = _vehicle ?? new Vehicle();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            loadControlsDataFromVehicle();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()
                && validateEnteredData())
            {
                updateVehicleFromControlsData();
                DialogResult = DialogResult.OK;
            }
        }

        private void loadControlsDataFromVehicle()
        {
            brandTextBox.Text = vehicle.Brand;
            productionDateDateTimePicker.Value = vehicle.ProductionDate.Date;
            maxSpeedTextBox.Text = vehicle.MaxSpeed.ToString();
            vehicleTypeTextBox.Text = vehicle.Type.ToString();
        }

        private void updateVehicleFromControlsData()
        {
            vehicle.Brand = brandTextBox.Text;
            vehicle.ProductionDate = productionDateDateTimePicker.Value;
            vehicle.MaxSpeed = int.Parse(maxSpeedTextBox.Text);
            vehicle.Type = int.Parse(vehicleTypeTextBox.Text);
        }

        private bool validateEnteredData()
        {
            return true;
        }
    }
}
