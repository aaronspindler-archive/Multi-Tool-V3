namespace Multi_Tool_V3
{
    partial class RandomPasswordGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomPasswordGen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.outputWindow = new System.Windows.Forms.Label();
            this.createPasswordsButton = new System.Windows.Forms.Button();
            this.lengthPasswordsHelpLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.numPasswordsHelpLabel = new System.Windows.Forms.Label();
            this.numPasswordsTextBox = new System.Windows.Forms.TextBox();
            this.lengthPasswordTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.outputWindow, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.createPasswordsButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lengthPasswordsHelpLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numPasswordsHelpLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numPasswordsTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lengthPasswordTextBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outputWindow
            // 
            this.outputWindow.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.outputWindow, 4);
            this.outputWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputWindow.ForeColor = System.Drawing.Color.DarkRed;
            this.outputWindow.Location = new System.Drawing.Point(6, 225);
            this.outputWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(960, 60);
            this.outputWindow.TabIndex = 1;
            this.outputWindow.Text = "Make sure have selected a password option in the options menu";
            this.outputWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createPasswordsButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createPasswordsButton, 2);
            this.createPasswordsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPasswordsButton.Location = new System.Drawing.Point(249, 172);
            this.createPasswordsButton.Margin = new System.Windows.Forms.Padding(6);
            this.createPasswordsButton.Name = "createPasswordsButton";
            this.createPasswordsButton.Size = new System.Drawing.Size(474, 47);
            this.createPasswordsButton.TabIndex = 1;
            this.createPasswordsButton.Text = "Create Passwords";
            this.createPasswordsButton.UseVisualStyleBackColor = true;
            this.createPasswordsButton.Click += new System.EventHandler(this.createPasswordsButton_Click);
            // 
            // lengthPasswordsHelpLabel
            // 
            this.lengthPasswordsHelpLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lengthPasswordsHelpLabel, 2);
            this.lengthPasswordsHelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthPasswordsHelpLabel.Location = new System.Drawing.Point(6, 107);
            this.lengthPasswordsHelpLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lengthPasswordsHelpLabel.Name = "lengthPasswordsHelpLabel";
            this.lengthPasswordsHelpLabel.Size = new System.Drawing.Size(474, 59);
            this.lengthPasswordsHelpLabel.TabIndex = 1;
            this.lengthPasswordsHelpLabel.Text = "Enter the length you want your passwords to be: ";
            this.lengthPasswordsHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip, 2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(486, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordTypeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // passwordTypeToolStripMenuItem
            // 
            this.passwordTypeToolStripMenuItem.Name = "passwordTypeToolStripMenuItem";
            this.passwordTypeToolStripMenuItem.Size = new System.Drawing.Size(247, 36);
            this.passwordTypeToolStripMenuItem.Text = "Password Type";
            this.passwordTypeToolStripMenuItem.Click += new System.EventHandler(this.passwordTypeToolStripMenuItem_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 2);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameDisplay.Location = new System.Drawing.Point(492, 0);
            this.usernameDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(474, 48);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPasswordsHelpLabel
            // 
            this.numPasswordsHelpLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.numPasswordsHelpLabel, 2);
            this.numPasswordsHelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPasswordsHelpLabel.Location = new System.Drawing.Point(6, 48);
            this.numPasswordsHelpLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numPasswordsHelpLabel.Name = "numPasswordsHelpLabel";
            this.numPasswordsHelpLabel.Size = new System.Drawing.Size(474, 59);
            this.numPasswordsHelpLabel.TabIndex = 1;
            this.numPasswordsHelpLabel.Text = "Enter the number of passwords you want: ";
            this.numPasswordsHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPasswordsTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numPasswordsTextBox, 2);
            this.numPasswordsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPasswordsTextBox.Location = new System.Drawing.Point(492, 54);
            this.numPasswordsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.numPasswordsTextBox.Name = "numPasswordsTextBox";
            this.numPasswordsTextBox.Size = new System.Drawing.Size(474, 31);
            this.numPasswordsTextBox.TabIndex = 2;
            this.numPasswordsTextBox.Text = "Default : 1";
            this.numPasswordsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPasswordsTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numPasswordsTextBox_MouseClick);
            this.numPasswordsTextBox.TextChanged += new System.EventHandler(this.numPasswordsTextBox_TextChanged);
            // 
            // lengthPasswordTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lengthPasswordTextBox, 2);
            this.lengthPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthPasswordTextBox.Location = new System.Drawing.Point(492, 113);
            this.lengthPasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lengthPasswordTextBox.Name = "lengthPasswordTextBox";
            this.lengthPasswordTextBox.Size = new System.Drawing.Size(474, 31);
            this.lengthPasswordTextBox.TabIndex = 3;
            this.lengthPasswordTextBox.Text = "Default : 16";
            this.lengthPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthPasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lengthPasswordTextBox_MouseClick);
            this.lengthPasswordTextBox.TextChanged += new System.EventHandler(this.lengthPasswordTextBox_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // RandomPasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RandomPasswordGen";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.RandomPasswordGenerator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordTypeToolStripMenuItem;
        private System.Windows.Forms.Label outputWindow;
        private System.Windows.Forms.Button createPasswordsButton;
        private System.Windows.Forms.Label lengthPasswordsHelpLabel;
        private System.Windows.Forms.Label numPasswordsHelpLabel;
        private System.Windows.Forms.TextBox numPasswordsTextBox;
        private System.Windows.Forms.TextBox lengthPasswordTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}