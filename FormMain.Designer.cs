namespace RoulSim
{
    partial class FormMain
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
            this.panelTable = new System.Windows.Forms.Panel();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColumnOccurences = new System.Windows.Forms.TextBox();
            this.radioButtonSlow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSpeed100000 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed10000 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed1000 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed100 = new System.Windows.Forms.RadioButton();
            this.radioButtonMegaFast = new System.Windows.Forms.RadioButton();
            this.radioButtonFast = new System.Windows.Forms.RadioButton();
            this.listViewStats = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumOfSpins = new System.Windows.Forms.TextBox();
            this.textBoxNumOfBets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxColumnInARowCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxColumnInRow = new System.Windows.Forms.TextBox();
            this.textBoxStatBets = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStatSecondBets = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.Location = new System.Drawing.Point(22, 24);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(374, 743);
            this.panelTable.TabIndex = 0;
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 20;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money [YUD]:";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(570, 37);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(117, 26);
            this.textBoxMoney.TabIndex = 2;
            this.textBoxMoney.Text = "1000";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(592, 75);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(79, 31);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 836);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columns:";
            // 
            // textBoxColumnOccurences
            // 
            this.textBoxColumnOccurences.Location = new System.Drawing.Point(111, 833);
            this.textBoxColumnOccurences.Name = "textBoxColumnOccurences";
            this.textBoxColumnOccurences.ReadOnly = true;
            this.textBoxColumnOccurences.Size = new System.Drawing.Size(418, 26);
            this.textBoxColumnOccurences.TabIndex = 7;
            // 
            // radioButtonSlow
            // 
            this.radioButtonSlow.AutoSize = true;
            this.radioButtonSlow.Checked = true;
            this.radioButtonSlow.Location = new System.Drawing.Point(16, 33);
            this.radioButtonSlow.Name = "radioButtonSlow";
            this.radioButtonSlow.Size = new System.Drawing.Size(68, 24);
            this.radioButtonSlow.TabIndex = 9;
            this.radioButtonSlow.TabStop = true;
            this.radioButtonSlow.Text = "Slow";
            this.radioButtonSlow.UseVisualStyleBackColor = true;
            this.radioButtonSlow.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSpeed100000);
            this.groupBox1.Controls.Add(this.radioButtonSpeed10000);
            this.groupBox1.Controls.Add(this.radioButtonSpeed1000);
            this.groupBox1.Controls.Add(this.radioButtonSpeed100);
            this.groupBox1.Controls.Add(this.radioButtonMegaFast);
            this.groupBox1.Controls.Add(this.radioButtonFast);
            this.groupBox1.Controls.Add(this.radioButtonSlow);
            this.groupBox1.Location = new System.Drawing.Point(448, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 235);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step";
            // 
            // radioButtonSpeed100000
            // 
            this.radioButtonSpeed100000.AutoSize = true;
            this.radioButtonSpeed100000.Location = new System.Drawing.Point(16, 189);
            this.radioButtonSpeed100000.Name = "radioButtonSpeed100000";
            this.radioButtonSpeed100000.Size = new System.Drawing.Size(109, 24);
            this.radioButtonSpeed100000.TabIndex = 16;
            this.radioButtonSpeed100000.Text = "1 : 100000";
            this.radioButtonSpeed100000.UseVisualStyleBackColor = true;
            this.radioButtonSpeed100000.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSpeed10000
            // 
            this.radioButtonSpeed10000.AutoSize = true;
            this.radioButtonSpeed10000.Location = new System.Drawing.Point(16, 163);
            this.radioButtonSpeed10000.Name = "radioButtonSpeed10000";
            this.radioButtonSpeed10000.Size = new System.Drawing.Size(100, 24);
            this.radioButtonSpeed10000.TabIndex = 15;
            this.radioButtonSpeed10000.Text = "1 : 10000";
            this.radioButtonSpeed10000.UseVisualStyleBackColor = true;
            this.radioButtonSpeed10000.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSpeed1000
            // 
            this.radioButtonSpeed1000.AutoSize = true;
            this.radioButtonSpeed1000.Location = new System.Drawing.Point(16, 137);
            this.radioButtonSpeed1000.Name = "radioButtonSpeed1000";
            this.radioButtonSpeed1000.Size = new System.Drawing.Size(91, 24);
            this.radioButtonSpeed1000.TabIndex = 14;
            this.radioButtonSpeed1000.Text = "1 : 1000";
            this.radioButtonSpeed1000.UseVisualStyleBackColor = true;
            this.radioButtonSpeed1000.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSpeed100
            // 
            this.radioButtonSpeed100.AutoSize = true;
            this.radioButtonSpeed100.Location = new System.Drawing.Point(16, 111);
            this.radioButtonSpeed100.Name = "radioButtonSpeed100";
            this.radioButtonSpeed100.Size = new System.Drawing.Size(82, 24);
            this.radioButtonSpeed100.TabIndex = 13;
            this.radioButtonSpeed100.Text = "1 : 100";
            this.radioButtonSpeed100.UseVisualStyleBackColor = true;
            this.radioButtonSpeed100.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonMegaFast
            // 
            this.radioButtonMegaFast.AutoSize = true;
            this.radioButtonMegaFast.Location = new System.Drawing.Point(16, 85);
            this.radioButtonMegaFast.Name = "radioButtonMegaFast";
            this.radioButtonMegaFast.Size = new System.Drawing.Size(106, 24);
            this.radioButtonMegaFast.TabIndex = 12;
            this.radioButtonMegaFast.Text = "MegaFast";
            this.radioButtonMegaFast.UseVisualStyleBackColor = true;
            this.radioButtonMegaFast.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonFast
            // 
            this.radioButtonFast.AutoSize = true;
            this.radioButtonFast.Location = new System.Drawing.Point(16, 59);
            this.radioButtonFast.Name = "radioButtonFast";
            this.radioButtonFast.Size = new System.Drawing.Size(66, 24);
            this.radioButtonFast.TabIndex = 11;
            this.radioButtonFast.Text = "Fast";
            this.radioButtonFast.UseVisualStyleBackColor = true;
            this.radioButtonFast.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // listViewStats
            // 
            this.listViewStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewStats.Location = new System.Drawing.Point(713, 12);
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(280, 828);
            this.listViewStats.TabIndex = 11;
            this.listViewStats.UseCompatibleStateImageBehavior = false;
            this.listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Number";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Occurences";
            this.columnHeader2.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 776);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spins:";
            // 
            // textBoxNumOfSpins
            // 
            this.textBoxNumOfSpins.Location = new System.Drawing.Point(111, 773);
            this.textBoxNumOfSpins.Name = "textBoxNumOfSpins";
            this.textBoxNumOfSpins.ReadOnly = true;
            this.textBoxNumOfSpins.Size = new System.Drawing.Size(178, 26);
            this.textBoxNumOfSpins.TabIndex = 13;
            // 
            // textBoxNumOfBets
            // 
            this.textBoxNumOfBets.Location = new System.Drawing.Point(111, 799);
            this.textBoxNumOfBets.Name = "textBoxNumOfBets";
            this.textBoxNumOfBets.ReadOnly = true;
            this.textBoxNumOfBets.Size = new System.Drawing.Size(178, 26);
            this.textBoxNumOfBets.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 802);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bets:";
            // 
            // textBoxColumnInARowCount
            // 
            this.textBoxColumnInARowCount.Location = new System.Drawing.Point(161, 871);
            this.textBoxColumnInARowCount.Name = "textBoxColumnInARowCount";
            this.textBoxColumnInARowCount.ReadOnly = true;
            this.textBoxColumnInARowCount.Size = new System.Drawing.Size(783, 26);
            this.textBoxColumnInARowCount.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 874);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Column Count:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxColumnInRow);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxBetAmount);
            this.groupBox2.Location = new System.Drawing.Point(429, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 180);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Betting";
            // 
            // textBoxBetAmount
            // 
            this.textBoxBetAmount.Location = new System.Drawing.Point(15, 59);
            this.textBoxBetAmount.Name = "textBoxBetAmount";
            this.textBoxBetAmount.Size = new System.Drawing.Size(117, 26);
            this.textBoxBetAmount.TabIndex = 19;
            this.textBoxBetAmount.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Amount [YUD]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Col. in row";
            // 
            // textBoxColumnInRow
            // 
            this.textBoxColumnInRow.Location = new System.Drawing.Point(15, 125);
            this.textBoxColumnInRow.Name = "textBoxColumnInRow";
            this.textBoxColumnInRow.Size = new System.Drawing.Size(117, 26);
            this.textBoxColumnInRow.TabIndex = 20;
            this.textBoxColumnInRow.Text = "10";
            // 
            // textBoxStatBets
            // 
            this.textBoxStatBets.Location = new System.Drawing.Point(496, 334);
            this.textBoxStatBets.Name = "textBoxStatBets";
            this.textBoxStatBets.ReadOnly = true;
            this.textBoxStatBets.Size = new System.Drawing.Size(117, 26);
            this.textBoxStatBets.TabIndex = 21;
            this.textBoxStatBets.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bets:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "S. Bets:";
            // 
            // textBoxStatSecondBets
            // 
            this.textBoxStatSecondBets.Location = new System.Drawing.Point(496, 369);
            this.textBoxStatSecondBets.Name = "textBoxStatSecondBets";
            this.textBoxStatSecondBets.ReadOnly = true;
            this.textBoxStatSecondBets.Size = new System.Drawing.Size(117, 26);
            this.textBoxStatSecondBets.TabIndex = 23;
            this.textBoxStatSecondBets.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1077, 945);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStatSecondBets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStatBets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxColumnInARowCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumOfBets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumOfSpins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxColumnOccurences);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTable);
            this.Name = "FormMain";
            this.Text = "Sim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColumnOccurences;
        private System.Windows.Forms.RadioButton radioButtonSlow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSpeed100000;
        private System.Windows.Forms.RadioButton radioButtonSpeed10000;
        private System.Windows.Forms.RadioButton radioButtonSpeed1000;
        private System.Windows.Forms.RadioButton radioButtonSpeed100;
        private System.Windows.Forms.RadioButton radioButtonMegaFast;
        private System.Windows.Forms.RadioButton radioButtonFast;
        private System.Windows.Forms.ListView listViewStats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumOfSpins;
        private System.Windows.Forms.TextBox textBoxNumOfBets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxColumnInARowCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxColumnInRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.TextBox textBoxStatBets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStatSecondBets;
    }
}

