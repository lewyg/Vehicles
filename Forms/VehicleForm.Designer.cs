namespace Vehicles.Forms
{
    partial class VehicleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(118, 6);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(238, 20);
            this.brandTextBox.TabIndex = 0;
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(118, 32);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.productionDateDateTimePicker.TabIndex = 1;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(118, 58);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxSpeedTextBox.TabIndex = 2;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(118, 84);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleTypeTextBox.TabIndex = 3;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(12, 9);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(67, 13);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Brand name:";
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(12, 36);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(85, 13);
            this.productionDateLabel.TabIndex = 5;
            this.productionDateLabel.Text = "Production date:";
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Location = new System.Drawing.Point(12, 61);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(62, 13);
            this.maxSpeedLabel.TabIndex = 6;
            this.maxSpeedLabel.Text = "Max speed:";
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(12, 87);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.vehicleTypeLabel.TabIndex = 7;
            this.vehicleTypeLabel.Text = "Vehicle type:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(200, 117);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(281, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // VehicleForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(367, 152);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vehicleTypeLabel);
            this.Controls.Add(this.maxSpeedLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.vehicleTypeTextBox);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.productionDateDateTimePicker);
            this.Controls.Add(this.brandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.DateTimePicker productionDateDateTimePicker;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}