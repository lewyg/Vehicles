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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleTypeControl));
            this.vehicleTypeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypePictureBox = new System.Windows.Forms.PictureBox();
            this.vehicleTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.vehicleTypeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleTypeTableLayoutPanel
            // 
            this.vehicleTypeTableLayoutPanel.ColumnCount = 1;
            this.vehicleTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.vehicleTypeTableLayoutPanel.Controls.Add(this.vehicleTypeTextBox, 0, 1);
            this.vehicleTypeTableLayoutPanel.Controls.Add(this.vehicleTypePictureBox, 0, 0);
            this.vehicleTypeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.vehicleTypeTableLayoutPanel.Name = "vehicleTypeTableLayoutPanel";
            this.vehicleTypeTableLayoutPanel.RowCount = 2;
            this.vehicleTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.33334F));
            this.vehicleTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.66667F));
            this.vehicleTypeTableLayoutPanel.Size = new System.Drawing.Size(59, 63);
            this.vehicleTypeTableLayoutPanel.TabIndex = 0;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(1, 44);
            this.vehicleTypeTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.ReadOnly = true;
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(57, 20);
            this.vehicleTypeTextBox.TabIndex = 0;
            this.vehicleTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vehicleTypePictureBox
            // 
            this.vehicleTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehicleTypePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypePictureBox.Location = new System.Drawing.Point(1, 1);
            this.vehicleTypePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.vehicleTypePictureBox.Name = "vehicleTypePictureBox";
            this.vehicleTypePictureBox.Size = new System.Drawing.Size(57, 41);
            this.vehicleTypePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleTypePictureBox.TabIndex = 1;
            this.vehicleTypePictureBox.TabStop = false;
            this.vehicleTypePictureBox.Click += new System.EventHandler(this.vehicleTypePictureBox_Click);
            // 
            // vehicleTypeImageList
            // 
            this.vehicleTypeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vehicleTypeImageList.ImageStream")));
            this.vehicleTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.vehicleTypeImageList.Images.SetKeyName(0, "car.png");
            this.vehicleTypeImageList.Images.SetKeyName(1, "truck.png");
            this.vehicleTypeImageList.Images.SetKeyName(2, "motorbike.png");
            // 
            // VehicleTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vehicleTypeTableLayoutPanel);
            this.Name = "VehicleTypeControl";
            this.Size = new System.Drawing.Size(59, 63);
            this.vehicleTypeTableLayoutPanel.ResumeLayout(false);
            this.vehicleTypeTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel vehicleTypeTableLayoutPanel;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.PictureBox vehicleTypePictureBox;
        private System.Windows.Forms.ImageList vehicleTypeImageList;
    }
}
