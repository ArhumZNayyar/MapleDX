using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net.Sockets;

namespace MapleDX
{
    public partial class Form1 : Form
    {
        Alarm almForm = new Alarm();
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Form1()
        {
            InitializeComponent();
        }

        public void SaveCheckState()
        {
            MapleDX.Properties.Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveCheckState();
        }

        private void bossButton_Click(object sender, EventArgs e)
        {
            Bosses bForm = new Bosses();
            bForm.Show();
        }

        private void ArcaneButton_Click(object sender, EventArgs e)
        {
            Arcane aForm = new Arcane();
            aForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveCheckState();
            int percent = (int)(((double)MapleDX.Properties.Settings.Default.compBarVal / (double)completionBar.Maximum) * 100);
            compText.Text = percent.ToString() + "%";
            completionBar.Refresh();
        }

        private void doneBossBox_Click(object sender, EventArgs e)
        {
            if (doneBossBox.Checked)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (!doneBossBox.Checked && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void doneArcaneBox_Click(object sender, EventArgs e)
        {
            if (doneArcaneBox.Checked)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (!doneArcaneBox.Checked && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void doneMPBox_Click(object sender, EventArgs e)
        {
            if (doneMPBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (doneMPBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void voteBox_Click(object sender, EventArgs e)
        {
            if (voteBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (voteBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void guildBox_Click(object sender, EventArgs e)
        {
            if (guildBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (guildBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void commerciBox_Click(object sender, EventArgs e)
        {
            if (commerciBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (commerciBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void absoBox_Click(object sender, EventArgs e)
        {
            if (absoBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (absoBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }


        private void fpqBox_Click(object sender, EventArgs e)
        {
            if (fpqBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (fpqBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void legionBox_Click(object sender, EventArgs e)
        {
            if (legionBox.Checked == true)
            {
                MapleDX.Properties.Settings.Default.compBarVal += 10;
            }
            else if (legionBox.Checked == false && MapleDX.Properties.Settings.Default.compBarVal != 0)
            {
                MapleDX.Properties.Settings.Default.compBarVal -= 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (System.IO.File.Exists("C:\\Ristonia\\appdata\\Ristonia.exe"))
            if (System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Ristonia.exe")))
            {
                try
                {
                    System.Diagnostics.Process.Start("Ristonia.exe");
                }
                catch
                {
                    MessageBox.Show("Your Ristionia.exe file path is incorrect.", "Invalid file path");
                }
            }
            else if (!System.IO.File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Ristonia.exe")))
            {
                MessageBox.Show("Your Ristionia.exe file path is incorrect.", "Invalid file path");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MapleDX.Properties.Settings.Default.compBarVal = 0;
            MapleDX.Properties.Settings.Default.ChOne = false;
            MapleDX.Properties.Settings.Default.arcBox = false;
            MapleDX.Properties.Settings.Default.monsterBox = false;
            MapleDX.Properties.Settings.Default.commerciBox = false;
            MapleDX.Properties.Settings.Default.guildBox = false;
            MapleDX.Properties.Settings.Default.voteBox = false;
            MapleDX.Properties.Settings.Default.absoBX = false;
            MapleDX.Properties.Settings.Default.fpqBX = false;
            MapleDX.Properties.Settings.Default.legionBX = false;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.UtcNow.ToString("HH:mm:ss") + " UTC";
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            almForm.Show();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect("164.132.200.143", 14999); //cs port
                statusLabel.ForeColor = System.Drawing.Color.Lime;
                statusLabel.Text = "Online";
                statusTimer.Stop();
                MessageBox.Show("Server is now Online!", "Yay!");
            }
            catch (Exception)
            {
                statusLabel.ForeColor = System.Drawing.Color.Red;
                statusLabel.Text = "Offline";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                TcpClient tcpClient = new TcpClient();
                try
                {
                    tcpClient.Connect("164.132.200.143", 14999); //cs port
                    statusLabel.ForeColor = System.Drawing.Color.Lime;
                    statusLabel.Text = "Online";
            }
                catch (Exception)
                {
                    statusLabel.ForeColor = System.Drawing.Color.Red;
                    statusLabel.Text = "Offline";
                    statusTimer.Enabled = true;
                    statusTimer.Start();
                }
            
        }
    }
}
