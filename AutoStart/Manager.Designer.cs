namespace AutoStart
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.ItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.AddDropdown = new System.Windows.Forms.ToolStripSplitButton();
            this.AddProgramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCommandItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunButton = new System.Windows.Forms.ToolStripButton();
            this.XmlButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemPanel
            // 
            this.ItemPanel.AutoScroll = true;
            this.ItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemPanel.Location = new System.Drawing.Point(0, 26);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(300, 436);
            this.ItemPanel.TabIndex = 5;
            this.ItemPanel.WrapContents = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDropdown,
            this.SettingsButton,
            this.XmlButton,
            this.RunButton});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(304, 23);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Menu";
            // 
            // AddDropdown
            // 
            this.AddDropdown.DropDownButtonWidth = 16;
            this.AddDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProgramItem,
            this.AddCommandItem,
            this.AddFileItem});
            this.AddDropdown.Image = ((System.Drawing.Image)(resources.GetObject("AddDropdown.Image")));
            this.AddDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDropdown.Name = "AddDropdown";
            this.AddDropdown.Size = new System.Drawing.Size(90, 20);
            this.AddDropdown.Text = "Program";
            this.AddDropdown.ButtonClick += new System.EventHandler(this.AddDropdown_ButtonClick);
            // 
            // AddProgramItem
            // 
            this.AddProgramItem.Image = ((System.Drawing.Image)(resources.GetObject("AddProgramItem.Image")));
            this.AddProgramItem.Name = "AddProgramItem";
            this.AddProgramItem.Size = new System.Drawing.Size(180, 22);
            this.AddProgramItem.Text = "Program";
            this.AddProgramItem.Click += new System.EventHandler(this.AddProgramItem_Click);
            // 
            // AddCommandItem
            // 
            this.AddCommandItem.Image = ((System.Drawing.Image)(resources.GetObject("AddCommandItem.Image")));
            this.AddCommandItem.Name = "AddCommandItem";
            this.AddCommandItem.Size = new System.Drawing.Size(180, 22);
            this.AddCommandItem.Text = "Command";
            this.AddCommandItem.Click += new System.EventHandler(this.AddCommandItem_Click);
            // 
            // AddFileItem
            // 
            this.AddFileItem.Image = ((System.Drawing.Image)(resources.GetObject("AddFileItem.Image")));
            this.AddFileItem.Name = "AddFileItem";
            this.AddFileItem.Size = new System.Drawing.Size(180, 22);
            this.AddFileItem.Text = "File";
            this.AddFileItem.Click += new System.EventHandler(this.AddFileItem_Click);
            // 
            // RunButton
            // 
            this.RunButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RunButton.Image = ((System.Drawing.Image)(resources.GetObject("RunButton.Image")));
            this.RunButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(23, 20);
            this.RunButton.Text = "Run";
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // XmlButton
            // 
            this.XmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.XmlButton.Image = ((System.Drawing.Image)(resources.GetObject("XmlButton.Image")));
            this.XmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.XmlButton.Name = "XmlButton";
            this.XmlButton.Size = new System.Drawing.Size(23, 20);
            this.XmlButton.Text = "Open XML";
            this.XmlButton.Click += new System.EventHandler(this.XmlButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(23, 20);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ItemPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "AutoStart";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.Resize += new System.EventHandler(this.Manager_Resize);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ItemPanel;
        private System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripSplitButton AddDropdown;
        private System.Windows.Forms.ToolStripMenuItem AddProgramItem;
        private System.Windows.Forms.ToolStripMenuItem AddCommandItem;
        private System.Windows.Forms.ToolStripMenuItem AddFileItem;
        private System.Windows.Forms.ToolStripButton RunButton;
        private System.Windows.Forms.ToolStripButton XmlButton;
        private System.Windows.Forms.ToolStripButton SettingsButton;
    }
}

