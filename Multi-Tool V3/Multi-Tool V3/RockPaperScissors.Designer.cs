namespace Multi_Tool_V3
{
    partial class RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissors));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockPaperScissorsHelpLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.CheckBox();
            this.paperButton = new System.Windows.Forms.CheckBox();
            this.scissorsButton = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Controls.Add(this.usernameDisplay, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rockPaperScissorsHelpLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.rockButton, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.scissorsButton, 6, 2);
            this.tableLayoutPanel.Controls.Add(this.paperButton, 3, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(696, 402);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.usernameDisplay, 4);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameDisplay.Location = new System.Drawing.Point(354, 0);
            this.usernameDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(336, 38);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.tableLayoutPanel.SetColumnSpan(this.menuStrip, 4);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(348, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rockPaperScissorsHelpLabel
            // 
            this.rockPaperScissorsHelpLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.rockPaperScissorsHelpLabel, 8);
            this.rockPaperScissorsHelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rockPaperScissorsHelpLabel.Location = new System.Drawing.Point(3, 38);
            this.rockPaperScissorsHelpLabel.Name = "rockPaperScissorsHelpLabel";
            this.rockPaperScissorsHelpLabel.Size = new System.Drawing.Size(690, 45);
            this.rockPaperScissorsHelpLabel.TabIndex = 2;
            this.rockPaperScissorsHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockButton
            // 
            this.rockButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rockButton.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.rockButton, 2);
            this.rockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rockButton.Location = new System.Drawing.Point(3, 86);
            this.rockButton.Name = "rockButton";
            this.tableLayoutPanel.SetRowSpan(this.rockButton, 2);
            this.rockButton.Size = new System.Drawing.Size(168, 84);
            this.rockButton.TabIndex = 5;
            this.rockButton.Text = "Rock";
            this.rockButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rockButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            this.paperButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.paperButton.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.paperButton, 2);
            this.paperButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paperButton.Location = new System.Drawing.Point(264, 86);
            this.paperButton.Name = "paperButton";
            this.tableLayoutPanel.SetRowSpan(this.paperButton, 2);
            this.paperButton.Size = new System.Drawing.Size(168, 84);
            this.paperButton.TabIndex = 6;
            this.paperButton.Text = "Paper";
            this.paperButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorsButton
            // 
            this.scissorsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.scissorsButton.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.scissorsButton, 2);
            this.scissorsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scissorsButton.Location = new System.Drawing.Point(525, 86);
            this.scissorsButton.Name = "scissorsButton";
            this.tableLayoutPanel.SetRowSpan(this.scissorsButton, 2);
            this.scissorsButton.Size = new System.Drawing.Size(168, 84);
            this.scissorsButton.TabIndex = 7;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scissorsButton.UseVisualStyleBackColor = true;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 402);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label rockPaperScissorsHelpLabel;
        private System.Windows.Forms.CheckBox rockButton;
        private System.Windows.Forms.CheckBox scissorsButton;
        private System.Windows.Forms.CheckBox paperButton;
    }
}