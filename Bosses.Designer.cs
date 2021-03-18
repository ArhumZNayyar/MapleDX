namespace MapleDX
{
    partial class Bosses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bosses));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bossBarText = new System.Windows.Forms.Label();
            this.bossReset = new System.Windows.Forms.Button();
            this.bossBarTimer = new System.Windows.Forms.Timer(this.components);
            this.willBox = new System.Windows.Forms.CheckBox();
            this.lucidBox = new System.Windows.Forms.CheckBox();
            this.lotusBox = new System.Windows.Forms.CheckBox();
            this.gloomBox = new System.Windows.Forms.CheckBox();
            this.dNellBox = new System.Windows.Forms.CheckBox();
            this.damBox = new System.Windows.Forms.CheckBox();
            this.arkBox = new System.Windows.Forms.CheckBox();
            this.akechiBox = new System.Windows.Forms.CheckBox();
            this.bossBar = new System.Windows.Forms.ProgressBar();
            this.golluxBox = new System.Windows.Forms.CheckBox();
            this.cPinkBox = new System.Windows.Forms.CheckBox();
            this.cRootBox = new System.Windows.Forms.CheckBox();
            this.cygnusBox = new System.Windows.Forms.CheckBox();
            this.pinkBox = new System.Windows.Forms.CheckBox();
            this.ranmaruBox = new System.Windows.Forms.CheckBox();
            this.hornBox = new System.Windows.Forms.CheckBox();
            this.cZakumBox = new System.Windows.Forms.CheckBox();
            this.rootBox = new System.Windows.Forms.CheckBox();
            this.hillaBox = new System.Windows.Forms.CheckBox();
            this.magBox = new System.Windows.Forms.CheckBox();
            this.zakumBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(108, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 410);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daily";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(135, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weekly";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-2, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 2);
            this.label4.TabIndex = 8;
            // 
            // bossBarText
            // 
            this.bossBarText.AutoSize = true;
            this.bossBarText.BackColor = System.Drawing.Color.Transparent;
            this.bossBarText.ForeColor = System.Drawing.SystemColors.Window;
            this.bossBarText.Location = new System.Drawing.Point(268, 465);
            this.bossBarText.Name = "bossBarText";
            this.bossBarText.Size = new System.Drawing.Size(21, 13);
            this.bossBarText.TabIndex = 17;
            this.bossBarText.Text = "0%";
            // 
            // bossReset
            // 
            this.bossReset.Location = new System.Drawing.Point(12, 426);
            this.bossReset.Name = "bossReset";
            this.bossReset.Size = new System.Drawing.Size(75, 23);
            this.bossReset.TabIndex = 18;
            this.bossReset.Text = "Reset";
            this.bossReset.UseVisualStyleBackColor = true;
            this.bossReset.Click += new System.EventHandler(this.bossReset_Click);
            // 
            // bossBarTimer
            // 
            this.bossBarTimer.Enabled = true;
            this.bossBarTimer.Tick += new System.EventHandler(this.bossBarTimer_Tick);
            // 
            // willBox
            // 
            this.willBox.AutoSize = true;
            this.willBox.BackColor = System.Drawing.Color.Transparent;
            this.willBox.Checked = global::MapleDX.Properties.Settings.Default.willBX;
            this.willBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "willBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.willBox.ForeColor = System.Drawing.SystemColors.Window;
            this.willBox.Location = new System.Drawing.Point(11, 392);
            this.willBox.Name = "willBox";
            this.willBox.Size = new System.Drawing.Size(43, 17);
            this.willBox.TabIndex = 26;
            this.willBox.Text = "Will";
            this.willBox.UseVisualStyleBackColor = false;
            this.willBox.Click += new System.EventHandler(this.willBox_Click);
            // 
            // lucidBox
            // 
            this.lucidBox.AutoSize = true;
            this.lucidBox.BackColor = System.Drawing.Color.Transparent;
            this.lucidBox.Checked = global::MapleDX.Properties.Settings.Default.lucidBX;
            this.lucidBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "lucidBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lucidBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lucidBox.Location = new System.Drawing.Point(11, 369);
            this.lucidBox.Name = "lucidBox";
            this.lucidBox.Size = new System.Drawing.Size(52, 17);
            this.lucidBox.TabIndex = 25;
            this.lucidBox.Text = "Lucid";
            this.lucidBox.UseVisualStyleBackColor = false;
            this.lucidBox.Click += new System.EventHandler(this.lucidBox_Click);
            // 
            // lotusBox
            // 
            this.lotusBox.AutoSize = true;
            this.lotusBox.BackColor = System.Drawing.Color.Transparent;
            this.lotusBox.Checked = global::MapleDX.Properties.Settings.Default.lotusBX;
            this.lotusBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "lotusBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lotusBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lotusBox.Location = new System.Drawing.Point(11, 346);
            this.lotusBox.Name = "lotusBox";
            this.lotusBox.Size = new System.Drawing.Size(52, 17);
            this.lotusBox.TabIndex = 24;
            this.lotusBox.Text = "Lotus";
            this.lotusBox.UseVisualStyleBackColor = false;
            this.lotusBox.Click += new System.EventHandler(this.lotusBox_Click);
            // 
            // gloomBox
            // 
            this.gloomBox.AutoSize = true;
            this.gloomBox.BackColor = System.Drawing.Color.Transparent;
            this.gloomBox.Checked = global::MapleDX.Properties.Settings.Default.gloomBX;
            this.gloomBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "gloomBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gloomBox.ForeColor = System.Drawing.SystemColors.Window;
            this.gloomBox.Location = new System.Drawing.Point(12, 323);
            this.gloomBox.Name = "gloomBox";
            this.gloomBox.Size = new System.Drawing.Size(56, 17);
            this.gloomBox.TabIndex = 23;
            this.gloomBox.Text = "Gloom";
            this.gloomBox.UseVisualStyleBackColor = false;
            this.gloomBox.Click += new System.EventHandler(this.gloomBox_Click);
            // 
            // dNellBox
            // 
            this.dNellBox.AutoSize = true;
            this.dNellBox.BackColor = System.Drawing.Color.Transparent;
            this.dNellBox.Checked = global::MapleDX.Properties.Settings.Default.dNellBX;
            this.dNellBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "dNellBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dNellBox.ForeColor = System.Drawing.SystemColors.Window;
            this.dNellBox.Location = new System.Drawing.Point(12, 300);
            this.dNellBox.Name = "dNellBox";
            this.dNellBox.Size = new System.Drawing.Size(65, 17);
            this.dNellBox.TabIndex = 22;
            this.dNellBox.Text = "Darknell";
            this.dNellBox.UseVisualStyleBackColor = false;
            this.dNellBox.Click += new System.EventHandler(this.dNellBox_Click);
            // 
            // damBox
            // 
            this.damBox.AutoSize = true;
            this.damBox.BackColor = System.Drawing.Color.Transparent;
            this.damBox.Checked = global::MapleDX.Properties.Settings.Default.damBX;
            this.damBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "damBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.damBox.ForeColor = System.Drawing.SystemColors.Window;
            this.damBox.Location = new System.Drawing.Point(12, 277);
            this.damBox.Name = "damBox";
            this.damBox.Size = new System.Drawing.Size(62, 17);
            this.damBox.TabIndex = 21;
            this.damBox.Text = "Damien";
            this.damBox.UseVisualStyleBackColor = false;
            this.damBox.Click += new System.EventHandler(this.damBox_Click);
            // 
            // arkBox
            // 
            this.arkBox.AutoSize = true;
            this.arkBox.BackColor = System.Drawing.Color.Transparent;
            this.arkBox.Checked = global::MapleDX.Properties.Settings.Default.arkBX;
            this.arkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "arkBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.arkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.arkBox.Location = new System.Drawing.Point(12, 254);
            this.arkBox.Name = "arkBox";
            this.arkBox.Size = new System.Drawing.Size(67, 17);
            this.arkBox.TabIndex = 20;
            this.arkBox.Text = "Arkarium";
            this.arkBox.UseVisualStyleBackColor = false;
            this.arkBox.Click += new System.EventHandler(this.arkBox_Click);
            // 
            // akechiBox
            // 
            this.akechiBox.AutoSize = true;
            this.akechiBox.BackColor = System.Drawing.Color.Transparent;
            this.akechiBox.Checked = global::MapleDX.Properties.Settings.Default.akeBX;
            this.akechiBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "akeBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.akechiBox.ForeColor = System.Drawing.SystemColors.Window;
            this.akechiBox.Location = new System.Drawing.Point(12, 231);
            this.akechiBox.Name = "akechiBox";
            this.akechiBox.Size = new System.Drawing.Size(59, 17);
            this.akechiBox.TabIndex = 19;
            this.akechiBox.Text = "Akechi";
            this.akechiBox.UseVisualStyleBackColor = false;
            this.akechiBox.Click += new System.EventHandler(this.akechiBox_Click);
            // 
            // bossBar
            // 
            this.bossBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MapleDX.Properties.Settings.Default, "bossBarValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bossBar.ForeColor = System.Drawing.Color.Red;
            this.bossBar.Location = new System.Drawing.Point(15, 455);
            this.bossBar.Name = "bossBar";
            this.bossBar.Size = new System.Drawing.Size(247, 23);
            this.bossBar.TabIndex = 16;
            this.bossBar.Value = global::MapleDX.Properties.Settings.Default.bossBarValue;
            // 
            // golluxBox
            // 
            this.golluxBox.AutoSize = true;
            this.golluxBox.BackColor = System.Drawing.Color.Transparent;
            this.golluxBox.Checked = global::MapleDX.Properties.Settings.Default.golluxBX;
            this.golluxBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "golluxBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.golluxBox.ForeColor = System.Drawing.SystemColors.Window;
            this.golluxBox.Location = new System.Drawing.Point(12, 208);
            this.golluxBox.Name = "golluxBox";
            this.golluxBox.Size = new System.Drawing.Size(55, 17);
            this.golluxBox.TabIndex = 15;
            this.golluxBox.Text = "Gollux";
            this.golluxBox.UseVisualStyleBackColor = false;
            this.golluxBox.Click += new System.EventHandler(this.golluxBox_Click);
            // 
            // cPinkBox
            // 
            this.cPinkBox.AutoSize = true;
            this.cPinkBox.BackColor = System.Drawing.Color.Transparent;
            this.cPinkBox.Checked = global::MapleDX.Properties.Settings.Default.cPinkBX;
            this.cPinkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "cPinkBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cPinkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cPinkBox.Location = new System.Drawing.Point(135, 116);
            this.cPinkBox.Name = "cPinkBox";
            this.cPinkBox.Size = new System.Drawing.Size(105, 17);
            this.cPinkBox.TabIndex = 14;
            this.cPinkBox.Text = "Chaos PinkBean";
            this.cPinkBox.UseVisualStyleBackColor = false;
            this.cPinkBox.Click += new System.EventHandler(this.cPinkBox_Click);
            // 
            // cRootBox
            // 
            this.cRootBox.AutoSize = true;
            this.cRootBox.BackColor = System.Drawing.Color.Transparent;
            this.cRootBox.Checked = global::MapleDX.Properties.Settings.Default.cRootBX;
            this.cRootBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "cRootBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cRootBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cRootBox.Location = new System.Drawing.Point(135, 93);
            this.cRootBox.Name = "cRootBox";
            this.cRootBox.Size = new System.Drawing.Size(113, 17);
            this.cRootBox.TabIndex = 13;
            this.cRootBox.Text = "Chaos Root Abyss";
            this.cRootBox.UseVisualStyleBackColor = false;
            this.cRootBox.Click += new System.EventHandler(this.cRootBox_Click);
            // 
            // cygnusBox
            // 
            this.cygnusBox.AutoSize = true;
            this.cygnusBox.BackColor = System.Drawing.Color.Transparent;
            this.cygnusBox.Checked = global::MapleDX.Properties.Settings.Default.cygnusBX;
            this.cygnusBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "cygnusBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cygnusBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cygnusBox.Location = new System.Drawing.Point(135, 70);
            this.cygnusBox.Name = "cygnusBox";
            this.cygnusBox.Size = new System.Drawing.Size(61, 17);
            this.cygnusBox.TabIndex = 12;
            this.cygnusBox.Text = "Cygnus";
            this.cygnusBox.UseVisualStyleBackColor = false;
            this.cygnusBox.Click += new System.EventHandler(this.cygnusBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.AutoSize = true;
            this.pinkBox.BackColor = System.Drawing.Color.Transparent;
            this.pinkBox.Checked = global::MapleDX.Properties.Settings.Default.pinkBX;
            this.pinkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "pinkBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pinkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.pinkBox.Location = new System.Drawing.Point(12, 185);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(72, 17);
            this.pinkBox.TabIndex = 11;
            this.pinkBox.Text = "PinkBean";
            this.pinkBox.UseVisualStyleBackColor = false;
            this.pinkBox.Click += new System.EventHandler(this.pinkBox_Click);
            // 
            // ranmaruBox
            // 
            this.ranmaruBox.AutoSize = true;
            this.ranmaruBox.BackColor = System.Drawing.Color.Transparent;
            this.ranmaruBox.Checked = global::MapleDX.Properties.Settings.Default.ranBX;
            this.ranmaruBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "ranBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ranmaruBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ranmaruBox.Location = new System.Drawing.Point(12, 162);
            this.ranmaruBox.Name = "ranmaruBox";
            this.ranmaruBox.Size = new System.Drawing.Size(69, 17);
            this.ranmaruBox.TabIndex = 10;
            this.ranmaruBox.Text = "Ranmaru";
            this.ranmaruBox.UseVisualStyleBackColor = false;
            this.ranmaruBox.Click += new System.EventHandler(this.ranmaruBox_Click);
            // 
            // hornBox
            // 
            this.hornBox.AutoSize = true;
            this.hornBox.BackColor = System.Drawing.Color.Transparent;
            this.hornBox.Checked = global::MapleDX.Properties.Settings.Default.hornBX;
            this.hornBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "hornBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hornBox.ForeColor = System.Drawing.SystemColors.Window;
            this.hornBox.Location = new System.Drawing.Point(12, 139);
            this.hornBox.Name = "hornBox";
            this.hornBox.Size = new System.Drawing.Size(62, 17);
            this.hornBox.TabIndex = 9;
            this.hornBox.Text = "Horntail";
            this.hornBox.UseVisualStyleBackColor = false;
            this.hornBox.Click += new System.EventHandler(this.hornBox_Click);
            // 
            // cZakumBox
            // 
            this.cZakumBox.AutoSize = true;
            this.cZakumBox.BackColor = System.Drawing.Color.Transparent;
            this.cZakumBox.Checked = global::MapleDX.Properties.Settings.Default.cZakumBX;
            this.cZakumBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "cZakumBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cZakumBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cZakumBox.Location = new System.Drawing.Point(135, 47);
            this.cZakumBox.Name = "cZakumBox";
            this.cZakumBox.Size = new System.Drawing.Size(92, 17);
            this.cZakumBox.TabIndex = 7;
            this.cZakumBox.Text = "Chaos Zakum";
            this.cZakumBox.UseVisualStyleBackColor = false;
            this.cZakumBox.Click += new System.EventHandler(this.cZakumBox_Click);
            // 
            // rootBox
            // 
            this.rootBox.AutoSize = true;
            this.rootBox.BackColor = System.Drawing.Color.Transparent;
            this.rootBox.Checked = global::MapleDX.Properties.Settings.Default.rootBX;
            this.rootBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "rootBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rootBox.ForeColor = System.Drawing.SystemColors.Window;
            this.rootBox.Location = new System.Drawing.Point(12, 116);
            this.rootBox.Name = "rootBox";
            this.rootBox.Size = new System.Drawing.Size(80, 17);
            this.rootBox.TabIndex = 3;
            this.rootBox.Text = "Root Abyss";
            this.rootBox.UseVisualStyleBackColor = false;
            this.rootBox.Click += new System.EventHandler(this.rootBox_Click);
            // 
            // hillaBox
            // 
            this.hillaBox.AutoSize = true;
            this.hillaBox.BackColor = System.Drawing.Color.Transparent;
            this.hillaBox.Checked = global::MapleDX.Properties.Settings.Default.HillaBX;
            this.hillaBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "HillaBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hillaBox.ForeColor = System.Drawing.SystemColors.Window;
            this.hillaBox.Location = new System.Drawing.Point(12, 93);
            this.hillaBox.Name = "hillaBox";
            this.hillaBox.Size = new System.Drawing.Size(46, 17);
            this.hillaBox.TabIndex = 2;
            this.hillaBox.Text = "Hilla";
            this.hillaBox.UseVisualStyleBackColor = false;
            this.hillaBox.Click += new System.EventHandler(this.hillaBox_Click);
            // 
            // magBox
            // 
            this.magBox.AutoSize = true;
            this.magBox.BackColor = System.Drawing.Color.Transparent;
            this.magBox.Checked = global::MapleDX.Properties.Settings.Default.MagnusBX;
            this.magBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "MagnusBX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.magBox.ForeColor = System.Drawing.SystemColors.Window;
            this.magBox.Location = new System.Drawing.Point(12, 70);
            this.magBox.Name = "magBox";
            this.magBox.Size = new System.Drawing.Size(64, 17);
            this.magBox.TabIndex = 1;
            this.magBox.Text = "Magnus";
            this.magBox.UseVisualStyleBackColor = false;
            this.magBox.Click += new System.EventHandler(this.magBox_Click);
            // 
            // zakumBox
            // 
            this.zakumBox.AutoSize = true;
            this.zakumBox.BackColor = System.Drawing.Color.Transparent;
            this.zakumBox.Checked = global::MapleDX.Properties.Settings.Default.ZakumBx;
            this.zakumBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MapleDX.Properties.Settings.Default, "ZakumBx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zakumBox.ForeColor = System.Drawing.SystemColors.Window;
            this.zakumBox.Location = new System.Drawing.Point(12, 47);
            this.zakumBox.Name = "zakumBox";
            this.zakumBox.Size = new System.Drawing.Size(59, 17);
            this.zakumBox.TabIndex = 0;
            this.zakumBox.Text = "Zakum";
            this.zakumBox.UseVisualStyleBackColor = false;
            this.zakumBox.Click += new System.EventHandler(this.zakumBox_Click);
            // 
            // Bosses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MapleDX.Properties.Resources.mpDX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 490);
            this.Controls.Add(this.willBox);
            this.Controls.Add(this.lucidBox);
            this.Controls.Add(this.lotusBox);
            this.Controls.Add(this.gloomBox);
            this.Controls.Add(this.dNellBox);
            this.Controls.Add(this.damBox);
            this.Controls.Add(this.arkBox);
            this.Controls.Add(this.akechiBox);
            this.Controls.Add(this.bossReset);
            this.Controls.Add(this.bossBarText);
            this.Controls.Add(this.bossBar);
            this.Controls.Add(this.golluxBox);
            this.Controls.Add(this.cPinkBox);
            this.Controls.Add(this.cRootBox);
            this.Controls.Add(this.cygnusBox);
            this.Controls.Add(this.pinkBox);
            this.Controls.Add(this.ranmaruBox);
            this.Controls.Add(this.hornBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cZakumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rootBox);
            this.Controls.Add(this.hillaBox);
            this.Controls.Add(this.magBox);
            this.Controls.Add(this.zakumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bosses";
            this.Text = "Bosses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bosses_FormClosed);
            this.Load += new System.EventHandler(this.Bosses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zakumBox;
        private System.Windows.Forms.CheckBox magBox;
        private System.Windows.Forms.CheckBox hillaBox;
        private System.Windows.Forms.CheckBox rootBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cZakumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hornBox;
        private System.Windows.Forms.CheckBox ranmaruBox;
        private System.Windows.Forms.CheckBox pinkBox;
        private System.Windows.Forms.CheckBox cygnusBox;
        private System.Windows.Forms.CheckBox cRootBox;
        private System.Windows.Forms.CheckBox cPinkBox;
        private System.Windows.Forms.CheckBox golluxBox;
        private System.Windows.Forms.ProgressBar bossBar;
        private System.Windows.Forms.Label bossBarText;
        private System.Windows.Forms.Button bossReset;
        private System.Windows.Forms.CheckBox akechiBox;
        private System.Windows.Forms.CheckBox arkBox;
        private System.Windows.Forms.CheckBox damBox;
        private System.Windows.Forms.CheckBox dNellBox;
        private System.Windows.Forms.CheckBox gloomBox;
        private System.Windows.Forms.CheckBox lotusBox;
        private System.Windows.Forms.CheckBox lucidBox;
        private System.Windows.Forms.CheckBox willBox;
        private System.Windows.Forms.Timer bossBarTimer;
    }
}