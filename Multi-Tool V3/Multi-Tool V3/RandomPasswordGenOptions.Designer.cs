namespace Multi_Tool_V3
{
    partial class RandomPasswordGenOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomPasswordGenOptions));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.allCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.lettersAndNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerAndNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameDisplay = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.allCharactersCheckBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lettersAndNumbersCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lowerAndNumbersCheckBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numbersCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // allCharactersCheckBox
            // 
            this.allCharactersCheckBox.AutoSize = true;
            this.allCharactersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableLayoutPanel1.SetColumnSpan(this.allCharactersCheckBox, 4);
            this.allCharactersCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCharactersCheckBox.Location = new System.Drawing.Point(3, 139);
            this.allCharactersCheckBox.Name = "allCharactersCheckBox";
            this.allCharactersCheckBox.Size = new System.Drawing.Size(420, 31);
            this.allCharactersCheckBox.TabIndex = 4;
            this.allCharactersCheckBox.Text = "Lower Case / Upper Case Letters, Numbers, And Special Characters";
            this.allCharactersCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allCharactersCheckBox.UseVisualStyleBackColor = true;
            this.allCharactersCheckBox.CheckedChanged += new System.EventHandler(this.allLettersNumbersAndCharactersCheckBox_CheckedChanged);
            // 
            // lettersAndNumbersCheckBox
            // 
            this.lettersAndNumbersCheckBox.AutoSize = true;
            this.lettersAndNumbersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableLayoutPanel1.SetColumnSpan(this.lettersAndNumbersCheckBox, 4);
            this.lettersAndNumbersCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lettersAndNumbersCheckBox.Location = new System.Drawing.Point(3, 102);
            this.lettersAndNumbersCheckBox.Name = "lettersAndNumbersCheckBox";
            this.lettersAndNumbersCheckBox.Size = new System.Drawing.Size(420, 31);
            this.lettersAndNumbersCheckBox.TabIndex = 3;
            this.lettersAndNumbersCheckBox.Text = "Lower Case Letters, Upper Case Letters, And Numbers";
            this.lettersAndNumbersCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lettersAndNumbersCheckBox.UseVisualStyleBackColor = true;
            this.lettersAndNumbersCheckBox.CheckedChanged += new System.EventHandler(this.allLettersAndNumbersCheckBox_CheckedChanged);
            // 
            // lowerAndNumbersCheckBox
            // 
            this.lowerAndNumbersCheckBox.AutoSize = true;
            this.lowerAndNumbersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableLayoutPanel1.SetColumnSpan(this.lowerAndNumbersCheckBox, 4);
            this.lowerAndNumbersCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerAndNumbersCheckBox.Location = new System.Drawing.Point(3, 65);
            this.lowerAndNumbersCheckBox.Name = "lowerAndNumbersCheckBox";
            this.lowerAndNumbersCheckBox.Size = new System.Drawing.Size(420, 31);
            this.lowerAndNumbersCheckBox.TabIndex = 2;
            this.lowerAndNumbersCheckBox.Text = "Lower Case Letters and Numbers";
            this.lowerAndNumbersCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lowerAndNumbersCheckBox.UseVisualStyleBackColor = true;
            this.lowerAndNumbersCheckBox.CheckedChanged += new System.EventHandler(this.lowerCaseAndNumbersCheckBox_CheckedChanged);
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableLayoutPanel1.SetColumnSpan(this.numbersCheckBox, 4);
            this.numbersCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbersCheckBox.Location = new System.Drawing.Point(3, 28);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(420, 31);
            this.numbersCheckBox.TabIndex = 1;
            this.numbersCheckBox.Text = "Only Numbers";
            this.numbersCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            this.numbersCheckBox.CheckedChanged += new System.EventHandler(this.numbersOnlyCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(212, 25);
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
            this.usernameDisplay.Location = new System.Drawing.Point(215, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(208, 25);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomPasswordGenOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandomPasswordGenOptions";
            this.Text = "Random Password Generator - Options";
            this.Load += new System.EventHandler(this.RandomPasswordGenOptions_Load);
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
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox allCharactersCheckBox;
        private System.Windows.Forms.CheckBox lettersAndNumbersCheckBox;
        private System.Windows.Forms.CheckBox lowerAndNumbersCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
    }
}