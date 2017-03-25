using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Vehicles.Controls.Editors
{
    public partial class VehicleTypeEditor : UITypeEditor
    {
        public static List<Image> vehicleTypeImages = new List<Image> {
            Vehicles.Properties.Resources.car,
            Vehicles.Properties.Resources.truck,
            Vehicles.Properties.Resources.motorbike,
        };

        private IWindowsFormsEditorService edSvc;

        public override void PaintValue(
            System.Drawing.Design.PaintValueEventArgs e)
        {
            e.Graphics.DrawImage((vehicleTypeImages[(int)e.Value]), 
                e.Bounds.X, e.Bounds.Y, 
                e.Bounds.Width, e.Bounds.Height);
        }
        
        public override bool GetPaintValueSupported(
            System.ComponentModel.ITypeDescriptorContext context)
        { 
            return true; 
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
            System.ComponentModel.ITypeDescriptorContext context)
        { 
            return UITypeEditorEditStyle.DropDown; 
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, 
            System.IServiceProvider provider, object value)
        {
             edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (edSvc != null)
            {
                VehicleTypeSelector vehicleTypeSelector = new VehicleTypeSelector(vehicleTypeImages, (int)value);
                vehicleTypeSelector.ValueChanged += OnVehicleTypeSelectorValueChanged;
                edSvc.DropDownControl(vehicleTypeSelector);
                return vehicleTypeSelector.value;
            }
            return value;
        }

        private void OnVehicleTypeSelectorValueChanged(object sender, EventArgs e)
        {
            edSvc.CloseDropDown();
        }
    }
}
