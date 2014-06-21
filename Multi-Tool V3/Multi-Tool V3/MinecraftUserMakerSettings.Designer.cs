namespace Multi_Tool_V3
{
    partial class MinecraftUserMakerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinecraftUserMakerSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordTypeLabel = new System.Windows.Forms.Label();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordTypeCombo = new System.Windows.Forms.ComboBox();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthTextBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.passwordLengthLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordTypeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTypeCombo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordLengthTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveSettingsButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordTypeLabel
            // 
            this.passwordTypeLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.passwordTypeLabel, 2);
            this.passwordTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTypeLabel.Location = new System.Drawing.Point(2, 50);
            this.passwordTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordTypeLabel.Name = "passwordTypeLabel";
            this.passwordTypeLabel.Size = new System.Drawing.Size(112, 24);
            this.passwordTypeLabel.TabIndex = 1;
            this.passwordTypeLabel.Text = "Password Type: ";
            this.passwordTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 4);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameDisplay.Location = new System.Drawing.Point(234, 0);
            this.usernameDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(228, 26);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 4);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(232, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // passwordTypeCombo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.passwordTypeCombo, 6);
            this.passwordTypeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTypeCombo.FormattingEnabled = true;
            this.passwordTypeCombo.Items.AddRange(new object[] {
            "Numbers",
            "Letters (Uppercase and Lowercase)",
            "Numbers and Letters (Uppercase and Lowercase)",
            "All Characters (Numbers, Letters, and Special Characters)"});
            this.passwordTypeCombo.Location = new System.Drawing.Point(118, 52);
            this.passwordTypeCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTypeCombo.Name = "passwordTypeCombo";
            this.passwordTypeCombo.Size = new System.Drawing.Size(344, 21);
            this.passwordTypeCombo.TabIndex = 2;
            this.passwordTypeCombo.SelectedIndexChanged += new System.EventHandler(this.passwordTypeCombo_SelectedIndexChanged);
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.passwordLengthLabel, 2);
            this.passwordLengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLengthLabel.Location = new System.Drawing.Point(3, 26);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(110, 24);
            this.passwordLengthLabel.TabIndex = 1;
            this.passwordLengthLabel.Text = "Password Length: ";
            this.passwordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLengthTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.passwordLengthTextBox, 6);
            this.passwordLengthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLengthTextBox.Location = new System.Drawing.Point(119, 29);
            this.passwordLengthTextBox.Name = "passwordLengthTextBox";
            this.passwordLengthTextBox.Size = new System.Drawing.Size(342, 20);
            this.passwordLengthTextBox.TabIndex = 3;
            this.passwordLengthTextBox.Text = "Default: 8";
            this.passwordLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordLengthTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordLengthTextBox_MouseClick);
            this.passwordLengthTextBox.TextChanged += new System.EventHandler(this.passwordLengthTextBox_TextChanged);
            // 
            // saveSettingsButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.saveSettingsButton, 2);
            this.saveSettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveSettingsButton.Location = new System.Drawing.Point(177, 77);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.tableLayoutPanel1.SetRowSpan(this.saveSettingsButton, 2);
            this.saveSettingsButton.Size = new System.Drawing.Size(110, 43);
            this.saveSettingsButton.TabIndex = 4;
            this.saveSettingsButton.Text = "Save Settings";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MinecraftUserMakerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 123);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MinecraftUserMakerSettings";
            this.Text = "Minecraft User Maker Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MinecraftUserMakerSettings_FormClosing);
            this.Load += new System.EventHandler(this.MinecraftUserMakerSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label passwordTypeLabel;
        private System.Windows.Forms.ComboBox passwordTypeCombo;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TextBox passwordLengthTextBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}