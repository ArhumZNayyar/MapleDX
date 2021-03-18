using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MapleDX
{
    public partial class Alarm : Form
    {
        DateTimePicker newClock = new DateTimePicker();
        string currentTime = DateTime.Now.ToString("HH:mm:ss");
        long aTime = 0;
        long nTime = 0;
        string alarmTime = "";
        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void enableAlarm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(MapleDX.Properties.Settings.Default.alarmTimeValue.ToString(), "current time!!");
            if (MapleDX.Properties.Settings.Default.alarmTimeValue.ToString() == "3/17/2021 5:15:25 AM")
            {
                setTime.Visible = true;
                setTime.Text = "Recurring Daily Alarm: " + newClock.Value.ToString("hh:mm:ss tt");
                
                alarmTime = newClock.Value.ToString("HHmmss");
                aTime = long.Parse(alarmTime);
                //MessageBox.Show(aTime.ToString(), "aTime");
                // MessageBox.Show(alarmTime, "SET TIME");
                try
                {
                    MapleDX.Properties.Settings.Default.alarmTimeValue = newClock.Value;
                    MapleDX.Properties.Settings.Default.seePrevAlarm = true;
                    MapleDX.Properties.Settings.Default.Save();
                }
                catch
                {
                    MessageBox.Show("ERROR SAVING ALARM!", "Oh no!");
                }
                newClock.Visible = false;
                alarmClock.Start();
                MessageBox.Show("Alarm set for " + newClock.Value.ToString("hh:mm:ss tt") + " You can close this window now :)", "ALARM");
            }
            else if (MapleDX.Properties.Settings.Default.alarmTimeValue.ToString() != "3/17/2021 5:15:25 AM")
            {
                MessageBox.Show("Using Previous Alarm set for " + timeControl.Value.ToString("hh:mm:ss tt") + " You can close this window now :)", "ALARM");

                //MessageBox.Show(nTime.ToString(), "nTime");
                alarmTime = timeControl.Value.ToString("HHmmss");
                aTime = long.Parse(alarmTime);
                //MessageBox.Show(aTime.ToString(), "aTime");
                // MessageBox.Show(alarmTime, "SET TIME");
                MapleDX.Properties.Settings.Default.Save();
                alarmClock.Start();
            }
  
        }

        private void alarmClock_Tick(object sender, EventArgs e)
        {
            nTime = long.Parse(DateTime.Now.ToString("HHmmss"));
            //MessageBox.Show("nTime = " + nTime + " aTime = " + aTime);
            if (nTime >= aTime)
            {
                alarmClock.Stop();
                SoundPlayer simpleSound = new SoundPlayer(@"alarmRing.wav");
                simpleSound.Play();
                //SystemSounds.Exclamation.Play();
                MessageBox.Show("You may now vote!", "Hooray!");
                simpleSound.Stop();
            }
        }

        private void disableAlarm_Click(object sender, EventArgs e)
        {
            alarmClock.Stop();
            alarmTime = "";
            aTime = 0;
            nTime = 0;
            MessageBox.Show("Alarm Disabled.");
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            if (MapleDX.Properties.Settings.Default.alarmTimeValue.ToString() == "3/17/2021 5:15:25 AM")
            {
                
                newClock.Checked = false;
                newClock.Font = new System.Drawing.Font("Verdana", 9.75F);
                newClock.Format = System.Windows.Forms.DateTimePickerFormat.Time;
                newClock.Location = new System.Drawing.Point(194, 113);
                newClock.Name = "newClock";
                newClock.ShowUpDown = true;
                newClock.Size = new System.Drawing.Size(120, 25);
                newClock.Visible = false;
                this.Controls.Add(newClock);
                newClock.Visible = true;
                newClock.Value = MapleDX.Properties.Settings.Default.alarmTimeValue;
                newClock.Enabled = true;
                timeControl.Visible = false;
                timeControl.Enabled = false;
            }
            else if (MapleDX.Properties.Settings.Default.alarmTimeValue.ToString() != "3/17/2021 5:15:25 AM")
            {
                timeControl.Visible = false;
                newClock.Visible = false;
                newClock.Enabled = false;
                timeControl.Enabled = false;
                
            }
            //timeControl.Visible = true;
            //timeControl.Value = MapleDX.Properties.Settings.Default.alarmTimeValue;
            //timeControl.Value = MapleDX.Properties.Settings.Default.alarmTimeValue;
            //timeControl.Value.Equals(MapleDX.Properties.Settings.Default.alarmTimeValue);
            //MessageBox.Show(timeControl.Value.ToString());
            //timeControl.Text = MapleDX.Properties.Settings.Default.alarmTimeValue.ToString("HH:mm:ss");
           // updateTC.Start();
        }

        private void updateTC_Tick(object sender, EventArgs e)
        {
            timeControl.Value = MapleDX.Properties.Settings.Default.alarmTimeValue;
            timeControl.Text = MapleDX.Properties.Settings.Default.alarmTimeValue.ToString("HH:mm:ss");
            timeControl.Value.Equals(MapleDX.Properties.Settings.Default.alarmTimeValue);
            //prevDay.Text = MapleDX.Properties.Settings.Default.alarmTimeValue.ToString();
            // timeControl.Update();
            // timeControl.Refresh();
        }

        private void timeControl_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Value changed...");
        }

        private void resetSave_Click(object sender, EventArgs e)
        {

            MapleDX.Properties.Settings.Default.alarmTimeValue = new DateTime(2021, 3, 17, 5, 15, 25);
            MessageBox.Show("Reset back to default: " + MapleDX.Properties.Settings.Default.alarmTimeValue.ToString());
            setTime.Visible = false;
            Alarm_Load(sender, e);
        }
    }
}
