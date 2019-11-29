namespace AutoStart
{
    partial class LogViewer
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
            this.LogList = new System.Windows.Forms.ListBox();
            this.DetailView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.Location = new System.Drawing.Point(0, 0);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(284, 238);
            this.LogList.TabIndex = 0;
            this.LogList.SelectedIndexChanged += new System.EventHandler(this.LogList_SelectedIndexChanged);
            // 
            // DetailView
            // 
            this.DetailView.Location = new System.Drawing.Point(0, 238);
            this.DetailView.Multiline = true;
            this.DetailView.Name = "DetailView";
            this.DetailView.ReadOnly = true;
            this.DetailView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DetailView.Size = new System.Drawing.Size(284, 123);
            this.DetailView.TabIndex = 1;
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.DetailView);
            this.Controls.Add(this.LogList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.LogViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.TextBox DetailView;
    }
}