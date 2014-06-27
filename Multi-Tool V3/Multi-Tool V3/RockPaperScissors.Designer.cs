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
            this.rockButton = new System.Windows.Forms.Button();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockPaperScissorsHelpLabel = new System.Windows.Forms.Label();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.robotsChoiceDisplay = new System.Windows.Forms.Label();
            this.winnerDisplay = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel.Controls.Add(this.rockButton, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.usernameDisplay, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rockPaperScissorsHelpLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.paperButton, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.scissorsButton, 6, 2);
            this.tableLayoutPanel.Controls.Add(this.robotsChoiceDisplay, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.winnerDisplay, 2, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(696, 323);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // rockButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.rockButton, 2);
            this.rockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rockButton.Location = new System.Drawing.Point(6, 91);
            this.rockButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rockButton.Name = "rockButton";
            this.tableLayoutPanel.SetRowSpan(this.rockButton, 2);
            this.rockButton.Size = new System.Drawing.Size(162, 82);
            this.rockButton.TabIndex = 1;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
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
            this.rockPaperScissorsHelpLabel.Location = new System.Drawing.Point(4, 38);
            this.rockPaperScissorsHelpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rockPaperScissorsHelpLabel.Name = "rockPaperScissorsHelpLabel";
            this.rockPaperScissorsHelpLabel.Size = new System.Drawing.Size(688, 47);
            this.rockPaperScissorsHelpLabel.TabIndex = 2;
            this.rockPaperScissorsHelpLabel.Text = "Click a button below to select what item you will play";
            this.rockPaperScissorsHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paperButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.paperButton, 2);
            this.paperButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paperButton.Location = new System.Drawing.Point(267, 91);
            this.paperButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.paperButton.Name = "paperButton";
            this.tableLayoutPanel.SetRowSpan(this.paperButton, 2);
            this.paperButton.Size = new System.Drawing.Size(162, 82);
            this.paperButton.TabIndex = 3;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.scissorsButton, 2);
            this.scissorsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scissorsButton.Location = new System.Drawing.Point(528, 91);
            this.scissorsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.scissorsButton.Name = "scissorsButton";
            this.tableLayoutPanel.SetRowSpan(this.scissorsButton, 2);
            this.scissorsButton.Size = new System.Drawing.Size(162, 82);
            this.scissorsButton.TabIndex = 4;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // robotsChoiceDisplay
            // 
            this.robotsChoiceDisplay.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.robotsChoiceDisplay, 8);
            this.robotsChoiceDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.robotsChoiceDisplay.Location = new System.Drawing.Point(6, 179);
            this.robotsChoiceDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.robotsChoiceDisplay.Name = "robotsChoiceDisplay";
            this.robotsChoiceDisplay.Size = new System.Drawing.Size(684, 47);
            this.robotsChoiceDisplay.TabIndex = 1;
            this.robotsChoiceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerDisplay
            // 
            this.winnerDisplay.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.winnerDisplay, 4);
            this.winnerDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winnerDisplay.Location = new System.Drawing.Point(180, 226);
            this.winnerDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.winnerDisplay.Name = "winnerDisplay";
            this.tableLayoutPanel.SetRowSpan(this.winnerDisplay, 2);
            this.winnerDisplay.Size = new System.Drawing.Size(336, 97);
            this.winnerDisplay.TabIndex = 5;
            this.winnerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 323);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label robotsChoiceDisplay;
        private System.Windows.Forms.Label winnerDisplay;
    }
}