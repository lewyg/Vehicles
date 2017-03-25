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
            productionDateDateTimePicker.MaxDate = DateTime.Now.Date;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                updateVehicleFromControlsData();
                DialogResult = DialogResult.OK;
            }
        }

        private void loadControlsDataFromVehicle()
        {
            brandTextBox.Text = vehicle.Brand;
            productionDateDateTimePicker.Value =
                vehicle.ProductionDate.Date < productionDateDateTimePicker.MinDate ?
                productionDateDateTimePicker.MinDate : vehicle.ProductionDate.Date;
            maxSpeedTextBox.Text = vehicle.MaxSpeed.ToString();
            vehicleTypeControl.VehicleType = vehicle.Type;
        }

        private void updateVehicleFromControlsData()
        {
            vehicle.Brand = brandTextBox.Text;
            vehicle.ProductionDate = productionDateDateTimePicker.Value;
            vehicle.MaxSpeed = Int32.Parse(maxSpeedTextBox.Text);
            vehicle.Type = vehicleTypeControl.VehicleType;
        }

        private void brandTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                e.Cancel = true;
                vehicleErrorProvider.SetError((sender as TextBox), "Brand name cannot be empty");
            }
            if (!Char.IsUpper((sender as TextBox).Text.FirstOrDefault()))
            {
                e.Cancel = true;
                vehicleErrorProvider.SetError((sender as TextBox), "Brand name has to start with an uppercase letter");
            }
            if ((sender as TextBox).Text.Any(c => !Char.IsLetterOrDigit(c) && !Char.IsSeparator(c)))
            {
                e.Cancel = true;
                vehicleErrorProvider.SetError((sender as TextBox), "Brand name may contain only letters and digits");
            }
        }

        private void maxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty((sender as TextBox).Text))
            {
                e.Cancel = true;
                vehicleErrorProvider.SetError((sender as TextBox), "Max speed cannot be empty");
            }
            if ((sender as TextBox).Text.Any(c => !Char.IsDigit(c)))
            {
                e.Cancel = true;
                vehicleErrorProvider.SetError((sender as TextBox), "Max speed has to be a number");
            }
        }

        private void control_Validated(object sender, EventArgs e)
        {
            vehicleErrorProvider.SetError((sender as Control), "");
        }
    }
}
