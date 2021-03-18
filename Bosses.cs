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
    public partial class Bosses : Form
    {
        int completionNumber = 0;
        bool isClosed = false;
        public Bosses()
        {
            InitializeComponent();
        }
        
        public int getBossStatus()
        {
            return completionNumber;
        }

        public bool getFormStatus()
        {
            return isClosed;
        }

        private void Bosses_FormClosed(object sender, FormClosedEventArgs e)
        {
            MapleDX.Properties.Settings.Default.Save();
            isClosed = true;
        }

        private void bossReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to reset Weekly Bosses as well?", "Reset All?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MapleDX.Properties.Settings.Default.bossBarValue = 0;
                MapleDX.Properties.Settings.Default.ZakumBx = false;
                MapleDX.Properties.Settings.Default.cZakumBX = false;
                MapleDX.Properties.Settings.Default.MagnusBX = false;
                MapleDX.Properties.Settings.Default.HillaBX = false;
                MapleDX.Properties.Settings.Default.rootBX = false;
                MapleDX.Properties.Settings.Default.cRootBX = false;
                MapleDX.Properties.Settings.Default.hornBX = false;
                MapleDX.Properties.Settings.Default.ranBX = false;
                MapleDX.Properties.Settings.Default.pinkBX = false;
                MapleDX.Properties.Settings.Default.cPinkBX = false;
                MapleDX.Properties.Settings.Default.golluxBX = false;
                MapleDX.Properties.Settings.Default.cygnusBX = false;
                MapleDX.Properties.Settings.Default.akeBX = false;
                MapleDX.Properties.Settings.Default.arkBX = false;
                MapleDX.Properties.Settings.Default.damBX = false;
                MapleDX.Properties.Settings.Default.dNellBX = false;
                MapleDX.Properties.Settings.Default.gloomBX = false;
                MapleDX.Properties.Settings.Default.lotusBX = false;
                MapleDX.Properties.Settings.Default.lucidBX = false;
                MapleDX.Properties.Settings.Default.willBX = false;
                MapleDX.Properties.Settings.Default.omniBX = false;
                MapleDX.Properties.Settings.Default.papaBX = false;
                MapleDX.Properties.Settings.Default.vonBX = false;
                MapleDX.Properties.Settings.Default.juulBX = false;
                MapleDX.Properties.Settings.Default.bMageBX = false;
                MapleDX.Properties.Settings.Default.princessBX = false;
                MapleDX.Properties.Settings.Default.chillaBX = false;

            }
            else if (dialogResult == DialogResult.No)
            {
                int newBarValue = 0;
                if (MapleDX.Properties.Settings.Default.cZakumBX == true)
                {
                    newBarValue += 5;
                }
                if (MapleDX.Properties.Settings.Default.cygnusBX == true)
                {
                    newBarValue += 5;
                }
                if (MapleDX.Properties.Settings.Default.cRootBX == true)
                {
                    newBarValue += 5;
                }
                if (MapleDX.Properties.Settings.Default.cPinkBX == true)
                {
                    newBarValue += 5;
                }
                if (MapleDX.Properties.Settings.Default.chillaBX == true)
                {
                    newBarValue += 5;
                }
                MapleDX.Properties.Settings.Default.bossBarValue = newBarValue;
                MapleDX.Properties.Settings.Default.ZakumBx = false;
                MapleDX.Properties.Settings.Default.MagnusBX = false;
                MapleDX.Properties.Settings.Default.HillaBX = false;
                MapleDX.Properties.Settings.Default.rootBX = false;
                MapleDX.Properties.Settings.Default.hornBX = false;
                MapleDX.Properties.Settings.Default.ranBX = false;
                MapleDX.Properties.Settings.Default.pinkBX = false;
                MapleDX.Properties.Settings.Default.golluxBX = false;
                MapleDX.Properties.Settings.Default.akeBX = false;
                MapleDX.Properties.Settings.Default.arkBX = false;
                MapleDX.Properties.Settings.Default.damBX = false;
                MapleDX.Properties.Settings.Default.dNellBX = false;
                MapleDX.Properties.Settings.Default.gloomBX = false;
                MapleDX.Properties.Settings.Default.lotusBX = false;
                MapleDX.Properties.Settings.Default.lucidBX = false;
                MapleDX.Properties.Settings.Default.willBX = false;
                MapleDX.Properties.Settings.Default.omniBX = false;
                MapleDX.Properties.Settings.Default.papaBX = false;
                MapleDX.Properties.Settings.Default.vonBX = false;
                MapleDX.Properties.Settings.Default.juulBX = false;
                MapleDX.Properties.Settings.Default.bMageBX = false;
                MapleDX.Properties.Settings.Default.princessBX = false;
            }
        }

        private void bossBarTimer_Tick(object sender, EventArgs e)
        {
            MapleDX.Properties.Settings.Default.Save();
            int percent = (int)(((double)MapleDX.Properties.Settings.Default.bossBarValue / (double)bossBar.Maximum) * 100);
            bossBarText.Text = percent.ToString() + "%";
            bossBar.Refresh();
        }

        private void zakumBox_Click(object sender, EventArgs e)
        {
            if (zakumBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!zakumBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void magBox_Click(object sender, EventArgs e)
        {
            if (magBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!magBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void hillaBox_Click(object sender, EventArgs e)
        {
            if (hillaBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!hillaBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void rootBox_Click(object sender, EventArgs e)
        {
            if (rootBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!rootBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void hornBox_Click(object sender, EventArgs e)
        {
            if (hornBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!hornBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void ranmaruBox_Click(object sender, EventArgs e)
        {
            if (ranmaruBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!ranmaruBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void pinkBox_Click(object sender, EventArgs e)
        {
            if (pinkBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!pinkBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void golluxBox_Click(object sender, EventArgs e)
        {
            if (golluxBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!golluxBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void akechiBox_Click(object sender, EventArgs e)
        {
            if (akechiBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!akechiBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void arkBox_Click(object sender, EventArgs e)
        {
            if (arkBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!arkBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void damBox_Click(object sender, EventArgs e)
        {
            if (damBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!damBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void dNellBox_Click(object sender, EventArgs e)
        {
            if (dNellBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!dNellBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void gloomBox_Click(object sender, EventArgs e)
        {
            if (gloomBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!gloomBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void lotusBox_Click(object sender, EventArgs e)
        {
            if (lotusBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!lotusBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void lucidBox_Click(object sender, EventArgs e)
        {
            if (lucidBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!lucidBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void willBox_Click(object sender, EventArgs e)
        {
            if (willBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!willBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void cZakumBox_Click(object sender, EventArgs e)
        {
            if (cZakumBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!cZakumBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void cygnusBox_Click(object sender, EventArgs e)
        {
            if (cygnusBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!cygnusBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void cRootBox_Click(object sender, EventArgs e)
        {
            if (cRootBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!cRootBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void cPinkBox_Click(object sender, EventArgs e)
        {
            if (cPinkBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!cPinkBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void omniBox_Click(object sender, EventArgs e)
        {
            if (omniBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!omniBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void Bosses_Load(object sender, EventArgs e)
        {
            isClosed = false;
        }

        private void papBox_Click(object sender, EventArgs e)
        {
            if (papBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!papBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void vonBOX_Click(object sender, EventArgs e)
        {
            if (vonBOX.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!vonBOX.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void chillaBox_Click(object sender, EventArgs e)
        {
            if (chillaBox.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!chillaBox.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void bMageBOX_Click(object sender, EventArgs e)
        {
            if (bMageBOX.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!bMageBOX.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void princessBOX_Click(object sender, EventArgs e)
        {
            if (princessBOX.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!princessBOX.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void juulBOX_Click(object sender, EventArgs e)
        {
            if (juulBOX.Checked)
            {
                MapleDX.Properties.Settings.Default.bossBarValue += 5;
                completionNumber++;
            }
            else if (!juulBOX.Checked && MapleDX.Properties.Settings.Default.bossBarValue != 0)
            {
                MapleDX.Properties.Settings.Default.bossBarValue -= 5;
                completionNumber--;
            }
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    
                }
            }
        }
    }
}
