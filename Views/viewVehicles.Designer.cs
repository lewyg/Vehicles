namespace Vehicles.Views
{
    partial class viewVehicles
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
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.clhBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhProductionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVehicleAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVehicleRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mitVehicleModify = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitFilterSpeedLessThan = new System.Windows.Forms.ToolStripMenuItem();
            this.mitFilterSpeedMoreThan = new System.Windows.Forms.ToolStripMenuItem();
            this.mitFilterSpeedNone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVehicles
            // 
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhBrand,
            this.clhMaxSpeed,
            this.clhProductionDate,
            this.clhType});
            this.lvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVehicles.GridLines = true;
            this.lvVehicles.Location = new System.Drawing.Point(0, 24);
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvVehicles.Size = new System.Drawing.Size(621, 237);
            this.lvVehicles.TabIndex = 0;
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Details;
            // 
            // clhBrand
            // 
            this.clhBrand.Text = "Brand";
            this.clhBrand.Width = 40;
            // 
            // clhMaxSpeed
            // 
            this.clhMaxSpeed.Text = "Max Speed";
            this.clhMaxSpeed.Width = 66;
            // 
            // clhProductionDate
            // 
            this.clhProductionDate.Text = "Production Date";
            this.clhProductionDate.Width = 89;
            // 
            // clhType
            // 
            this.clhType.Text = "Type";
            this.clhType.Width = 422;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitVehicleAdd,
            this.mitVehicleRemove,
            this.mitVehicleModify});
            this.testToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.testToolStripMenuItem.MergeIndex = 1;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.testToolStripMenuItem.Text = "Vehicle";
            // 
            // mitVehicleAdd
            // 
            this.mitVehicleAdd.Name = "mitVehicleAdd";
            this.mitVehicleAdd.Size = new System.Drawing.Size(152, 22);
            this.mitVehicleAdd.Text = "Add";
            this.mitVehicleAdd.Click += new System.EventHandler(this.mitVehicleAdd_Click);
            // 
            // mitVehicleRemove
            // 
            this.mitVehicleRemove.Name = "mitVehicleRemove";
            this.mitVehicleRemove.Size = new System.Drawing.Size(152, 22);
            this.mitVehicleRemove.Text = "Remove";
            // 
            // mitVehicleModify
            // 
            this.mitVehicleModify.Name = "mitVehicleModify";
            this.mitVehicleModify.Size = new System.Drawing.Size(152, 22);
            this.mitVehicleModify.Text = "Modify";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxSpeedToolStripMenuItem});
            this.filterToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.filterToolStripMenuItem.MergeIndex = 2;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // maxSpeedToolStripMenuItem
            // 
            this.maxSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitFilterSpeedLessThan,
            this.mitFilterSpeedMoreThan,
            this.mitFilterSpeedNone});
            this.maxSpeedToolStripMenuItem.Name = "maxSpeedToolStripMenuItem";
            this.maxSpeedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.maxSpeedToolStripMenuItem.Text = "MaxSpeed";
            // 
            // mitFilterSpeedLessThan
            // 
            this.mitFilterSpeedLessThan.CheckOnClick = true;
            this.mitFilterSpeedLessThan.Name = "mitFilterSpeedLessThan";
            this.mitFilterSpeedLessThan.Size = new System.Drawing.Size(143, 22);
            this.mitFilterSpeedLessThan.Text = "< 100 km/h";
            // 
            // mitFilterSpeedMoreThan
            // 
            this.mitFilterSpeedMoreThan.CheckOnClick = true;
            this.mitFilterSpeedMoreThan.Name = "mitFilterSpeedMoreThan";
            this.mitFilterSpeedMoreThan.Size = new System.Drawing.Size(143, 22);
            this.mitFilterSpeedMoreThan.Text = ">= 100 km/h";
            // 
            // mitFilterSpeedNone
            // 
            this.mitFilterSpeedNone.Checked = true;
            this.mitFilterSpeedNone.CheckOnClick = true;
            this.mitFilterSpeedNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mitFilterSpeedNone.Name = "mitFilterSpeedNone";
            this.mitFilterSpeedNone.Size = new System.Drawing.Size(143, 22);
            this.mitFilterSpeedNone.Text = "None";
            // 
            // viewVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 261);
            this.Controls.Add(this.lvVehicles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "viewVehicles";
            this.Text = "Vehicles ListView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader clhBrand;
        private System.Windows.Forms.ColumnHeader clhMaxSpeed;
        private System.Windows.Forms.ColumnHeader clhProductionDate;
        private System.Windows.Forms.ColumnHeader clhType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitVehicleAdd;
        private System.Windows.Forms.ToolStripMenuItem mitVehicleRemove;
        private System.Windows.Forms.ToolStripMenuItem mitVehicleModify;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitFilterSpeedLessThan;
        private System.Windows.Forms.ToolStripMenuItem mitFilterSpeedMoreThan;
        private System.Windows.Forms.ToolStripMenuItem mitFilterSpeedNone;
    }
}