namespace AutoStart
{
    partial class Settings
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
            this.RunOnBootCheck = new System.Windows.Forms.CheckBox();
            this.CloseDialogCheck = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunOnBootCheck
            // 
            this.RunOnBootCheck.AutoSize = true;
            this.RunOnBootCheck.Location = new System.Drawing.Point(12, 12);
            this.RunOnBootCheck.Name = "RunOnBootCheck";
            this.RunOnBootCheck.Size = new System.Drawing.Size(96, 17);
            this.RunOnBootCheck.TabIndex = 0;
            this.RunOnBootCheck.Text = "Run on startup";
            this.RunOnBootCheck.UseVisualStyleBackColor = true;
            // 
            // CloseDialogCheck
            // 
            this.CloseDialogCheck.AutoSize = true;
            this.CloseDialogCheck.Location = new System.Drawing.Point(12, 35);
            this.CloseDialogCheck.Name = "CloseDialogCheck";
            this.CloseDialogCheck.Size = new System.Drawing.Size(156, 17);
            this.CloseDialogCheck.TabIndex = 1;
            this.CloseDialogCheck.Text = "Auto-close execution dialog";
            this.CloseDialogCheck.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(93, 58);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 89);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseDialogCheck);
            this.Controls.Add(this.RunOnBootCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RunOnBootCheck;
        private System.Windows.Forms.CheckBox CloseDialogCheck;
        private System.Windows.Forms.Button SaveButton;
    }
}