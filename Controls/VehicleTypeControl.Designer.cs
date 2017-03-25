namespace PojazdyWinForms.Controls
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
            this.vehicleTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.vehicleTypeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.vehicleTypeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleTypeImageList
            // 
            this.vehicleTypeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.vehicleTypeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.vehicleTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // vehicleTypeTableLayoutPanel
            // 
            this.vehicleTypeTableLayoutPanel.ColumnCount = 1;
            this.vehicleTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.vehicleTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.vehicleTypeTableLayoutPanel.Controls.Add(this.vehicleTypeImagePictureBox, 0, 0);
            this.vehicleTypeTableLayoutPanel.Controls.Add(this.vehicleTypeTextBox, 0, 1);
            this.vehicleTypeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.vehicleTypeTableLayoutPanel.Name = "vehicleTypeTableLayoutPanel";
            this.vehicleTypeTableLayoutPanel.RowCount = 2;
            this.vehicleTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.vehicleTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.vehicleTypeTableLayoutPanel.Size = new System.Drawing.Size(70, 77);
            this.vehicleTypeTableLayoutPanel.TabIndex = 0;
            // 
            // vehicleTypeImagePictureBox
            // 
            this.vehicleTypeImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeImagePictureBox.Location = new System.Drawing.Point(2, 2);
            this.vehicleTypeImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleTypeImagePictureBox.Name = "vehicleTypeImagePictureBox";
            this.vehicleTypeImagePictureBox.Size = new System.Drawing.Size(66, 51);
            this.vehicleTypeImagePictureBox.TabIndex = 0;
            this.vehicleTypeImagePictureBox.TabStop = false;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(3, 58);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(64, 20);
            this.vehicleTypeTextBox.TabIndex = 1;
            // 
            // VehicleTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vehicleTypeTableLayoutPanel);
            this.Name = "VehicleTypeControl";
            this.Size = new System.Drawing.Size(70, 77);
            this.vehicleTypeTableLayoutPanel.ResumeLayout(false);
            this.vehicleTypeTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList vehicleTypeImageList;
        private System.Windows.Forms.TableLayoutPanel vehicleTypeTableLayoutPanel;
        private System.Windows.Forms.PictureBox vehicleTypeImagePictureBox;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
    }
}
