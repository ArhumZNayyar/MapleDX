namespace MapleDX
{
    partial class Arcane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arcane));
            this.arcBarText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arcReset = new System.Windows.Forms.Button();
            this.tenBox = new System.Windows.Forms.CheckBox();
            this.esferaBox = new System.Windows.Forms.CheckBox();
            this.morassBox = new System.Windows.Forms.CheckBox();
            this.arcBar = new System.Windows.Forms.ProgressBar();
            this.arcBox = new System.Windows.Forms.CheckBox();
            this.lachBox = new System.Windows.Forms.CheckBox();
            this.chuBox = new System.Windows.Forms.CheckBox();
            this.vjBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // arcBarText
            // 
            this.arcBarText.AutoSize = true;
            this.arcBarText.BackColor = System.Drawing.Color.Transparent;
            this.arcBarText.ForeColor = System.Drawing.SystemColors.Window;
            this.arcBarText.Location = new System.Drawing.Point(339, 214);
            this.arcBarText.Name = "arcBarText";
            this.arcBarText.Size = new System.Drawing.Size(21, 13);
            this.arcBarText.TabIndex = 5;
            this.arcBarText.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arcReset
            // 
            this.arcReset.Location = new System.Drawing.Point(12, 175);
            this.arcReset.Name = "arcReset";
            this.arcReset.Size = new System.Drawing.Size(75, 23);
            this.arcReset.TabIndex = 6;
            this.arcReset.Text = "Reset";
            this.arcReset.UseVisualStyleBackColor = true;
            this.arcReset.Click += new System.EventHandler(this.arcReset_Click);
            // 
            // tenBox
            // 
            this.tenBox.AutoSize = true;
            this.tenBox.BackColor = System.Drawing.Color.Transparent;
            this.tenBox.Checked = global::MapleDX.Properties.Settings.Default.tenBX;
            this.tenBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "tenBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tenBox.ForeColor = System.Drawing.SystemColors.Window;
            this.tenBox.Location = new System.Drawing.Point(12, 150);
            this.tenBox.Name = "tenBox";
            this.tenBox.Size = new System.Drawing.Size(67, 17);
            this.tenBox.TabIndex = 9;
            this.tenBox.Text = "Tenebris";
            this.tenBox.UseVisualStyleBackColor = false;
            this.tenBox.Click += new System.EventHandler(this.tenBox_Click);
            // 
            // esferaBox
            // 
            this.esferaBox.AutoSize = true;
            this.esferaBox.BackColor = System.Drawing.Color.Transparent;
            this.esferaBox.Checked = global::MapleDX.Properties.Settings.Default.esferaBX;
            this.esferaBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "esferaBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.esferaBox.ForeColor = System.Drawing.SystemColors.Window;
            this.esferaBox.Location = new System.Drawing.Point(12, 127);
            this.esferaBox.Name = "esferaBox";
            this.esferaBox.Size = new System.Drawing.Size(56, 17);
            this.esferaBox.TabIndex = 8;
            this.esferaBox.Text = "Esfera";
            this.esferaBox.UseVisualStyleBackColor = false;
            this.esferaBox.Click += new System.EventHandler(this.esferaBox_Click);
            // 
            // morassBox
            // 
            this.morassBox.AutoSize = true;
            this.morassBox.BackColor = System.Drawing.Color.Transparent;
            this.morassBox.Checked = global::MapleDX.Properties.Settings.Default.morassBX;
            this.morassBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "morassBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.morassBox.ForeColor = System.Drawing.SystemColors.Window;
            this.morassBox.Location = new System.Drawing.Point(12, 104);
            this.morassBox.Name = "morassBox";
            this.morassBox.Size = new System.Drawing.Size(60, 17);
            this.morassBox.TabIndex = 7;
            this.morassBox.Text = "Morass";
            this.morassBox.UseVisualStyleBackColor = false;
            this.morassBox.Click += new System.EventHandler(this.morassBox_Click);
            // 
            // arcBar
            // 
            this.arcBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MapleDX.Properties.Settings.Default, "mainBarValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.arcBar.Location = new System.Drawing.Point(12, 204);
            this.arcBar.Maximum = 70;
            this.arcBar.Name = "arcBar";
            this.arcBar.Size = new System.Drawing.Size(321, 23);
            this.arcBar.TabIndex = 4;
            this.arcBar.Value = global::MapleDX.Properties.Settings.Default.mainBarValue;
            // 
            // arcBox
            // 
            this.arcBox.AutoSize = true;
            this.arcBox.BackColor = System.Drawing.Color.Transparent;
            this.arcBox.Checked = global::MapleDX.Properties.Settings.Default.arcBX;
            this.arcBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "arcBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.arcBox.ForeColor = System.Drawing.SystemColors.Window;
            this.arcBox.Location = new System.Drawing.Point(12, 81);
            this.arcBox.Name = "arcBox";
            this.arcBox.Size = new System.Drawing.Size(60, 17);
            this.arcBox.TabIndex = 3;
            this.arcBox.Text = "Arcana";
            this.arcBox.UseVisualStyleBackColor = false;
            this.arcBox.Click += new System.EventHandler(this.arcBox_Click);
            // 
            // lachBox
            // 
            this.lachBox.AutoSize = true;
            this.lachBox.BackColor = System.Drawing.Color.Transparent;
            this.lachBox.Checked = global::MapleDX.Properties.Settings.Default.lachBX;
            this.lachBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "lachBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lachBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lachBox.Location = new System.Drawing.Point(12, 58);
            this.lachBox.Name = "lachBox";
            this.lachBox.Size = new System.Drawing.Size(72, 17);
            this.lachBox.TabIndex = 2;
            this.lachBox.Text = "Lachelein";
            this.lachBox.UseVisualStyleBackColor = false;
            this.lachBox.Click += new System.EventHandler(this.lachBox_Click);
            // 
            // chuBox
            // 
            this.chuBox.AutoSize = true;
            this.chuBox.BackColor = System.Drawing.Color.Transparent;
            this.chuBox.Checked = global::MapleDX.Properties.Settings.Default.chuBX;
            this.chuBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "chuBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chuBox.ForeColor = System.Drawing.SystemColors.Window;
            this.chuBox.Location = new System.Drawing.Point(12, 35);
            this.chuBox.Name = "chuBox";
            this.chuBox.Size = new System.Drawing.Size(98, 17);
            this.chuBox.TabIndex = 1;
            this.chuBox.Text = "Chu Chu Island";
            this.chuBox.UseVisualStyleBackColor = false;
            this.chuBox.Click += new System.EventHandler(this.chuBox_Click);
            // 
            // vjBox
            // 
            this.vjBox.AutoSize = true;
            this.vjBox.BackColor = System.Drawing.Color.Transparent;
            this.vjBox.Checked = global::MapleDX.Properties.Settings.Default.vjBX;
            this.vjBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "vjBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.vjBox.ForeColor = System.Drawing.SystemColors.Window;
            this.vjBox.Location = new System.Drawing.Point(12, 12);
            this.vjBox.Name = "vjBox";
            this.vjBox.Size = new System.Drawing.Size(112, 17);
            this.vjBox.TabIndex = 0;
            this.vjBox.Text = "Vanishing Journey";
            this.vjBox.UseVisualStyleBackColor = false;
            this.vjBox.Click += new System.EventHandler(this.vjBox_Click);
            // 
            // Arcane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MapleDX.Properties.Resources.mpDX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 239);
            this.Controls.Add(this.tenBox);
            this.Controls.Add(this.esferaBox);
            this.Controls.Add(this.morassBox);
            this.Controls.Add(this.arcReset);
            this.Controls.Add(this.arcBarText);
            this.Controls.Add(this.arcBar);
            this.Controls.Add(this.arcBox);
            this.Controls.Add(this.lachBox);
            this.Controls.Add(this.chuBox);
            this.Controls.Add(this.vjBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arcane";
            this.Text = "Arcane";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arcane_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox vjBox;
        private System.Windows.Forms.CheckBox chuBox;
        private System.Windows.Forms.CheckBox lachBox;
        private System.Windows.Forms.CheckBox arcBox;
        private System.Windows.Forms.ProgressBar arcBar;
        private System.Windows.Forms.Label arcBarText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button arcReset;
        private System.Windows.Forms.CheckBox morassBox;
        private System.Windows.Forms.CheckBox esferaBox;
        private System.Windows.Forms.CheckBox tenBox;
    }
}