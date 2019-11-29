namespace AutoStart
{
    partial class Execute
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
            this.Logo = new System.Windows.Forms.Label();
            this.ExecuteText = new System.Windows.Forms.Label();
            this.ExecuteProgress = new System.Windows.Forms.ProgressBar();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 13);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "AutoStart";
            // 
            // ExecuteText
            // 
            this.ExecuteText.AutoSize = true;
            this.ExecuteText.Location = new System.Drawing.Point(12, 22);
            this.ExecuteText.Name = "ExecuteText";
            this.ExecuteText.Size = new System.Drawing.Size(92, 13);
            this.ExecuteText.TabIndex = 1;
            this.ExecuteText.Text = "Executing nothing";
            this.ExecuteText.Click += new System.EventHandler(this.ExecuteText_Click);
            // 
            // ExecuteProgress
            // 
            this.ExecuteProgress.Location = new System.Drawing.Point(15, 38);
            this.ExecuteProgress.Name = "ExecuteProgress";
            this.ExecuteProgress.Size = new System.Drawing.Size(257, 11);
            this.ExecuteProgress.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(264, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 20);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ExecuteProgress);
            this.Controls.Add(this.ExecuteText);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Execute";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Execute";
            this.Load += new System.EventHandler(this.Execute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label ExecuteText;
        private System.Windows.Forms.ProgressBar ExecuteProgress;
        private System.Windows.Forms.Label CloseButton;
    }
}