namespace Vehicles.Controls
{
    partial class VehicleTypeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vehicleTypePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleTypePictureBox
            // 
            this.vehicleTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicleTypePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypePictureBox.Location = new System.Drawing.Point(0, 0);
            this.vehicleTypePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.vehicleTypePictureBox.Name = "vehicleTypePictureBox";
            this.vehicleTypePictureBox.Size = new System.Drawing.Size(59, 63);
            this.vehicleTypePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleTypePictureBox.TabIndex = 2;
            this.vehicleTypePictureBox.TabStop = false;
            this.vehicleTypePictureBox.Click += new System.EventHandler(this.vehicleTypePictureBox_Click);
            // 
            // VehicleTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vehicleTypePictureBox);
            this.Name = "VehicleTypeControl";
            this.Size = new System.Drawing.Size(59, 63);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vehicleTypePictureBox;
    }
}
