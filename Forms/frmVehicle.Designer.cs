namespace Vehicles.Forms
{
    partial class frmVehicle
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bsVehicle = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Brand", true));
            this.txtBrand.Location = new System.Drawing.Point(118, 6);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(238, 20);
            this.txtBrand.TabIndex = 0;
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsVehicle, "ProductionDate", true));
            this.dtpProductionDate.Location = new System.Drawing.Point(118, 32);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(238, 20);
            this.dtpProductionDate.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "MaxSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.textBox1.Location = new System.Drawing.Point(118, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVehicle, "Type", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.txtMaxSpeed.Location = new System.Drawing.Point(118, 84);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSpeed.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 9);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(67, 13);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Brand name:";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(12, 36);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(85, 13);
            this.lblProductionDate.TabIndex = 5;
            this.lblProductionDate.Text = "Production date:";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(12, 61);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(62, 13);
            this.lblMaxSpeed.TabIndex = 6;
            this.lblMaxSpeed.Text = "Max speed:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Vehicle type:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bsVehicle
            // 
            this.bsVehicle.DataSource = typeof(Vehicles.Classes.Vehicle);
            // 
            // frmVehicle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(367, 152);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMaxSpeed);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtMaxSpeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpProductionDate);
            this.Controls.Add(this.txtBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehicle";
            this.Text = "Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.bsVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsVehicle;
    }
}