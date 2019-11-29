namespace AutoStart
{
    partial class FileSelect
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PathInput = new System.Windows.Forms.TextBox();
            this.HandlerBrowse = new System.Windows.Forms.Button();
            this.HandlerInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(160, 66);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(161, 20);
            this.NameInput.TabIndex = 7;
            this.NameInput.Text = "Untitled File";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(327, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(45, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(343, 10);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(29, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathInput
            // 
            this.PathInput.Location = new System.Drawing.Point(12, 12);
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(323, 20);
            this.PathInput.TabIndex = 4;
            // 
            // HandlerBrowse
            // 
            this.HandlerBrowse.Location = new System.Drawing.Point(343, 36);
            this.HandlerBrowse.Name = "HandlerBrowse";
            this.HandlerBrowse.Size = new System.Drawing.Size(29, 23);
            this.HandlerBrowse.TabIndex = 9;
            this.HandlerBrowse.Text = "...";
            this.HandlerBrowse.UseVisualStyleBackColor = true;
            this.HandlerBrowse.Click += new System.EventHandler(this.HandlerBrowse_Click);
            // 
            // HandlerInput
            // 
            this.HandlerInput.Location = new System.Drawing.Point(12, 38);
            this.HandlerInput.Name = "HandlerInput";
            this.HandlerInput.Size = new System.Drawing.Size(323, 20);
            this.HandlerInput.TabIndex = 8;
            this.HandlerInput.Text = "(default)";
            // 
            // FileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 96);
            this.Controls.Add(this.HandlerBrowse);
            this.Controls.Add(this.HandlerInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.Button HandlerBrowse;
        private System.Windows.Forms.TextBox HandlerInput;
    }
}