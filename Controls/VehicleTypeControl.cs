using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicles.Controls.Editors;

namespace Vehicles.Controls
{
    public partial class VehicleTypeControl : UserControl
    {
        public static int numberOfVehicleTypes = Enum.GetNames(typeof(Vehicles.Classes.VehicleType)).Length;
        public static List<Image> vehicleTypeImages = new List<Image> {
            Vehicles.Properties.Resources.car,
            Vehicles.Properties.Resources.truck,
            Vehicles.Properties.Resources.motorbike,
        };

        private int _vehicleType;

        [Category("Vehicle")]
        [BrowsableAttribute(true)]
        [EditorAttribute(typeof(VehicleTypeEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        public int VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = Math.Max(Math.Min(value, numberOfVehicleTypes), 0);
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
            vehicleTypePictureBox.Image = vehicleTypeImages[VehicleType];
        }

        private void vehicleTypePictureBox_Click(object sender, EventArgs e)
        {
            VehicleType = (VehicleType + 1) % numberOfVehicleTypes;
        }
    }
}
