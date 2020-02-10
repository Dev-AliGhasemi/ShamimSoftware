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
    public partial class Seassion8 : Form
    {
        string text = File.ReadAllText(Application.StartupPath + @"\Text\Text8.txt");
        bool on = true;
        int i;
        bool horizental = true;
        bool vertical = false;
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
        public Seassion8()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            lblBorder.Text = "جلسه هشتم";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num++;
                if (num <355)
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
                    lblBorder.Text = ".تصاویر را دنبال کنید";
                    panel1.Visible = false;
                    panel2.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 1)
            {
                num++;
                if (num < 355)
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
                            lblNumber1.Top= 234;
                            horizental = false;
                            vertical = true;
                        }
                    }
                    else if (vertical==true)
                    {
                        if (lblNumber2.Top < 503 && lblNumber1.Left > 19 )
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
                    lblBorder.Text = ".تصویر را دنبال کنید";
                    panel2.Visible = false;
                    panel3.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 2)
            {
                num++;
                if (num < 355)
                {
                    if (pictureBox2.Location == new Point(0, 505))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(737, 0);
                    }
                    else if (pictureBox2.Location == new Point(737, 0))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(0, 0);
                    }
                    else if (pictureBox2.Location == new Point(0, 0))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(740, 505);
                    }
                    else if (pictureBox2.Location == new Point(740, 505))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(0, 505);
                    }
                }
                else
                {
                    btnStop.Enabled = false;

                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".همانطور که به مربع نگاه میکنید اعداد رو دنبال کنید";
                    panel3.Visible = false;
                    panel4.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 3)
            {
                num++;
                if (num < 355)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1_2.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2_2.Text = i.ToString();
                    if (lblNumber2_2.Left > 43 && lblNumber1_2.Left < 710)
                    {
                        lblNumber2_2.Left -= lblNumber2_2.Width + 1;
                        lblNumber2_2.Top += lblNumber2_2.Height + 1;
                        lblNumber1_2.Left += lblNumber1_2.Width + 2;
                        lblNumber1_2.Top -= lblNumber1_2.Height + 2;
                    }
                    else
                    {
                        lblNumber2_2.Left = 343;
                        lblNumber2_2.Top = 286;
                        lblNumber1_2.Top = 239;
                        lblNumber1_2.Left = 410;
                    }
                }
                else
                {
                    btnStop.Enabled = false;

                    timerPic.Stop();
                    btnStart.Enabled = true;
                    num2++;
                    lblBorder.Text = ".متن ها را ببینید";
                    panel4.Visible = false;
                    panel5.Visible = true;
                    num = 0;
                }
            }
            else if (num2 == 4)
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
                    MessageBox.Show(".تبریک ! شما موفق شدید دوره هشتم آموزش را به پایان برسانید", "موفقیت!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                    int num = int.Parse(str.ReadLine());
                    str.Close();
                    if (num < 8)
                    {
                        StreamWriter stw = new StreamWriter(@"C:\Shamim\info.txt");
                        stw.WriteLine("8");
                        stw.Close();
                    }
                    Shamim shm = new Shamim();
                    shm.Show();
                    this.Close();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            on = false;
            Music(on);
            Shamim shm = new Shamim();
            shm.Show();
            this.Close();
        }

        private void Seassion8_Load(object sender, EventArgs e)
        {
            lblBorder.Text = ".تصویر را دنبال کنید";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {
                timerPic.Stop();
                btnStop.Text = "اجرا";
                stop = true;
            }
            else
            {
                timerPic.Start();
                btnStop.Text = "توقف";
                stop = false;
            }
        }
    }
}
