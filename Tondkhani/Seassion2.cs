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
using System.IO;

namespace Tondkhani
{
    public partial class Seassion2 : Form
    {
        string text = File.ReadAllText(Application.StartupPath + @"\Text\Text2.txt");
        bool on = true;
        bool up = false;
        bool Left = false;
        bool stop = false;
        bool pic = false;
        int num = 0;
        int num2 = 0;
        int timershow = 0;
        int i = 2;
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
            foreach (PictureBox pic2 in panel2.Controls)
            {
                pic2.Image = null;
                if (pic2.Name=="pictureBox1")
                {
                    timerShow.Start();
                }
            }
        }

        public Seassion2()
        {
            InitializeComponent();
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
                if (num < 176)
                {
                    if (up==false)
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
                            pictureBox1.Location = new Point(0, pictureBox1.Top- pictureBox1.Height);
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
                    lblBorder.Text = ".تصاویر را دنبال کنید";
                    panel1.Visible = false;
                    panel2.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 1)
            {
               timerShow.Start();
            }
            else if (num2 == 2)
            {
                num++;
                if (num < 176)
                {
                    if (Left == false)
                    {
                        if (picFlower.Location.Y == 0)
                        {
                            Music(on);
                            picFlower.Location = new Point(picFlower.Width + picFlower.Left, 505);
                            if (picFlower.Location.X == 720)
                            {
                                Left = true;
                            }
                        }
                        else if (picFlower.Location.Y == 505)
                        {
                            Music(on);
                            picFlower.Location = new Point(picFlower.Width + picFlower.Left, 0);
                          
                        }
                    }
                    else
                    {
                        if (picFlower.Location.Y == 0)
                        {
                            Music(on);
                            picFlower.Location = new Point(picFlower.Left-picFlower.Width , 505);
                            
                        }
                        else if (picFlower.Location.Y == 505)
                        {
                            Music(on);
                            picFlower.Location = new Point(picFlower.Left - picFlower.Width, 0);
                            if (picFlower.Location.X<0)
                            {
                                picFlower.Left = 0;
                                picFlower.Top = 505;
                                Left = false;
                            }
                        }
                    }
               }
                else
                {
                    btnStop.Enabled = false;

                    timerPic.Stop();
                    btnStart.Enabled = true;
                    lblBorder.Text = ".تصاویر را دنبال کنید";
                    num2++;
                    panel3.Visible = false;
                    panel2.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 3)
            {
                pic = true;
                timershow = 0;
                timerPic.Stop();
                timerShow.Start();
            }
            else if (num2 == 4)
            {
                try
                {
                    string word = text.Remove(text.IndexOf(" ", num));
                    lblText.Text = word;
                    lblText.Text = lblText.Text.Remove(0, num);
                    lblText.Left = (panel4.Width - lblText.Width) / 2;
                    lblText.Top = (panel4.Height - lblText.Height) / 2;
                    num = text.IndexOf(" ", num);
                    num++;
                }
                catch
                {
                    timerPic.Stop();
                    MessageBox.Show(".تبریک ! شما موفق شدید دوره دوم آموزش را به پایان برسانید", "موفقیت!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                    int num = int.Parse(str.ReadLine());
                    str.Close();
                    if (num < 2)
                    {
                        StreamWriter stw = new StreamWriter(@"C:\Shamim\info.txt");
                        stw.WriteLine("2");
                        stw.Close();
                    }
                    Shamim shm = new Shamim();
                    shm.Show();
                    this.Close();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            lblBorder.Text = "جلسه دوم";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void Seassion2_Load(object sender, EventArgs e)
        {
            lblBorder.Text = ".تصویر را دنبال کنید";
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pic in panel2.Controls)
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
            if (timershow == 8 && pic==false)
            {
                btnStop.Enabled = false;
                timerShow.Stop();
                num2++;
                panel2.Visible = false;
                panel3.Visible = true;
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
                timerShow.Stop();
                num2++;
                panel2.Visible = false;
                panel4.Visible = true;
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
                timerShow.Stop();
                btnStop.Text = "اجرا";
                stop = true;
            }
            else
            {
                if (panel2.Visible == true)
                {
                    timerShow.Start();
                }
                if (panel4.Visible == true)
                {
                    num2 = 4;
                }
                timerPic.Start();
                btnStop.Text = "توقف";
                stop = false;
            }
        }
    }
}
