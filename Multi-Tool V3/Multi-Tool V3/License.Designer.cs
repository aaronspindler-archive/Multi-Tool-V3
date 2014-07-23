namespace Multi_Tool_V3
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.licenseTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenseTextBox.Location = new System.Drawing.Point(0, 0);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.Size = new System.Drawing.Size(732, 524);
            this.licenseTextBox.TabIndex = 0;
            this.licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 524);
            this.Controls.Add(this.licenseTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.Text = "License";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox licenseTextBox;
    }
}