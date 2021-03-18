namespace MapleDX
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.enableAlarm = new System.Windows.Forms.Button();
            this.disableAlarm = new System.Windows.Forms.Button();
            this.alarmClock = new System.Windows.Forms.Timer(this.components);
            this.updateTC = new System.Windows.Forms.Timer(this.components);
            this.setTime = new System.Windows.Forms.Label();
            this.timeControl = new System.Windows.Forms.DateTimePicker();
            this.resetSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enableAlarm
            // 
            this.enableAlarm.Location = new System.Drawing.Point(153, 153);
            this.enableAlarm.Name = "enableAlarm";
            this.enableAlarm.Size = new System.Drawing.Size(75, 23);
            this.enableAlarm.TabIndex = 1;
            this.enableAlarm.Text = "Enable";
            this.enableAlarm.UseVisualStyleBackColor = true;
            this.enableAlarm.Click += new System.EventHandler(this.enableAlarm_Click);
            // 
            // disableAlarm
            // 
            this.disableAlarm.Location = new System.Drawing.Point(245, 153);
            this.disableAlarm.Name = "disableAlarm";
            this.disableAlarm.Size = new System.Drawing.Size(75, 23);
            this.disableAlarm.TabIndex = 2;
            this.disableAlarm.Text = "Disable";
            this.disableAlarm.UseVisualStyleBackColor = true;
            this.disableAlarm.Click += new System.EventHandler(this.disableAlarm_Click);
            // 
            // alarmClock
            // 
            this.alarmClock.Interval = 1000;
            this.alarmClock.Tick += new System.EventHandler(this.alarmClock_Tick);
            // 
            // updateTC
            // 
            this.updateTC.Interval = 50;
            // 
            // setTime
            // 
            this.setTime.AutoSize = true;
            this.setTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MapleDX.Properties.Settings.Default, "almTimeText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.setTime.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::MapleDX.Properties.Settings.Default, "seePrevAlarm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.setTime.Location = new System.Drawing.Point(163, 113);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(35, 13);
            this.setTime.TabIndex = 4;
            this.setTime.Text = global::MapleDX.Properties.Settings.Default.almTimeText;
            this.setTime.Visible = global::MapleDX.Properties.Settings.Default.seePrevAlarm;
            // 
            // timeControl
            // 
            this.timeControl.Checked = false;
            this.timeControl.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MapleDX.Properties.Settings.Default, "alarmTimeValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.timeControl.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeControl.Location = new System.Drawing.Point(194, 113);
            this.timeControl.Name = "timeControl";
            this.timeControl.ShowUpDown = true;
            this.timeControl.Size = new System.Drawing.Size(83, 20);
            this.timeControl.TabIndex = 0;
            this.timeControl.Value = global::MapleDX.Properties.Settings.Default.alarmTimeValue;
            this.timeControl.ValueChanged += new System.EventHandler(this.timeControl_ValueChanged);
            // 
            // resetSave
            // 
            this.resetSave.Location = new System.Drawing.Point(166, 191);
            this.resetSave.Name = "resetSave";
            this.resetSave.Size = new System.Drawing.Size(131, 23);
            this.resetSave.TabIndex = 5;
            this.resetSave.Text = "Reset Saved Alarm";
            this.resetSave.UseVisualStyleBackColor = true;
            this.resetSave.Click += new System.EventHandler(this.resetSave_Click);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MapleDX.Properties.Resources.mpDX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 269);
            this.Controls.Add(this.resetSave);
            this.Controls.Add(this.setTime);
            this.Controls.Add(this.disableAlarm);
            this.Controls.Add(this.enableAlarm);
            this.Controls.Add(this.timeControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alarm_FormClosing);
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeControl;
        private System.Windows.Forms.Button enableAlarm;
        private System.Windows.Forms.Button disableAlarm;
        private System.Windows.Forms.Timer alarmClock;
        private System.Windows.Forms.Label setTime;
        private System.Windows.Forms.Timer updateTC;
        private System.Windows.Forms.Button resetSave;
    }
}