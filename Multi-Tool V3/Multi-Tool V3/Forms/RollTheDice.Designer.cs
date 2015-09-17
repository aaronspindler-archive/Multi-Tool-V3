namespace Multi_Tool_V3
{
    partial class RollTheDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollTheDice));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rollNumberButton = new System.Windows.Forms.Button();
            this.startingNumberLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.endingNumberLabel = new System.Windows.Forms.Label();
            this.startingNumberTextBox = new System.Windows.Forms.TextBox();
            this.endingNumberTextBox = new System.Windows.Forms.TextBox();
            this.randomNumberLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rollNumberButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.startingNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.endingNumberLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.startingNumberTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.endingNumberTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.randomNumberLabel, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rollNumberButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rollNumberButton, 2);
            this.rollNumberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollNumberButton.Location = new System.Drawing.Point(96, 80);
            this.rollNumberButton.Name = "rollNumberButton";
            this.rollNumberButton.Size = new System.Drawing.Size(180, 20);
            this.rollNumberButton.TabIndex = 1;
            this.rollNumberButton.Text = "Roll Dice";
            this.rollNumberButton.UseVisualStyleBackColor = true;
            this.rollNumberButton.Click += new System.EventHandler(this.rollNumberButton_Click);
            // 
            // startingNumberLabel
            // 
            this.startingNumberLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.startingNumberLabel, 2);
            this.startingNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingNumberLabel.Location = new System.Drawing.Point(3, 25);
            this.startingNumberLabel.Name = "startingNumberLabel";
            this.startingNumberLabel.Size = new System.Drawing.Size(180, 26);
            this.startingNumberLabel.TabIndex = 99;
            this.startingNumberLabel.Text = "Enter a starting number: ";
            this.startingNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(186, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 2);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameDisplay.Location = new System.Drawing.Point(189, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(180, 25);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingNumberLabel
            // 
            this.endingNumberLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.endingNumberLabel, 2);
            this.endingNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingNumberLabel.Location = new System.Drawing.Point(3, 51);
            this.endingNumberLabel.Name = "endingNumberLabel";
            this.endingNumberLabel.Size = new System.Drawing.Size(180, 26);
            this.endingNumberLabel.TabIndex = 100;
            this.endingNumberLabel.Text = "Enter the ending number: ";
            this.endingNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingNumberTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.startingNumberTextBox, 2);
            this.startingNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingNumberTextBox.Location = new System.Drawing.Point(189, 28);
            this.startingNumberTextBox.Name = "startingNumberTextBox";
            this.startingNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.startingNumberTextBox.TabIndex = 1;
            this.startingNumberTextBox.Text = "Default : 1";
            this.startingNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startingNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startingNumberTextBox_MouseClick);
            this.startingNumberTextBox.TextChanged += new System.EventHandler(this.startingNumberTextBox_TextChanged);
            // 
            // endingNumberTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.endingNumberTextBox, 2);
            this.endingNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingNumberTextBox.Location = new System.Drawing.Point(189, 54);
            this.endingNumberTextBox.Name = "endingNumberTextBox";
            this.endingNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.endingNumberTextBox.TabIndex = 2;
            this.endingNumberTextBox.Text = "Default : 10";
            this.endingNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endingNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.endingNumberTextBox_MouseClick);
            this.endingNumberTextBox.TextChanged += new System.EventHandler(this.endingNumberTextBox_TextChanged);
            // 
            // randomNumberLabel
            // 
            this.randomNumberLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.randomNumberLabel, 2);
            this.randomNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.randomNumberLabel.Location = new System.Drawing.Point(96, 103);
            this.randomNumberLabel.Name = "randomNumberLabel";
            this.randomNumberLabel.Size = new System.Drawing.Size(180, 28);
            this.randomNumberLabel.TabIndex = 101;
            this.randomNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollTheDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RollTheDice";
            this.Text = "Roll The Dice";
            this.Load += new System.EventHandler(this.RollTheDice_Load);
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
        private System.Windows.Forms.Label startingNumberLabel;
        private System.Windows.Forms.Label endingNumberLabel;
        private System.Windows.Forms.TextBox startingNumberTextBox;
        private System.Windows.Forms.TextBox endingNumberTextBox;
        private System.Windows.Forms.Button rollNumberButton;
        private System.Windows.Forms.Label randomNumberLabel;
    }
}