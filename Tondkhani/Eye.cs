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
    public partial class Eye : Form
    {
        public Eye()
        {
            InitializeComponent();
        }
        bool on = true;
        bool Left = false;
        int confirm;
        bool up = false;
        int num=0, num2=0;
        public void Music(bool state)
        {
            SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\sound\1.wav");
            if (state == true)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num++;
                if (num < confirm)
                {
                    if (pictureBox1.Location == new Point(190, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(375, 0);
                    }
                    else if (pictureBox1.Location == new Point(375, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(560, 500);
                    }
                    else if (pictureBox1.Location == new Point(560, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(740, 210);
                    }
                    else if (pictureBox1.Location == new Point(740, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 210);
                    }
                    else if (pictureBox1.Location == new Point(0, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(190, 500);
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 505);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 1)
            {
                num++;
                if (num < confirm)
                {
                    if (pictureBox1.Location == new Point(0, 505))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(737, 0);
                    }
                    else if (pictureBox1.Location == new Point(737, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 0);
                    }
                    else if (pictureBox1.Location == new Point(0, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(740, 505);
                    }
                    else if (pictureBox1.Location == new Point(740, 505))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 505);
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 0);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 2)
            {
                num++;
                if (num < confirm)
                {
                    if (up == false)
                    {
                        if (pictureBox1.Location.X == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(740, pictureBox1.Height + pictureBox1.Top);

                        }
                        else if (pictureBox1.Location.X == 740)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(0, pictureBox1.Height + pictureBox1.Top);
                            if (pictureBox1.Location.Y >= 455)
                            {
                                up = true;
                            }
                        }
                    }
                    else
                    {
                        if (pictureBox1.Location.X == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(740, pictureBox1.Top - pictureBox1.Height);

                        }
                        else if (pictureBox1.Location.X == 740)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(0, pictureBox1.Top - pictureBox1.Height);
                            if (pictureBox1.Location.Y == 0)
                            {
                                up = false;
                            }
                        }
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 505);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 3)
            {
                num++;
                if (num < confirm)
                {
                    if (Left == false)
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 505);
                            if (pictureBox1.Location.X == 720)
                            {
                                Left = true;
                            }
                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 0);

                        }
                    }
                    else
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 505);

                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 0);
                            if (pictureBox1.Location.X < 0)
                            {
                                pictureBox1.Left = 0;
                                pictureBox1.Top = 505;
                                Left = false;
                            }
                        }
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(190, 500);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
           else if (num2 == 4)
            {
                num++;
                if (num < confirm)
                {
                    if (pictureBox1.Location == new Point(190, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(375, 0);
                    }
                    else if (pictureBox1.Location == new Point(375, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(560, 500);
                    }
                    else if (pictureBox1.Location == new Point(560, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(740, 210);
                    }
                    else if (pictureBox1.Location == new Point(740, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 210);
                    }
                    else if (pictureBox1.Location == new Point(0, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(190, 500);
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    num = 0;
                    pictureBox1.Location = new Point(0, 505);
                }
            }
           else if (num2 == 5)
            {
                num++;
                if (num < confirm)
                {
                    if (pictureBox1.Location == new Point(0, 505))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(737, 0);
                    }
                    else if (pictureBox1.Location == new Point(737, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 0);
                    }
                    else if (pictureBox1.Location == new Point(0, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(740, 505);
                    }
                    else if (pictureBox1.Location == new Point(740, 505))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 505);
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 505);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 6)
            {
                num++;
                if (num < confirm)
                {
                    if (Left == false)
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 505);
                            if (pictureBox1.Location.X == 720)
                            {
                                Left = true;
                            }
                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 0);

                        }
                    }
                    else
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 505);

                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 0);
                            if (pictureBox1.Location.X < 0)
                            {
                                pictureBox1.Left = 0;
                                pictureBox1.Top = 505;
                                Left = false;
                            }
                        }
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 0);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 7)
            {
                num++;
                if (num < confirm)
                {
                    if (up == false)
                    {
                        if (pictureBox1.Location.X == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(740, pictureBox1.Height + pictureBox1.Top);

                        }
                        else if (pictureBox1.Location.X == 740)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(0, pictureBox1.Height + pictureBox1.Top);
                            if (pictureBox1.Location.Y >= 455)
                            {
                                up = true;
                            }
                        }
                    }
                    else
                    {
                        if (pictureBox1.Location.X == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(740, pictureBox1.Top - pictureBox1.Height);

                        }
                        else if (pictureBox1.Location.X == 740)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(0, pictureBox1.Top - pictureBox1.Height);
                            if (pictureBox1.Location.Y == 0)
                            {
                                up = false;
                            }
                        }
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(0, 505);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 8)
            {
                num++;
                if (num < confirm)
                {
                    if (Left == false)
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 505);
                            if (pictureBox1.Location.X == 720)
                            {
                                Left = true;
                            }
                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Width + pictureBox1.Left, 0);

                        }
                    }
                    else
                    {
                        if (pictureBox1.Location.Y == 0)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 505);

                        }
                        else if (pictureBox1.Location.Y == 505)
                        {
                            Music(on);
                            pictureBox1.Location = new Point(pictureBox1.Left - pictureBox1.Width, 0);
                            if (pictureBox1.Location.X < 0)
                            {
                                pictureBox1.Left = 0;
                                pictureBox1.Top = 505;
                                Left = false;
                            }
                        }
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    pictureBox1.Location = new Point(190, 500);
                    lblBorder.Text = "تصویر را دنبال کنید.";
                    num = 0;
                }
            }
            else if (num2 == 9)
            {
                num++;
                if (num < confirm)
                {
                    if (pictureBox1.Location == new Point(190, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(375, 0);
                    }
                    else if (pictureBox1.Location == new Point(375, 0))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(560, 500);
                    }
                    else if (pictureBox1.Location == new Point(560, 500))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(740, 210);
                    }
                    else if (pictureBox1.Location == new Point(740, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(0, 210);
                    }
                    else if (pictureBox1.Location == new Point(0, 210))
                    {
                        Music(on);
                        pictureBox1.Location = new Point(190, 500);
                    }
                }
                else
                {
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    num = 0;
                    on = false;
                    Music(on);
                    this.Close();
                }
            }

        }

        private void btnStart_MouseClick(object sender, MouseEventArgs e)
        {
            lblBorder.Text = "";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void Eye_Load(object sender, EventArgs e)
        {
            if (Check.Eye=="easy")
            {
                timerPic.Interval = 800;
                confirm = 165;
            }
            else if (Check.Eye=="medium")
            {
                timerPic.Interval = 350;
                confirm = 355;
            }
            else if (Check.Eye=="hard")
            {
                timerPic.Interval = 200;
                confirm = 595;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            on = false;
            Music(on);
            this.Close();
        }
    }
}
