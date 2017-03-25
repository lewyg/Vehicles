using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles.Controls.Editors
{
    public partial class VehicleTypeSelector : UserControl
    {
        public Int32 value { get; set; }
        public EventHandler ValueChanged;
        public void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
        private List<Image> images { get; set; }

        public VehicleTypeSelector(List<Image> _images, int _value = 0)
        {
            images = _images;
            value = _value;
            InitializeComponent();
            InitializeImages();
        }

        private void InitializeImages()
        {
            foreach (var image in images)
            {
                var pictureBox = getPictureBox(image);
                if (images.IndexOf(image) == value)
                {
                    pictureBox.BackColor = Color.LightCyan;
                    pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private PictureBox getPictureBox(Image image)
        {
            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(32, 32);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            return pictureBox;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            value = images.IndexOf((sender as PictureBox).Image);
            OnValueChanged(EventArgs.Empty);
        }

    }
}
