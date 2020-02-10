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

namespace Tondkhani
{
    public partial class Ball : Form
    {
        public Ball()
        {
            InitializeComponent();
        }
        private void picBall_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\sound\ball.wav");
            sound.Play();
            picBall.Left = rnd.Next(0,714);
            picBall.Top = rnd.Next(0, 464);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
               picBall.Visible = true;
            lblBorder.Text = "";
        }
    }
}
