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
    public partial class Seassion3 : Form
    {
        string text = File.ReadAllText(Application.StartupPath + @"\Text\Text3.txt");
        bool on = true;
        int i;
        bool stop = false;
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
        public Seassion3()
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
            lblBorder.Text = "جلسه سوم";
            timerPic.Start();
            btnStart.Enabled = false;
        }

        private void timerPic_Tick(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num++;
                if (num < 200)
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
                if (num < 200)
                {
                    Random rdm = new Random();
                    i = rdm.Next(100, 1000);
                    lblNumber1.Text = i.ToString();
                    i = rdm.Next(100, 1000);
                    lblNumber2.Text = i.ToString();
                    if (lblNumber1.Left > 0 && lblNumber2.Left < 773)
                    {
                        lblNumber2.Left += lblNumber2.Width + 2;
                        lblNumber2.Top += lblNumber2.Height;
                        lblNumber1.Left -= lblNumber1.Width + 5;
                        lblNumber1.Top -= lblNumber1.Height;
                    }
                    else
                    {
                        lblNumber2.Left = 411;
                        lblNumber2.Top = 288;
                        lblNumber1.Top = 229;
                        lblNumber1.Left = 348;
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
                if (num < 200)
                {
                    if (pictureBox2.Location == new Point(0, 505))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(737, 0);
                    }
                    else if (pictureBox2.Location == new Point(737, 0))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(740, 505);

                    }
                    else if (pictureBox2.Location == new Point(740, 505))
                    {
                        Music(on);
                        pictureBox2.Location = new Point(0, 0);
                    }
                    else if (pictureBox2.Location == new Point(0, 0))
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
                if (num < 200)
                {
                        Random rdm = new Random();
                        i = rdm.Next(100, 1000);
                        lblNumber1_2.Text = i.ToString();
                        i = rdm.Next(100, 1000);
                        lblNumber2_2.Text = i.ToString();
                        if (lblNumber2_2.Top < 503 && lblNumber1_2.Left > 19)
                        {
                            lblNumber2_2.Top += lblNumber2_2.Height -3;
                            lblNumber1_2.Top -= lblNumber1_2.Height -3;
                        }
                        else
                        {
                            lblNumber2_2.Top = 288;
                            lblNumber1_2.Top = 221;
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
                        MessageBox.Show(".تبریک ! شما موفق شدید دوره سوم آموزش را به پایان برسانید", "موفقیت!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                    int num = int.Parse(str.ReadLine());
                    str.Close();
                    if (num < 3)
                    {
                        StreamWriter stw = new StreamWriter(@"C:\Shamim\info.txt");
                        stw.WriteLine("3");
                        stw.Close();
                    }
                    Shamim shm = new Shamim();
                        shm.Show();
                        this.Close();
                    }
                }
            }
        private void lblBorder_Click(object sender, EventArgs e)
        {

        }

        private void Seassion3_Load(object sender, EventArgs e)
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
