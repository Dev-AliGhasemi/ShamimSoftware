using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Tondkhani
{
    public partial class Seassion10 : Form
    {
        string text = File.ReadAllText(Application.StartupPath + @"\Text\Text10.txt");
        bool pic = false;
        int timershow = 0;
        bool one = false;
        bool on = true;
        bool left = false;
        bool right = true;
        bool horizental = true;
        bool vertical = false;
        int i = 2;
        bool stop = false;
        bool up = false;
        int num2 = 0;
        int num = 0;
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
        public int Random()
        {
            Random rdm = new Random();
            return rdm.Next(1, 32);
        }
        public void Null()
        {
            foreach (PictureBox pic2 in panel3.Controls)
            {
                pic2.Image = null;
                if (pic2.Name == "pictureBox1")
                {
                    timer.Start();
                }
            }
        }
        public Seassion10()
        {
            InitializeComponent();
        }

        private void Seassion10_Load(object sender, EventArgs e)
        {
            lblBorder.Text = ".تصویر را دنبال کنید";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            lblBorder.Text = "جلسه دهم";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            on = false;
            Music(on);
            Shamim shm = new Shamim();
            shm.Show();
            this.Close();
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num++;
                if (num < 418)
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
                    btnStop.Enabled = false;

                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".همانطور که به مربع نگاه میکنید اعداد رو دنبال کنید";
                    panel1.Visible = false;
                    panel2.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 1)
            {
                num++;
                if (num < 418)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2.Text = i.ToString();
                    if (horizental == true)
                    {
                        if (lblNumber2.Left < 795 && lblNumber1.Left > -6)
                        {
                            lblNumber2.Left += lblNumber2.Width - 10;
                            lblNumber1.Left -= lblNumber1.Width - 10;
                        }
                        else
                        {
                            lblNumber2.Left = 369;
                            lblNumber1.Left = 369;
                            lblNumber2.Top = 288;
                            lblNumber1.Top = 234;
                            horizental = false;
                            vertical = true;
                        }
                    }
                    else if (vertical == true)
                    {
                        if (lblNumber2.Top < 503 && lblNumber1.Left > 19)
                        {
                            lblNumber2.Top += lblNumber2.Height - 3;
                            lblNumber1.Top -= lblNumber1.Height - 3;

                        }
                        else
                        {
                            lblNumber2.Left = 410;
                            lblNumber1.Left = 324;
                            lblNumber2.Top = 258;
                            lblNumber1.Top = 258;
                            horizental = true;
                            vertical = false;
                        }
                    }
                }
                else
                {
                    btnStop.Enabled = false;

                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".تصاویر را دنبال کنید";
                    panel2.Visible = false;
                    panel3.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 2)
            {
                timer.Start();
            }
            else if (num2 == 3)
            {
                num++;
                if (num < 418)
                {
                    if (pictureBox22.Location == new Point(0, 505))
                    {
                        Music(on);
                        pictureBox22.Location = new Point(737, 0);
                    }
                    else if (pictureBox22.Location == new Point(737, 0))
                    {
                        Music(on);
                        pictureBox22.Location = new Point(0, 0);
                    }
                    else if (pictureBox22.Location == new Point(0, 0))
                    {
                        Music(on);
                        pictureBox22.Location = new Point(740, 505);
                    }
                    else if (pictureBox22.Location == new Point(740, 505))
                    {
                        Music(on);
                        pictureBox22.Location = new Point(0, 505);
                    }
                }
                else
                {
                    btnStop.Enabled = false;
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".همانطور که به مربع نگاه میکنید اعداد رو دنبال کنید";
                    panel4.Visible = false;
                    panel5.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 4)
            {
                num++;
                if (num < 418)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1_2.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2_2.Text = i.ToString();
                    if (left == true)
                    {
                        if (lblNumber1_2.Left > 0 && lblNumber2_2.Left < 773)
                        {
                            lblNumber2_2.Left += lblNumber2_2.Width + 2;
                            lblNumber2_2.Top += lblNumber2_2.Height;
                            lblNumber1_2.Left -= lblNumber1_2.Width + 5;
                            lblNumber1_2.Top -= lblNumber1_2.Height;
                        }
                        else
                        {
                            lblNumber2_2.Left = 343;
                            lblNumber2_2.Top = 286;
                            lblNumber1_2.Top = 239;
                            lblNumber1_2.Left = 410;
                            left = false;
                            right = true;
                        }
                    }
                    else if (right == true)
                    {
                        if (lblNumber2_2.Left > 43 && lblNumber1_2.Left < 710)
                        {
                            lblNumber2_2.Left -= lblNumber2_2.Width + 3;
                            lblNumber2_2.Top += lblNumber2_2.Height + 1;
                            lblNumber1_2.Left += lblNumber1_2.Width + 2;
                            lblNumber1_2.Top -= lblNumber1_2.Height + 2;
                        }
                        else
                        {
                            lblNumber2_2.Left = 411;
                            lblNumber2_2.Top = 288;
                            lblNumber1_2.Top = 229;
                            lblNumber1_2.Left = 348;
                            left = true;
                            right = false;
                        }
                    }
                }
                else
                {
                    btnStop.Enabled = false;
                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".تصاویر را دنبال کنید";
                    panel5.Visible = false;
                    panel3.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 5)
            {
                pic = true;
                i = 2;
                timershow = 0;
                timerPic.Stop();
                timer.Start();
            }
            else if (num2 == 6)
            {
                try
                {
                    string word = text.Remove(text.IndexOf(" ", num));
                    lblText.Text = word;
                    lblText.Text = lblText.Text.Remove(0, num);
                    lblText.Left = (panel5.Width - lblText.Width) / 2;
                    lblText.Top = (panel5.Height - lblText.Height) / 2;
                    num = text.IndexOf(" ", num);
                    num++;
                }
                catch
                {
                    timerPic.Stop();
                    MessageBox.Show(".تبریک ! شما موفق شدید دوره دهم آموزش را به پایان برسانید", "موفقیت!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                    int num = int.Parse(str.ReadLine());
                    str.Close();
                    if (num < 10)
                    {
                        StreamWriter stw = new StreamWriter(@"C:\Shamim\info.txt");
                        stw.WriteLine("10");
                        stw.Close();
                    }
                    Shamim shm = new Shamim();
                    shm.Show();
                    this.Close();
                }
            }
       }
        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pic in panel3.Controls)
            {
                if (pic.Name == "pictureBox" + i)
                {
                    if (i == 21)
                        i++;
                    i++;
                    pictureBox62.Visible = true;
                    pic.ImageLocation = (Application.StartupPath + @"\picture\pic\pic" + Random() + ".png");
                    if (i == 63)
                    {
                        i = 2;
                        timershow++;
                        Null();
                    }
                }
                pictureBox62.Image = null;
                pictureBox61.Image = null;

            }
            if (timershow == 8 && pic == false)
            {
                btnStop.Enabled = false;

                timer.Stop();
                num2++;
                panel3.Visible = false;
                panel4.Visible = true;
                pictureBox62.Visible = false;
                pictureBox61.Visible = false;
                timerPic.Stop();
                btnStart.Enabled = true;
                lblBorder.Text = ".تصویر را دنبال کنید";
                num = 0;
            }
            else if (timershow == 8 && pic == true)
            {
                btnStop.Enabled = false;
                timer.Stop();
                num2++;
                panel3.Visible = false;
                panel6.Visible = true;
                timerPic.Stop();
                btnStart.Enabled = true;
                lblBorder.Text = ".متن ها را ببینید";
                num = 0;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {
                timerPic.Stop();
                timer.Stop();
                btnStop.Text = "اجرا";
                stop = true;
            }
            else
            {
                if (panel3.Visible == true)
                {
                    timer.Start();
                }
                if (panel6.Visible == true)
                {
                    num2 = 6;
                }
                timerPic.Start();
                btnStop.Text = "توقف";
                stop = false;
            }
        }
    }
}
