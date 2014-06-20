namespace Multi_Tool_V3
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomPasswordGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollTheDiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRandomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockPaperScissorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.minecraftUserMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeDisplay, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.programsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(512, 44);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomPasswordGeneratorToolStripMenuItem,
            this.rollTheDiceToolStripMenuItem,
            this.listRandomizerToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.minecraftUserMakerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // randomPasswordGeneratorToolStripMenuItem
            // 
            this.randomPasswordGeneratorToolStripMenuItem.Name = "randomPasswordGeneratorToolStripMenuItem";
            this.randomPasswordGeneratorToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.randomPasswordGeneratorToolStripMenuItem.Text = "Random Password Generator";
            this.randomPasswordGeneratorToolStripMenuItem.Click += new System.EventHandler(this.randomPasswordGeneratorToolStripMenuItem_Click);
            // 
            // rollTheDiceToolStripMenuItem
            // 
            this.rollTheDiceToolStripMenuItem.Name = "rollTheDiceToolStripMenuItem";
            this.rollTheDiceToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.rollTheDiceToolStripMenuItem.Text = "Roll the Dice";
            this.rollTheDiceToolStripMenuItem.Click += new System.EventHandler(this.rollTheDiceToolStripMenuItem_Click);
            // 
            // listRandomizerToolStripMenuItem
            // 
            this.listRandomizerToolStripMenuItem.Name = "listRandomizerToolStripMenuItem";
            this.listRandomizerToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.listRandomizerToolStripMenuItem.Text = "List Randomizer";
            this.listRandomizerToolStripMenuItem.Click += new System.EventHandler(this.listRandomizerToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.converterToolStripMenuItem.Text = "Converter";
            this.converterToolStripMenuItem.Click += new System.EventHandler(this.converterToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rockPaperScissorsToolStripMenuItem});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // rockPaperScissorsToolStripMenuItem
            // 
            this.rockPaperScissorsToolStripMenuItem.Name = "rockPaperScissorsToolStripMenuItem";
            this.rockPaperScissorsToolStripMenuItem.Size = new System.Drawing.Size(297, 36);
            this.rockPaperScissorsToolStripMenuItem.Text = "Rock Paper Scissors";
            this.rockPaperScissorsToolStripMenuItem.Click += new System.EventHandler(this.rockPaperScissorsToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1014, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "xNovax\'s Multi-Tool Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 2);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.Color.DarkRed;
            this.usernameDisplay.Location = new System.Drawing.Point(518, 0);
            this.usernameDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(502, 48);
            this.usernameDisplay.TabIndex = 2;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.timeDisplay, 4);
            this.timeDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDisplay.Location = new System.Drawing.Point(6, 496);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(1014, 48);
            this.timeDisplay.TabIndex = 1;
            this.timeDisplay.Text = "Your watch must be broken.";
            this.timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.monthCalendar1, 2);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(274, 177);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // minecraftUserMakerToolStripMenuItem
            // 
            this.minecraftUserMakerToolStripMenuItem.Name = "minecraftUserMakerToolStripMenuItem";
            this.minecraftUserMakerToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.minecraftUserMakerToolStripMenuItem.Text = "Minecraft User Maker";
            this.minecraftUserMakerToolStripMenuItem.Click += new System.EventHandler(this.minecraftUserMakerToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
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
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomPasswordGeneratorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollTheDiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRandomizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem rockPaperScissorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftUserMakerToolStripMenuItem;
    }
}