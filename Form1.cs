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
            
        }
    }
}
