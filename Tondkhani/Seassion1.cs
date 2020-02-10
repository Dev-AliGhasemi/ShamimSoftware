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
    public partial class Seassion1 : Form
    {
        int i = 0;
        int num = 0;
        int num2 = 0;
        string text = File.ReadAllText(Application.StartupPath + @"\Text\Text1.txt");
        bool on = true;
        bool stop = false;
        public void Music(bool state)
        {
            SoundPlayer sound = new SoundPlayer(Application.StartupPath + @"\sound\1.wav");
            if (state==true)
            {
                sound.Play();
            }
            else
            {
                sound.Stop();
            }
        }
        public Seassion1()
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            lblBorder.Text = "جلسه اول";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num++;
                if (num < 150)
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
                    btnStop.Enabled = false;
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
                if (num < 150)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2.Text = i.ToString();
                    if (lblNumber2.Left < 795 && lblNumber1.Left > -6)
                    {
                        lblNumber2.Left += lblNumber2.Width - 10;
                        lblNumber1.Left -= lblNumber1.Width - 10;
                    }
                    else
                    {
                        lblNumber2.Left = 410;
                        lblNumber1.Left = 324;
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
                if (num < 150)
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
                if (num < 150)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1_2.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2_2.Text = i.ToString();
                    if (lblNumber2_2.Left > 43&& lblNumber1_2.Left < 710)
                    {
                        lblNumber2_2.Left -= lblNumber2_2.Width +1;
                        lblNumber2_2.Top += lblNumber2_2.Height +1;
                        lblNumber1_2.Left += lblNumber1_2.Width +2;
                        lblNumber1_2.Top -= lblNumber1_2.Height +2;
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
                    MessageBox.Show(".تبریک ! شما موفق شدید دوره اول آموزش را به پایان برسانید", "موفقیت!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                    int num = int.Parse(str.ReadLine());
                    str.Close();
                    if (num < 1)
                    {
                        StreamWriter stw = new StreamWriter(@"C:\Shamim\info.txt");
                        stw.WriteLine("1");
                        stw.Close();
                    }
                    Shamim shm = new Shamim();
                    shm.Show();
                    this.Close();
                }

            }
        }
        private void Seassion1_Load(object sender, EventArgs e)
        {
            lblBorder.Text = ".تصویر را دنبال کنید";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stop==false)
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
