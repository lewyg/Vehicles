namespace Vehicles.Views
{
    partial class VehiclesViewForm
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
            this.vehiclesListView = new System.Windows.Forms.ListView();
            this.brandColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSpeedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMaxSpeedBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMaxSpeedAboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMaxSpeedNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMaxSpeedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.vehiclesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.vehiclesStatusStrip = new System.Windows.Forms.StatusStrip();
            this.numberOfVehiclesStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vehiclesMenuStrip.SuspendLayout();
            this.vehiclesStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesListView
            // 
            this.vehiclesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandColumnHeader,
            this.maxSpeedColumnHeader,
            this.productionDateColumnHeader,
            this.typeColumnHeader});
            this.vehiclesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesListView.GridLines = true;
            this.vehiclesListView.Location = new System.Drawing.Point(0, 24);
            this.vehiclesListView.Name = "vehiclesListView";
            this.vehiclesListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vehiclesListView.Size = new System.Drawing.Size(426, 237);
            this.vehiclesListView.TabIndex = 0;
            this.vehiclesListView.UseCompatibleStateImageBehavior = false;
            this.vehiclesListView.View = System.Windows.Forms.View.Details;
            this.vehiclesListView.DoubleClick += new System.EventHandler(this.vehiclesListView_DoubleClick);
            // 
            // brandColumnHeader
            // 
            this.brandColumnHeader.Text = "Brand";
            this.brandColumnHeader.Width = 115;
            // 
            // maxSpeedColumnHeader
            // 
            this.maxSpeedColumnHeader.Text = "Max Speed";
            this.maxSpeedColumnHeader.Width = 71;
            // 
            // productionDateColumnHeader
            // 
            this.productionDateColumnHeader.Text = "Production Date";
            this.productionDateColumnHeader.Width = 105;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 131;
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleAddToolStripMenuItem,
            this.vehicleRemoveToolStripMenuItem,
            this.vehicleModifyToolStripMenuItem});
            this.vehicleToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.vehicleToolStripMenuItem.MergeIndex = 2;
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // vehicleAddToolStripMenuItem
            // 
            this.vehicleAddToolStripMenuItem.Name = "vehicleAddToolStripMenuItem";
            this.vehicleAddToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vehicleAddToolStripMenuItem.Text = "Add";
            this.vehicleAddToolStripMenuItem.Click += new System.EventHandler(this.vehicleAddToolStripMenuItem_Click);
            // 
            // vehicleRemoveToolStripMenuItem
            // 
            this.vehicleRemoveToolStripMenuItem.Name = "vehicleRemoveToolStripMenuItem";
            this.vehicleRemoveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vehicleRemoveToolStripMenuItem.Text = "Remove";
            this.vehicleRemoveToolStripMenuItem.Click += new System.EventHandler(this.vehicleRemoveToolStripMenuItem_Click);
            // 
            // vehicleModifyToolStripMenuItem
            // 
            this.vehicleModifyToolStripMenuItem.Name = "vehicleModifyToolStripMenuItem";
            this.vehicleModifyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vehicleModifyToolStripMenuItem.Text = "Modify";
            this.vehicleModifyToolStripMenuItem.Click += new System.EventHandler(this.vehicleModifyToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxSpeedToolStripMenuItem});
            this.filterToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.filterToolStripMenuItem.MergeIndex = 3;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // maxSpeedToolStripMenuItem
            // 
            this.maxSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterMaxSpeedBelowToolStripMenuItem,
            this.filterMaxSpeedAboveToolStripMenuItem,
            this.filterMaxSpeedNoneToolStripMenuItem,
            this.filterMaxSpeedToolStripTextBox});
            this.maxSpeedToolStripMenuItem.Name = "maxSpeedToolStripMenuItem";
            this.maxSpeedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.maxSpeedToolStripMenuItem.Text = "MaxSpeed";
            // 
            // filterMaxSpeedBelowToolStripMenuItem
            // 
            this.filterMaxSpeedBelowToolStripMenuItem.CheckOnClick = true;
            this.filterMaxSpeedBelowToolStripMenuItem.Name = "filterMaxSpeedBelowToolStripMenuItem";
            this.filterMaxSpeedBelowToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.filterMaxSpeedBelowToolStripMenuItem.Text = "< 100 km/h";
            this.filterMaxSpeedBelowToolStripMenuItem.Click += new System.EventHandler(this.filterMaxSpeedFilterToolStripMenuItem_Click);
            // 
            // filterMaxSpeedAboveToolStripMenuItem
            // 
            this.filterMaxSpeedAboveToolStripMenuItem.CheckOnClick = true;
            this.filterMaxSpeedAboveToolStripMenuItem.Name = "filterMaxSpeedAboveToolStripMenuItem";
            this.filterMaxSpeedAboveToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.filterMaxSpeedAboveToolStripMenuItem.Text = ">= 100 km/h";
            this.filterMaxSpeedAboveToolStripMenuItem.Click += new System.EventHandler(this.filterMaxSpeedFilterToolStripMenuItem_Click);
            // 
            // filterMaxSpeedNoneToolStripMenuItem
            // 
            this.filterMaxSpeedNoneToolStripMenuItem.Checked = true;
            this.filterMaxSpeedNoneToolStripMenuItem.CheckOnClick = true;
            this.filterMaxSpeedNoneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterMaxSpeedNoneToolStripMenuItem.Name = "filterMaxSpeedNoneToolStripMenuItem";
            this.filterMaxSpeedNoneToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.filterMaxSpeedNoneToolStripMenuItem.Text = "None";
            this.filterMaxSpeedNoneToolStripMenuItem.Click += new System.EventHandler(this.filterMaxSpeedFilterToolStripMenuItem_Click);
            // 
            // filterMaxSpeedToolStripTextBox
            // 
            this.filterMaxSpeedToolStripTextBox.Name = "filterMaxSpeedToolStripTextBox";
            this.filterMaxSpeedToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.filterMaxSpeedToolStripTextBox.Text = "100";
            this.filterMaxSpeedToolStripTextBox.TextChanged += new System.EventHandler(this.filterMaxSpeedToolStripTextBox_TextChanged);
            // 
            // vehiclesMenuStrip
            // 
            this.vehiclesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.vehiclesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.vehiclesMenuStrip.Name = "vehiclesMenuStrip";
            this.vehiclesMenuStrip.Size = new System.Drawing.Size(426, 24);
            this.vehiclesMenuStrip.TabIndex = 1;
            this.vehiclesMenuStrip.Text = "Vehicles";
            // 
            // vehiclesStatusStrip
            // 
            this.vehiclesStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfVehiclesStripStatusLabel});
            this.vehiclesStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.vehiclesStatusStrip.Name = "vehiclesStatusStrip";
            this.vehiclesStatusStrip.Size = new System.Drawing.Size(426, 22);
            this.vehiclesStatusStrip.TabIndex = 2;
            this.vehiclesStatusStrip.Text = "Number of vehicles";
            // 
            // numberOfVehiclesStripStatusLabel
            // 
            this.numberOfVehiclesStripStatusLabel.MergeIndex = 1;
            this.numberOfVehiclesStripStatusLabel.Name = "numberOfVehiclesStripStatusLabel";
            this.numberOfVehiclesStripStatusLabel.Size = new System.Drawing.Size(187, 17);
            this.numberOfVehiclesStripStatusLabel.Text = "Number of vehicles in active view:";
            // 
            // VehiclesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.vehiclesStatusStrip);
            this.Controls.Add(this.vehiclesListView);
            this.Controls.Add(this.vehiclesMenuStrip);
            this.MainMenuStrip = this.vehiclesMenuStrip;
            this.Name = "VehiclesViewForm";
            this.Text = "VehiclesList";
            this.Activated += new System.EventHandler(this.VehiclesViewForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehiclesViewForm_FormClosing);
            this.Load += new System.EventHandler(this.VehiclesViewForm_Load);
            this.vehiclesMenuStrip.ResumeLayout(false);
            this.vehiclesMenuStrip.PerformLayout();
            this.vehiclesStatusStrip.ResumeLayout(false);
            this.vehiclesStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vehiclesListView;
        private System.Windows.Forms.ColumnHeader brandColumnHeader;
        private System.Windows.Forms.ColumnHeader maxSpeedColumnHeader;
        private System.Windows.Forms.ColumnHeader productionDateColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMaxSpeedBelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMaxSpeedAboveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMaxSpeedNoneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip vehiclesMenuStrip;
        private System.Windows.Forms.ToolStripTextBox filterMaxSpeedToolStripTextBox;
        private System.Windows.Forms.ToolStripStatusLabel numberOfVehiclesStripStatusLabel;
        private System.Windows.Forms.StatusStrip vehiclesStatusStrip;
    }
}