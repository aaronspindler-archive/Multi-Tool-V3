namespace Multi_Tool_V3
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailabilityUsernameButton = new System.Windows.Forms.Button();
            this.usernameAvailabilityLabel = new System.Windows.Forms.Label();
            this.password1EntryLabel = new System.Windows.Forms.Label();
            this.password2EntryLabel = new System.Windows.Forms.Label();
            this.password1TextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.createUserButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.password1EntryLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkAvailabilityUsernameButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernameAvailabilityLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.password2EntryLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.password1TextBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.password2TextBox, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.usernameTextBox, 4);
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(380, 54);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(374, 31);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "Example : xNovax";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTextBox_MouseClick);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameLabel, 4);
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(4, 50);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(368, 48);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter a username you would like:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 8);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkAvailabilityUsernameButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkAvailabilityUsernameButton, 4);
            this.checkAvailabilityUsernameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkAvailabilityUsernameButton.Location = new System.Drawing.Point(4, 102);
            this.checkAvailabilityUsernameButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkAvailabilityUsernameButton.Name = "checkAvailabilityUsernameButton";
            this.checkAvailabilityUsernameButton.Size = new System.Drawing.Size(368, 40);
            this.checkAvailabilityUsernameButton.TabIndex = 2;
            this.checkAvailabilityUsernameButton.Text = "Check Username Availability";
            this.checkAvailabilityUsernameButton.UseVisualStyleBackColor = true;
            this.checkAvailabilityUsernameButton.Click += new System.EventHandler(this.checkAvailabilityUsernameButton_Click);
            // 
            // usernameAvailabilityLabel
            // 
            this.usernameAvailabilityLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameAvailabilityLabel, 4);
            this.usernameAvailabilityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameAvailabilityLabel.Location = new System.Drawing.Point(380, 98);
            this.usernameAvailabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameAvailabilityLabel.Name = "usernameAvailabilityLabel";
            this.usernameAvailabilityLabel.Size = new System.Drawing.Size(374, 48);
            this.usernameAvailabilityLabel.TabIndex = 3;
            this.usernameAvailabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password1EntryLabel
            // 
            this.password1EntryLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.password1EntryLabel, 4);
            this.password1EntryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password1EntryLabel.Location = new System.Drawing.Point(3, 146);
            this.password1EntryLabel.Name = "password1EntryLabel";
            this.password1EntryLabel.Size = new System.Drawing.Size(370, 48);
            this.password1EntryLabel.TabIndex = 1;
            this.password1EntryLabel.Text = "Enter your password:";
            this.password1EntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password2EntryLabel
            // 
            this.password2EntryLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.password2EntryLabel, 4);
            this.password2EntryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password2EntryLabel.Location = new System.Drawing.Point(3, 194);
            this.password2EntryLabel.Name = "password2EntryLabel";
            this.password2EntryLabel.Size = new System.Drawing.Size(370, 48);
            this.password2EntryLabel.TabIndex = 4;
            this.password2EntryLabel.Text = "Re-Enter your password: ";
            this.password2EntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password1TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.password1TextBox, 4);
            this.password1TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password1TextBox.Location = new System.Drawing.Point(379, 149);
            this.password1TextBox.Name = "password1TextBox";
            this.password1TextBox.PasswordChar = '*';
            this.password1TextBox.Size = new System.Drawing.Size(376, 31);
            this.password1TextBox.TabIndex = 5;
            this.password1TextBox.Text = "password123";
            this.password1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password1TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password1TextBox_MouseClick);
            // 
            // password2TextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.password2TextBox, 4);
            this.password2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password2TextBox.Location = new System.Drawing.Point(379, 197);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.PasswordChar = '*';
            this.password2TextBox.Size = new System.Drawing.Size(376, 31);
            this.password2TextBox.TabIndex = 6;
            this.password2TextBox.Text = "password123";
            this.password2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password2TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password2TextBox_MouseClick);
            // 
            // createUserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createUserButton, 4);
            this.createUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUserButton.Location = new System.Drawing.Point(191, 245);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(370, 44);
            this.createUserButton.TabIndex = 1;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUser";
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.CreateUser_Load);
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
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button checkAvailabilityUsernameButton;
        private System.Windows.Forms.Label usernameAvailabilityLabel;
        private System.Windows.Forms.Label password1EntryLabel;
        private System.Windows.Forms.Label password2EntryLabel;
        private System.Windows.Forms.TextBox password1TextBox;
        private System.Windows.Forms.TextBox password2TextBox;
        private System.Windows.Forms.Button createUserButton;
    }
}