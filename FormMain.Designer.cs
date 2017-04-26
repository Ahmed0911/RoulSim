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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.Location = new System.Drawing.Point(40, 88);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(387, 610);
            this.panelTable.TabIndex = 0;
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money [YUD]:";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(519, 90);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(117, 20);
            this.textBoxMoney.TabIndex = 2;
            this.textBoxMoney.Text = "1000";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(519, 128);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 778);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columns:";
            // 
            // textBoxColumnOccurences
            // 
            this.textBoxColumnOccurences.Location = new System.Drawing.Point(98, 775);
            this.textBoxColumnOccurences.Name = "textBoxColumnOccurences";
            this.textBoxColumnOccurences.ReadOnly = true;
            this.textBoxColumnOccurences.Size = new System.Drawing.Size(418, 20);
            this.textBoxColumnOccurences.TabIndex = 7;
            // 
            // radioButtonSlow
            // 
            this.radioButtonSlow.AutoSize = true;
            this.radioButtonSlow.Checked = true;
            this.radioButtonSlow.Location = new System.Drawing.Point(16, 33);
            this.radioButtonSlow.Name = "radioButtonSlow";
            this.radioButtonSlow.Size = new System.Drawing.Size(55, 20);
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
            this.radioButtonSpeed100000.Size = new System.Drawing.Size(83, 20);
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
            this.radioButtonSpeed10000.Size = new System.Drawing.Size(77, 20);
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
            this.radioButtonSpeed1000.Size = new System.Drawing.Size(71, 20);
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
            this.radioButtonSpeed100.Size = new System.Drawing.Size(65, 20);
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
            this.radioButtonMegaFast.Size = new System.Drawing.Size(79, 20);
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
            this.radioButtonFast.Size = new System.Drawing.Size(52, 20);
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
            this.listViewStats.Location = new System.Drawing.Point(659, 88);
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(222, 707);
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
            this.label2.Location = new System.Drawing.Point(40, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spins:";
            // 
            // textBoxNumOfSpins
            // 
            this.textBoxNumOfSpins.Location = new System.Drawing.Point(98, 715);
            this.textBoxNumOfSpins.Name = "textBoxNumOfSpins";
            this.textBoxNumOfSpins.ReadOnly = true;
            this.textBoxNumOfSpins.Size = new System.Drawing.Size(178, 20);
            this.textBoxNumOfSpins.TabIndex = 13;
            // 
            // textBoxNumOfBets
            // 
            this.textBoxNumOfBets.Location = new System.Drawing.Point(98, 741);
            this.textBoxNumOfBets.Name = "textBoxNumOfBets";
            this.textBoxNumOfBets.ReadOnly = true;
            this.textBoxNumOfBets.Size = new System.Drawing.Size(178, 20);
            this.textBoxNumOfBets.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bets:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 847);
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
    }
}

