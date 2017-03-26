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
            this.components = new System.ComponentModel.Container();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.productionDateLabel = new System.Windows.Forms.Label();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.vehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.speedUnitLabel = new System.Windows.Forms.Label();
            this.vehicleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vehicleTypeControl = new Vehicles.Controls.VehicleTypeControl();
            this.vehicleTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // brandTextBox
            // 
            this.brandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandTextBox.Location = new System.Drawing.Point(194, 12);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(167, 20);
            this.brandTextBox.TabIndex = 0;
            this.brandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.brandTextBox_Validating);
            this.brandTextBox.Validated += new System.EventHandler(this.control_Validated);
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(194, 38);
            this.productionDateDateTimePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.productionDateDateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.productionDateDateTimePicker.TabIndex = 1;
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxSpeedTextBox.Location = new System.Drawing.Point(194, 64);
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(99, 20);
            this.maxSpeedTextBox.TabIndex = 2;
            this.maxSpeedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.maxSpeedTextBox_Validating);
            this.maxSpeedTextBox.Validated += new System.EventHandler(this.control_Validated);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(87, 15);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(67, 13);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Brand name:";
            // 
            // productionDateLabel
            // 
            this.productionDateLabel.AutoSize = true;
            this.productionDateLabel.Location = new System.Drawing.Point(87, 41);
            this.productionDateLabel.Name = "productionDateLabel";
            this.productionDateLabel.Size = new System.Drawing.Size(85, 13);
            this.productionDateLabel.TabIndex = 5;
            this.productionDateLabel.Text = "Production date:";
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Location = new System.Drawing.Point(87, 67);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(62, 13);
            this.maxSpeedLabel.TabIndex = 6;
            this.maxSpeedLabel.Text = "Max speed:";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(193, 88);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(286, 88);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // vehicleTypeGroupBox
            // 
            this.vehicleTypeGroupBox.Controls.Add(this.vehicleTypeControl);
            this.vehicleTypeGroupBox.Controls.Add(this.vehicleTypeTextBox);
            this.vehicleTypeGroupBox.Location = new System.Drawing.Point(4, 1);
            this.vehicleTypeGroupBox.Name = "vehicleTypeGroupBox";
            this.vehicleTypeGroupBox.Size = new System.Drawing.Size(77, 93);
            this.vehicleTypeGroupBox.TabIndex = 11;
            this.vehicleTypeGroupBox.TabStop = false;
            this.vehicleTypeGroupBox.Text = "Vehicle type";
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(3, 70);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.ReadOnly = true;
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(71, 20);
            this.vehicleTypeTextBox.TabIndex = 0;
            this.vehicleTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speedUnitLabel
            // 
            this.speedUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speedUnitLabel.AutoSize = true;
            this.speedUnitLabel.Location = new System.Drawing.Point(299, 67);
            this.speedUnitLabel.Name = "speedUnitLabel";
            this.speedUnitLabel.Size = new System.Drawing.Size(32, 13);
            this.speedUnitLabel.TabIndex = 12;
            this.speedUnitLabel.Text = "km/h";
            // 
            // vehicleErrorProvider
            // 
            this.vehicleErrorProvider.ContainerControl = this;
            this.vehicleErrorProvider.RightToLeft = true;
            // 
            // vehicleTypeControl
            // 
            this.vehicleTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleTypeControl.Location = new System.Drawing.Point(3, 16);
            this.vehicleTypeControl.Name = "vehicleTypeControl";
            this.vehicleTypeControl.Size = new System.Drawing.Size(71, 54);
            this.vehicleTypeControl.TabIndex = 1;
            this.vehicleTypeControl.VehicleType = 0;
            this.vehicleTypeControl.VehicleTypeChanged += new System.EventHandler(this.vehicleTypeControl_VehicleTypeChanged);
            // 
            // VehicleForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(366, 116);
            this.Controls.Add(this.speedUnitLabel);
            this.Controls.Add(this.vehicleTypeGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maxSpeedLabel);
            this.Controls.Add(this.productionDateLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.productionDateDateTimePicker);
            this.Controls.Add(this.brandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.vehicleTypeGroupBox.ResumeLayout(false);
            this.vehicleTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.DateTimePicker productionDateDateTimePicker;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label productionDateLabel;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox vehicleTypeGroupBox;
        private System.Windows.Forms.Label speedUnitLabel;
        private System.Windows.Forms.ErrorProvider vehicleErrorProvider;
        private Controls.VehicleTypeControl vehicleTypeControl;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
    }
}