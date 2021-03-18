namespace MapleDX
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bossButton = new System.Windows.Forms.Button();
            this.ArcaneButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.compText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.alarmButton = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.legionBox = new System.Windows.Forms.CheckBox();
            this.fpqBox = new System.Windows.Forms.CheckBox();
            this.absoBox = new System.Windows.Forms.CheckBox();
            this.completionBar = new System.Windows.Forms.ProgressBar();
            this.commerciBox = new System.Windows.Forms.CheckBox();
            this.guildBox = new System.Windows.Forms.CheckBox();
            this.voteBox = new System.Windows.Forms.CheckBox();
            this.doneMPBox = new System.Windows.Forms.CheckBox();
            this.doneArcaneBox = new System.Windows.Forms.CheckBox();
            this.doneBossBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daily Activities";
            // 
            // bossButton
            // 
            this.bossButton.Location = new System.Drawing.Point(12, 43);
            this.bossButton.Name = "bossButton";
            this.bossButton.Size = new System.Drawing.Size(92, 23);
            this.bossButton.TabIndex = 7;
            this.bossButton.Text = "Bossing Menu";
            this.bossButton.UseVisualStyleBackColor = true;
            this.bossButton.Click += new System.EventHandler(this.bossButton_Click);
            // 
            // ArcaneButton
            // 
            this.ArcaneButton.Location = new System.Drawing.Point(12, 95);
            this.ArcaneButton.Name = "ArcaneButton";
            this.ArcaneButton.Size = new System.Drawing.Size(89, 23);
            this.ArcaneButton.TabIndex = 8;
            this.ArcaneButton.Text = "Arcane Menu";
            this.ArcaneButton.UseVisualStyleBackColor = true;
            this.ArcaneButton.Click += new System.EventHandler(this.ArcaneButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // compText
            // 
            this.compText.AutoSize = true;
            this.compText.BackColor = System.Drawing.Color.Transparent;
            this.compText.ForeColor = System.Drawing.SystemColors.Window;
            this.compText.Location = new System.Drawing.Point(524, 314);
            this.compText.Name = "compText";
            this.compText.Size = new System.Drawing.Size(21, 13);
            this.compText.TabIndex = 11;
            this.compText.Text = "0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Launch Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 275);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(89, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 2);
            this.label3.TabIndex = 13;
            // 
            // alarmButton
            // 
            this.alarmButton.Location = new System.Drawing.Point(118, 275);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(89, 23);
            this.alarmButton.TabIndex = 20;
            this.alarmButton.Text = "Vote Alarm";
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.Transparent;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTime.Location = new System.Drawing.Point(470, 9);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(48, 16);
            this.currentTime.TabIndex = 21;
            this.currentTime.Text = "yeah :)";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // legionBox
            // 
            this.legionBox.AutoSize = true;
            this.legionBox.BackColor = System.Drawing.Color.Transparent;
            this.legionBox.Checked = global::MapleDX.Properties.Settings.Default.legionBX;
            this.legionBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "legionBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.legionBox.ForeColor = System.Drawing.SystemColors.Window;
            this.legionBox.Location = new System.Drawing.Point(118, 185);
            this.legionBox.Name = "legionBox";
            this.legionBox.Size = new System.Drawing.Size(58, 17);
            this.legionBox.TabIndex = 18;
            this.legionBox.Text = "Legion";
            this.legionBox.UseVisualStyleBackColor = false;
            this.legionBox.Click += new System.EventHandler(this.legionBox_Click);
            // 
            // fpqBox
            // 
            this.fpqBox.AutoSize = true;
            this.fpqBox.BackColor = System.Drawing.Color.Transparent;
            this.fpqBox.Checked = global::MapleDX.Properties.Settings.Default.fpqBX;
            this.fpqBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "fpqBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fpqBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fpqBox.Location = new System.Drawing.Point(118, 160);
            this.fpqBox.Name = "fpqBox";
            this.fpqBox.Size = new System.Drawing.Size(70, 17);
            this.fpqBox.TabIndex = 17;
            this.fpqBox.Text = "Fresh PQ";
            this.fpqBox.UseVisualStyleBackColor = false;
            this.fpqBox.Click += new System.EventHandler(this.fpqBox_Click);
            // 
            // absoBox
            // 
            this.absoBox.AutoSize = true;
            this.absoBox.BackColor = System.Drawing.Color.Transparent;
            this.absoBox.Checked = global::MapleDX.Properties.Settings.Default.absoBX;
            this.absoBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "absoBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.absoBox.ForeColor = System.Drawing.SystemColors.Window;
            this.absoBox.Location = new System.Drawing.Point(12, 254);
            this.absoBox.Name = "absoBox";
            this.absoBox.Size = new System.Drawing.Size(107, 17);
            this.absoBox.TabIndex = 16;
            this.absoBox.Text = "AbsoLab Weekly";
            this.absoBox.UseVisualStyleBackColor = false;
            this.absoBox.Click += new System.EventHandler(this.absoBox_Click);
            // 
            // completionBar
            // 
            this.completionBar.BackColor = System.Drawing.SystemColors.Control;
            this.completionBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MapleDX.Properties.Settings.Default, "compBarVal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.completionBar.ForeColor = System.Drawing.Color.Crimson;
            this.completionBar.Location = new System.Drawing.Point(12, 304);
            this.completionBar.Maximum = 90;
            this.completionBar.Name = "completionBar";
            this.completionBar.Size = new System.Drawing.Size(506, 23);
            this.completionBar.TabIndex = 9;
            this.completionBar.Value = global::MapleDX.Properties.Settings.Default.compBarVal;
            // 
            // commerciBox
            // 
            this.commerciBox.AutoSize = true;
            this.commerciBox.BackColor = System.Drawing.Color.Transparent;
            this.commerciBox.Checked = global::MapleDX.Properties.Settings.Default.commerciBox;
            this.commerciBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "commerciBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.commerciBox.ForeColor = System.Drawing.SystemColors.Window;
            this.commerciBox.Location = new System.Drawing.Point(12, 231);
            this.commerciBox.Name = "commerciBox";
            this.commerciBox.Size = new System.Drawing.Size(92, 17);
            this.commerciBox.TabIndex = 5;
            this.commerciBox.Text = "Commerci/PQ";
            this.commerciBox.UseVisualStyleBackColor = false;
            this.commerciBox.Click += new System.EventHandler(this.commerciBox_Click);
            // 
            // guildBox
            // 
            this.guildBox.AutoSize = true;
            this.guildBox.BackColor = System.Drawing.Color.Transparent;
            this.guildBox.Checked = global::MapleDX.Properties.Settings.Default.guildBox;
            this.guildBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "guildBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.guildBox.ForeColor = System.Drawing.SystemColors.Window;
            this.guildBox.Location = new System.Drawing.Point(12, 185);
            this.guildBox.Name = "guildBox";
            this.guildBox.Size = new System.Drawing.Size(96, 17);
            this.guildBox.TabIndex = 4;
            this.guildBox.Text = "Guild Check In";
            this.guildBox.UseVisualStyleBackColor = false;
            this.guildBox.Click += new System.EventHandler(this.guildBox_Click);
            // 
            // voteBox
            // 
            this.voteBox.AutoSize = true;
            this.voteBox.BackColor = System.Drawing.Color.Transparent;
            this.voteBox.Checked = global::MapleDX.Properties.Settings.Default.voteBox;
            this.voteBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "voteBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.voteBox.ForeColor = System.Drawing.SystemColors.Window;
            this.voteBox.Location = new System.Drawing.Point(12, 160);
            this.voteBox.Name = "voteBox";
            this.voteBox.Size = new System.Drawing.Size(48, 17);
            this.voteBox.TabIndex = 3;
            this.voteBox.Text = "Vote";
            this.voteBox.UseVisualStyleBackColor = false;
            this.voteBox.Click += new System.EventHandler(this.voteBox_Click);
            // 
            // doneMPBox
            // 
            this.doneMPBox.AutoSize = true;
            this.doneMPBox.BackColor = System.Drawing.Color.Transparent;
            this.doneMPBox.Checked = global::MapleDX.Properties.Settings.Default.monsterBox;
            this.doneMPBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "monsterBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.doneMPBox.ForeColor = System.Drawing.SystemColors.Window;
            this.doneMPBox.Location = new System.Drawing.Point(12, 208);
            this.doneMPBox.Name = "doneMPBox";
            this.doneMPBox.Size = new System.Drawing.Size(89, 17);
            this.doneMPBox.TabIndex = 2;
            this.doneMPBox.Text = "Monster Park";
            this.doneMPBox.UseVisualStyleBackColor = false;
            this.doneMPBox.Click += new System.EventHandler(this.doneMPBox_Click);
            // 
            // doneArcaneBox
            // 
            this.doneArcaneBox.AutoSize = true;
            this.doneArcaneBox.BackColor = System.Drawing.Color.Transparent;
            this.doneArcaneBox.Checked = global::MapleDX.Properties.Settings.Default.arcBox;
            this.doneArcaneBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "arcBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.doneArcaneBox.ForeColor = System.Drawing.SystemColors.Window;
            this.doneArcaneBox.Location = new System.Drawing.Point(118, 99);
            this.doneArcaneBox.Name = "doneArcaneBox";
            this.doneArcaneBox.Size = new System.Drawing.Size(52, 17);
            this.doneArcaneBox.TabIndex = 1;
            this.doneArcaneBox.Text = "Done";
            this.doneArcaneBox.UseVisualStyleBackColor = false;
            this.doneArcaneBox.Click += new System.EventHandler(this.doneArcaneBox_Click);
            // 
            // doneBossBox
            // 
            this.doneBossBox.AutoSize = true;
            this.doneBossBox.BackColor = System.Drawing.Color.Transparent;
            this.doneBossBox.Checked = global::MapleDX.Properties.Settings.Default.ChOne;
            this.doneBossBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "ChOne", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.doneBossBox.ForeColor = System.Drawing.SystemColors.Window;
            this.doneBossBox.Location = new System.Drawing.Point(118, 47);
            this.doneBossBox.Name = "doneBossBox";
            this.doneBossBox.Size = new System.Drawing.Size(52, 17);
            this.doneBossBox.TabIndex = 0;
            this.doneBossBox.Text = "Done";
            this.doneBossBox.UseVisualStyleBackColor = false;
            this.doneBossBox.Click += new System.EventHandler(this.doneBossBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Written in C# by Arhum Nayyar";
            // 
            // statusNameLabel
            // 
            this.statusNameLabel.AutoSize = true;
            this.statusNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.statusNameLabel.Location = new System.Drawing.Point(456, 34);
            this.statusNameLabel.Name = "statusNameLabel";
            this.statusNameLabel.Size = new System.Drawing.Size(48, 16);
            this.statusNameLabel.TabIndex = 23;
            this.statusNameLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statusLabel.Location = new System.Drawing.Point(501, 34);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 16);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "???";
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 6000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MapleDX.Properties.Resources.mpDX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 348);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.legionBox);
            this.Controls.Add(this.fpqBox);
            this.Controls.Add(this.absoBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compText);
            this.Controls.Add(this.completionBar);
            this.Controls.Add(this.ArcaneButton);
            this.Controls.Add(this.bossButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commerciBox);
            this.Controls.Add(this.guildBox);
            this.Controls.Add(this.voteBox);
            this.Controls.Add(this.doneMPBox);
            this.Controls.Add(this.doneArcaneBox);
            this.Controls.Add(this.doneBossBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MapleDX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox doneBossBox;
        private System.Windows.Forms.CheckBox doneArcaneBox;
        private System.Windows.Forms.CheckBox doneMPBox;
        private System.Windows.Forms.CheckBox voteBox;
        private System.Windows.Forms.CheckBox guildBox;
        private System.Windows.Forms.CheckBox commerciBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bossButton;
        private System.Windows.Forms.Button ArcaneButton;
        private System.Windows.Forms.ProgressBar completionBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label compText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox absoBox;
        private System.Windows.Forms.CheckBox fpqBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox legionBox;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer statusTimer;
    }
}

