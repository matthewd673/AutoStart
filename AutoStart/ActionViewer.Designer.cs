namespace AutoStart
{
    partial class ActionViewer
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
            this.Viewer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Multiline = true;
            this.Viewer.Name = "Viewer";
            this.Viewer.ReadOnly = true;
            this.Viewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Viewer.Size = new System.Drawing.Size(284, 261);
            this.Viewer.TabIndex = 0;
            this.Viewer.WordWrap = false;
            // 
            // ActionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Viewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ActionViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Action Viewer";
            this.Load += new System.EventHandler(this.ActionViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Viewer;
    }
}