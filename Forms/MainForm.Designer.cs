namespace Vehicles.Forms
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCascadeViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTabularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mdiToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.mdiToolStripMenuItem;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainMenuStrip.TabIndex = 8;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mdiToolStripMenuItem
            // 
            this.mdiToolStripMenuItem.Name = "mdiToolStripMenuItem";
            this.mdiToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.mdiToolStripMenuItem.Text = "Mdi";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewNewToolStripMenuItem,
            this.viewCloseToolStripMenuItem,
            this.viewCascadeViewsToolStripMenuItem,
            this.viewTabularToolStripMenuItem});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // viewNewToolStripMenuItem
            // 
            this.viewNewToolStripMenuItem.Name = "viewNewToolStripMenuItem";
            this.viewNewToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewNewToolStripMenuItem.Text = "New";
            this.viewNewToolStripMenuItem.Click += new System.EventHandler(this.viewNewToolStripMenuItem_Click);
            // 
            // viewCloseToolStripMenuItem
            // 
            this.viewCloseToolStripMenuItem.Name = "viewCloseToolStripMenuItem";
            this.viewCloseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewCloseToolStripMenuItem.Text = "Close";
            this.viewCloseToolStripMenuItem.Click += new System.EventHandler(this.viewCloseToolStripMenuItem_Click);
            // 
            // viewCascadeViewsToolStripMenuItem
            // 
            this.viewCascadeViewsToolStripMenuItem.Name = "viewCascadeViewsToolStripMenuItem";
            this.viewCascadeViewsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewCascadeViewsToolStripMenuItem.Text = "Cascade views";
            this.viewCascadeViewsToolStripMenuItem.Click += new System.EventHandler(this.viewCascadeToolStripMenuItem_Click);
            // 
            // viewTabularToolStripMenuItem
            // 
            this.viewTabularToolStripMenuItem.Name = "viewTabularToolStripMenuItem";
            this.viewTabularToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewTabularToolStripMenuItem.Text = "Tabular views";
            this.viewTabularToolStripMenuItem.Click += new System.EventHandler(this.viewTabularToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.MergeIndex = 5;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpAboutToolStripMenuItem.Text = "About...";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 540);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.mainStatusStrip.TabIndex = 10;
            this.mainStatusStrip.Text = "Number of vehicles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCascadeViewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTabularToolStripMenuItem;
        public System.Windows.Forms.StatusStrip mainStatusStrip;
    }
}

