using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleDX
{
    public partial class Arcane : Form
    {
        public Arcane()
        {
            InitializeComponent();
        }

        private void Arcane_FormClosed(object sender, FormClosedEventArgs e)
        {
            MapleDX.Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MapleDX.Properties.Settings.Default.Save();
            // Form1 mainForm = new Form1();
            //mainForm.SaveCheckState();
            int percent = (int)(((double)MapleDX.Properties.Settings.Default.mainBarValue / (double)arcBar.Maximum) * 100);
            arcBarText.Text = percent.ToString() + "%";
            arcBar.Refresh();
        }

        private void arcReset_Click(object sender, EventArgs e)
        {
            MapleDX.Properties.Settings.Default.mainBarValue = 0;
            MapleDX.Properties.Settings.Default.chuBX = false;
            MapleDX.Properties.Settings.Default.lachBX = false;
            MapleDX.Properties.Settings.Default.vjBX = false;
            MapleDX.Properties.Settings.Default.arcBX = false;
            MapleDX.Properties.Settings.Default.morassBX = false;
            MapleDX.Properties.Settings.Default.esferaBX = false;
            MapleDX.Properties.Settings.Default.tenBX = false;
        }

        private void vjBox_Click(object sender, EventArgs e)
        {
            if (vjBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!vjBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void chuBox_Click(object sender, EventArgs e)
        {
            if (chuBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!chuBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void lachBox_Click(object sender, EventArgs e)
        {
            if (lachBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!lachBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void arcBox_Click(object sender, EventArgs e)
        {
            if (arcBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!arcBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void morassBox_Click(object sender, EventArgs e)
        {
            if (morassBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!morassBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void esferaBox_Click(object sender, EventArgs e)
        {
            if (esferaBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!esferaBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }

        private void tenBox_Click(object sender, EventArgs e)
        {
            if (tenBox.Checked)
            {
                MapleDX.Properties.Settings.Default.mainBarValue += 10;
            }
            else if (!tenBox.Checked && MapleDX.Properties.Settings.Default.mainBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.mainBarValue -= 10;
            }
        }
    }
}
