using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Philip_Graham
{
    public partial class RockPaperScissors : Form
    {
        int wins = 0;
        int losses = 0;
        int ties = 0;
        Random generator = new Random();
        public RockPaperScissors()
        {
            InitializeComponent();

        }

        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.istockphoto_170215830_612x612;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources._1_04851_00_BL_Notebook_Paper_Punch_G_600x735;
        }

        private void rdoScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.download;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            

         

            int randomNumber;
            

            randomNumber = generator.Next(1, 4);
            if (randomNumber == 1)
                imgOpponent.Image = Properties.Resources.istockphoto_170215830_612x612;
            if (randomNumber == 2)
                imgOpponent.Image = Properties.Resources._1_04851_00_BL_Notebook_Paper_Punch_G_600x735;
            if (randomNumber == 3)
                imgOpponent.Image = Properties.Resources.download;
            if (randomNumber == 1 && radRock.Checked)
            {
                lblGameResult.Text = ("You tied");
                ties = ties+1;
            }
            if (randomNumber == 2 && radRock.Checked)
            {
                lblGameResult.Text = ("You Lose");
                losses  = losses + 1;
            }
            if (randomNumber == 3 && radRock.Checked)
            {
                lblGameResult.Text = ("You win");
                wins = wins + 1;
            }
            if (randomNumber == 1 && radPaper.Checked)
            {
                lblGameResult.Text = ("You Won");
                wins  = wins +1;
            }
            if (randomNumber == 2 && radPaper.Checked)
            {
                lblGameResult.Text = ("You tied");
                ties = ties + 1;
            }
            if (randomNumber == 3 && radPaper.Checked)
            {
                lblGameResult.Text = ("You lose");
                losses = losses + 1;
            }
            if (randomNumber == 1 && radScissors.Checked)
            {
                lblGameResult.Text = ("You Lose");
                losses = losses +1;
            }
           
            
            if (randomNumber == 2 && radScissors.Checked)
            {
                lblGameResult.Text = ("You Win");
                wins  = wins +1;
             }
            
                
            
            if (randomNumber == 3 && radScissors.Checked)
            {
                lblGameResult.Text = ("You tie");
                ties = ties+1;
            }
            lblNumberOfWins.Text = Convert.ToString(wins);
            lblNumberOfTies.Text = Convert.ToString(ties);
            lblNumberOFLosses.Text = Convert.ToString(losses);



        }
    }
}
