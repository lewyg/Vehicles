using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles.Controls
{
    public partial class VehicleTypeControl : UserControl
    {
        private int _vehicleType;

        [Category("Vehicle")]
        [BrowsableAttribute(true)]
        public int VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value % Enum.GetNames(typeof(Vehicles.Classes.VehicleType)).Length;
                OnVehicleTypeChanged();
            }
        }

        public event EventHandler VehicleTypeChanged;
        //public EventHandler VehicleTypeChanged;
        public void OnVehicleTypeChanged()
        {
            if (VehicleTypeChanged != null)
                VehicleTypeChanged(this, EventArgs.Empty);
        }

        public VehicleTypeControl()
        {
            InitializeComponent();
            VehicleTypeChanged += VehicleType_Changed;
        }

        private void VehicleType_Changed(object sender, EventArgs e)
        {
            vehicleTypePictureBox.Image = vehicleTypeImageList.Images[VehicleType];
        }

        private void vehicleTypePictureBox_Click(object sender, EventArgs e)
        {
            VehicleType++;
        }
    }
}
