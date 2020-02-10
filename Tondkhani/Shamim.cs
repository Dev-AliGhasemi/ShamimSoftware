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
using System.Diagnostics;

namespace Tondkhani
{
    public partial class Shamim : Form
    {
        byte num = 0;
        int Mousex, Mousey;
        bool click = false;
        bool About = false;
        bool Tondkhani = false;
        bool About_soft = false;
        bool Learn = false;
        bool connect = false;
        bool Test = false;
        bool Practice = false;
        bool Incorrect = false;
        bool Eye = false;
        bool Table = false;
        bool Number = false;
        bool Time = false;
        bool Ball = false;
        bool Memory = false;
        bool Tamarkoz = false;
        bool Spring = false;
        bool Asab = false;
        bool Word = false;
        //Method Hide
        public void Active(bool Active_Name)
        {
            if (About == true || Time==true || Number==true || Table==true ||Tondkhani==true || About_soft==true || Learn==true || connect==true || Test==true || Practice==true || Eye==true || Incorrect==true || Ball==true || Spring==true || Tamarkoz==true || Asab==true || Memory==true || Word==true)
            {
                Time = false;
                Number = false;
                Incorrect = false;
                Table = false;
                About = false;
                Eye = false;
                Tondkhani = false;
                About_soft = false;
                Learn = false;
                Test = false;
                Practice = false;
                Ball = false;
                Word = false;
                Memory = false;
                Asab = false;
                Tamarkoz = false;
                Spring = false;
                connect = false;
                Active_Name = true;       
            }
            if (Time == false)
            {
                panelTime.Visible = false;
            }
            if (Eye == false)
            {
                panelEye.Visible = false;
            }
            if (Asab==false)
            {
                panelAssab.Visible = false;
            }
            if (Practice == false)
            {
                panelPractice.Visible = false;
            }
            if (Test==false)
            {
                panelTest.Visible = false;
            }
            if (connect == false)
            {
                //complete
            }
            if (About==false)
            {
                lblText_us.Visible = false;
                lblTitle_us.Visible = false;
                picLogo.Visible = false;
            }
            if (Tondkhani==false)
            {
                lblTitle_tk.Visible = false;
                lblText_tk.Visible = false;
            }
            if (About_soft==false)
            {
                lblText_Aboutsoft.Visible = false;
                lblTitle_Aboutsoft.Visible = false;
            }
            if (Learn==false)
            {
                panelLearn.Visible = false;
            }
        }
        public Shamim()
        {
            InitializeComponent();
        }
        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close;
        }
        private void picmini_MouseLeave(object sender, EventArgs e)
        {
            picmini.Image = Properties.Resources.mini;
        }

        private void picclose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void picmini_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void title_Tick(object sender, EventArgs e)
        {
           
            string title = "نرم افزار تند خوانی شمیم";
            lblBorder_title.Text += title[num];
            if (lblBorder_title.Text.Length==title.Length)
            {
                timer_title.Stop();
            }
            num++;
        }
        private void Shamim_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Shamim");
            if (!dir.Exists)
            {
                dir.Create();
            }
            try
            {
                StreamReader str = new StreamReader(@"C:\Shamim\info.txt");
                string seassion = str.ReadLine();
                str.Close();
                if (seassion == "1")
                {
                    pic1.Visible = true;
                    picSeassion2.Enabled = true;
                }
                else if (seassion == "2")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                }
                else if (seassion == "3")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                }
                else if (seassion == "4")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                }
                else if (seassion == "5")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                }
                else if (seassion == "6")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    pic6.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                    picSeassion7.Enabled = true;
                }
                else if (seassion == "7")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    pic6.Visible = true;
                    pic7.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                    picSeassion7.Enabled = true;
                    picSeassion8.Enabled = true;
                }
                else if (seassion == "8")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    pic6.Visible = true;
                    pic7.Visible = true;
                    pic8.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                    picSeassion7.Enabled = true;
                    picSeassion8.Enabled = true;
                    picSeassion9.Enabled = true;

                }
                else if (seassion == "9")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    pic6.Visible = true;
                    pic7.Visible = true;
                    pic8.Visible = true;
                    pic9.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                    picSeassion7.Enabled = true;
                    picSeassion8.Enabled = true;
                    picSeassion9.Enabled = true;
                    picSeassion10.Enabled = true;
                }
                else if (seassion == "10")
                {
                    pic1.Visible = true;
                    pic2.Visible = true;
                    pic3.Visible = true;
                    pic4.Visible = true;
                    pic5.Visible = true;
                    pic6.Visible = true;
                    pic7.Visible = true;
                    pic8.Visible = true;
                    pic9.Visible = true;
                    pic10.Visible = true;
                    picSeassion2.Enabled = true;
                    picSeassion3.Enabled = true;
                    picSeassion4.Enabled = true;
                    picSeassion5.Enabled = true;
                    picSeassion6.Enabled = true;
                    picSeassion7.Enabled = true;
                    picSeassion8.Enabled = true;
                    picSeassion9.Enabled = true;
                    picSeassion10.Enabled = true;
                }
            }
            catch
            {
            }
            timer_title.Start();
        }

        private void lbltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (click==true)
            {
                this.Left += e.X - Mousex;
                this.Top += e.Y - Mousey;
            }
        }

        private void lbltitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                click = false;
            }
        }
        private void picAbout_MouseClick(object sender, MouseEventArgs e)
        {
            Active(About);
            if (About==false)
            {
                lblText_us.Visible = true;
                lblTitle_us.Visible = true;
                picLogo.Visible = true;
                About = true;
            }    
        }

        private void picAbout_MouseLeave(object sender, EventArgs e)
        {
            picAbout.Image = Properties.Resources.about_us_1;
            lblAbout_us.Visible = false;
        }
        private void picConnect_us_MouseLeave(object sender, EventArgs e)
        {
            picConnect_us.Image = Properties.Resources.connect_us_1;
            lblConnect_us.Visible = false;
        }
        private void picWhat_tk_MouseLeave(object sender, EventArgs e)
        {
            picWhat_tk.Image = Properties.Resources.what_tk_1;
            lblWhat_tk.Visible = false;
        }

        private void picWhat_tk_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Tondkhani);
            if (Tondkhani==false)
            {
                lblText_tk.Visible = true;
                lblTitle_tk.Visible = true;
                Tondkhani = true;
            }
        }
        private void picAbout_soft_MouseLeave(object sender, EventArgs e)
        {
            picAbout_soft.Image = Properties.Resources.about_software_1;
            lblAbout_soft.Visible = false;
        }

        private void picAbout_soft_MouseClick(object sender, MouseEventArgs e)
        {
            Active(About_soft);
            if (About_soft==false)
            {
                lblText_Aboutsoft.Visible = true;
                lblTitle_Aboutsoft.Visible = true;
                About_soft = true;
            }
        }
        private void picLeran_MouseLeave(object sender, EventArgs e)
        {
            picLeran.Image = Properties.Resources.learn_1;
            lblLearn.Visible = false;
        }

        private void picLeran_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Learn);
            if (Learn==false)
            {
                panelLearn.Visible = true;
                Learn = true;
            }
        }

        private void picConnect_us_MouseClick(object sender, MouseEventArgs e)
        {
            Active(connect);
            if (connect==false)
            {
                Connect_us con = new Connect_us();
                con.ShowDialog();
                connect = true;
            }
        }
        private void picTest_MouseLeave(object sender, EventArgs e)
        {
            picTest.Image = Properties.Resources.test_1;
            lblTest.Visible = false;
        }

        private void picTest_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Test);
            if (Test==false)
            {
                panelTest.Visible = true;
                Test = true;
            }
        }
        private void picPractice_MouseLeave(object sender, EventArgs e)
        {
            picPractice.Image = Properties.Resources.practice_1;
            lblPractice.Visible = false;
        }

        private void picPractice_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Practice);
            if (Practice==false)
            {
                panelPractice.Visible = true;
                Practice = true;
            }
        }
        private void picEye_MouseLeave(object sender, EventArgs e)
        {
            picEye.Image = Properties.Resources.eye_1;
            lblEye.Visible = false;
        }

        private void picEye_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Eye);
            if (Eye == false)
            {
                panelEye.Visible = true;
                Eye = true;
            }
        }
        private void picIncorrect_MouseLeave(object sender, EventArgs e)
        {
            picIncorrect.Image = Properties.Resources.incorrect_1;
            lblIncorrect.Visible = false;
        }

        private void picIncorrect_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Incorrect);
            if (Incorrect==false)
            {
                Test_Incorrect test = new Test_Incorrect();
                test.ShowDialog();
            }
        }
        private void picTable_MouseLeave(object sender, EventArgs e)
        {
            picTable.Image = Properties.Resources.table_1;
            lblTable.Visible = false;
        }

        private void picTable_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Table);
            if (Table == false)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\Sudoko.exe");
                Table = true;
            }
        }
        private void picNumber_MouseLeave(object sender, EventArgs e)
        {
            picNumber.Image = Properties.Resources.number_1;
            lblNumber.Visible = false;
        }

        private void picNumber_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Number);
            if (Number == false)
            {
                Numbers num = new Numbers();
                num.ShowDialog();
                Number = true;
            }
        }
        private void picTime_MouseLeave(object sender, EventArgs e)
        {
            picTime.Image = Properties.Resources.time_1;
            lblTime.Visible = false;
        }

        private void picTime_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Time);
            if (Time == false)
            {
                Diffrent_time df = new Diffrent_time();
                df.Show();
                Time = true;
            }
        }
        private void picSeassion1_MouseLeave(object sender, EventArgs e)
        {
            picSeassion1.Image = Properties.Resources.seassion1_1;

        }
        private void picSeassion2_MouseLeave(object sender, EventArgs e)
        {
            picSeassion2.Image = Properties.Resources.seassion2_1;

        }
        private void picSeassion3_MouseLeave(object sender, EventArgs e)
        {
            picSeassion3.Image = Properties.Resources.seassion3_1;

        }
        private void picSeassion4_MouseLeave(object sender, EventArgs e)
        {
            picSeassion4.Image = Properties.Resources.seassion4_1;

        }

        private void picSeassion5_MouseLeave(object sender, EventArgs e)
        {
            picSeassion5.Image = Properties.Resources.seassion5_1;

        }

        private void picSeassion6_MouseLeave(object sender, EventArgs e)
        {
            picSeassion6.Image = Properties.Resources.seassion6_1;

        }
        private void picSeassion7_MouseLeave(object sender, EventArgs e)
        {
            picSeassion7.Image = Properties.Resources.seassion7_1;

        }

        private void picSeassion8_MouseLeave(object sender, EventArgs e)
        {
            picSeassion8.Image = Properties.Resources.seassion8_1;

        }
        private void picSeassion9_MouseLeave(object sender, EventArgs e)
        {
            picSeassion9.Image = Properties.Resources.seassion9_1;

        }
        private void picSeassion10_MouseLeave(object sender, EventArgs e)
        {
            picSeassion10.Image = Properties.Resources.seassion10_1;

        }

        private void picSeassion1_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion1 sea = new Seassion1();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion2_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion2 sea = new Seassion2();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion3_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion3 sea = new Seassion3();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion4_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion4 sea = new Seassion4();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion5_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion5 sea = new Seassion5();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion6_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion6 sea = new Seassion6();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion7_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion7 sea = new Seassion7();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion8_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion8 sea = new Seassion8();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion9_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion9 sea = new Seassion9();
            this.Hide();
            sea.ShowDialog();
        }

        private void picSeassion10_MouseClick(object sender, MouseEventArgs e)
        {
            Seassion10 sea = new Seassion10();
            this.Hide();
            sea.ShowDialog();
        }
        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close2;
        }

        private void picmini_MouseEnter(object sender, EventArgs e)
        {
            picmini.Image = Properties.Resources.mini2;
        }

        private void picWhat_tk_MouseEnter(object sender, EventArgs e)
        {
            picWhat_tk.Image = Properties.Resources.what_tk_2;
            lblWhat_tk.Visible = true;
        }

        private void picAbout_soft_MouseEnter(object sender, EventArgs e)
        {
            picAbout_soft.Image = Properties.Resources.about_software_2;
            lblAbout_soft.Visible = true;
        }

        private void picLeran_MouseEnter(object sender, EventArgs e)
        {
            picLeran.Image = Properties.Resources.learn_2;
            lblLearn.Visible = true;
        }

        private void picTest_MouseEnter(object sender, EventArgs e)
        {
            picTest.Image = Properties.Resources.test_2;
            lblTest.Visible = true;
        }

        private void picPractice_MouseEnter(object sender, EventArgs e)
        {
            picPractice.Image = Properties.Resources.practice_2;
            lblPractice.Visible = true;
        }

        private void picEye_MouseEnter(object sender, EventArgs e)
        {
            picEye.Image = Properties.Resources.eye_2;
            lblEye.Visible = true;
        }

        private void picIncorrect_MouseEnter(object sender, EventArgs e)
        {
            picIncorrect.Image = Properties.Resources.incorrect_2;
            lblIncorrect.Visible = true;
        }

        private void picTable_MouseEnter(object sender, EventArgs e)
        {
            picTable.Image = Properties.Resources.table_2;
            lblTable.Visible = true;
        }

        private void picNumber_MouseEnter(object sender, EventArgs e)
        {
            picNumber.Image = Properties.Resources.number_2;
            lblNumber.Visible = true;
        }

        private void picTime_MouseEnter(object sender, EventArgs e)
        {
            picTime.Image = Properties.Resources.time_2;
            lblTime.Visible = true;
        }

        private void picSeassion1_MouseEnter(object sender, EventArgs e)
        {
              picSeassion1.Image = Properties.Resources.seassion1_2;
        }

        private void picSeassion2_MouseEnter(object sender, EventArgs e)
        {
            picSeassion2.Image = Properties.Resources.seassion2_2;
        }

        private void picSeassion3_MouseEnter(object sender, EventArgs e)
        {
            picSeassion3.Image = Properties.Resources.seassion3_2;
        }

        private void picSeassion4_MouseEnter(object sender, EventArgs e)
        {
            picSeassion4.Image = Properties.Resources.seassion4_2;
        }

        private void picSeassion5_MouseEnter(object sender, EventArgs e)
        {
            picSeassion5.Image = Properties.Resources.seassion5_2;
        }

        private void picSeassion6_MouseEnter(object sender, EventArgs e)
        {
            picSeassion6.Image = Properties.Resources.seassion6_2;
        }

        private void picSeassion7_MouseEnter(object sender, EventArgs e)
        {
            picSeassion7.Image = Properties.Resources.seassion7_2;
        }

        private void picSeassion8_MouseEnter(object sender, EventArgs e)
        {
            picSeassion8.Image = Properties.Resources.seassion8_2;
        }

        private void picSeassion9_MouseEnter(object sender, EventArgs e)
        {
            picSeassion9.Image = Properties.Resources.seassion9_2;

        }

        private void picSeassion10_MouseEnter(object sender, EventArgs e)
        {
            picSeassion10.Image = Properties.Resources.seassion10_2;
        }

        private void picAbout_MouseEnter(object sender, EventArgs e)
        {
            picAbout.Image = Properties.Resources.about_us_2;
            lblAbout_us.Visible = true;
        }

        private void picConnect_us_MouseEnter(object sender, EventArgs e)
        {
            picConnect_us.Image = Properties.Resources.connect_us_2;
            lblConnect_us.Visible = true;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Point_Test po = new Point_Test();
            PictureBox pic = (PictureBox)sender;
            if (pic.Name=="pic_Point")
            {
                po.Show();
            }
            else
            {
                Check.click = true;
                po.panel1.Visible = false;
                po.panel4.Visible = true;
                po.Show();
            }
            
        }

        private void pic_Eye_MouseClick(object sender, MouseEventArgs e)
        {
            Check.click = false;
            Decrease_Eye de = new Decrease_Eye();
            de.ShowDialog();

        }

        private void pic_TestMatlab_MouseClick(object sender, MouseEventArgs e)
        {
            Test_Matlab test = new Test_Matlab();
            test.Show();
        }

        private void pic_Word_MouseClick(object sender, MouseEventArgs e)
        {
            Check.click = true;
            Decrease_Eye de = new Decrease_Eye();
            de.ShowDialog();
        }

        private void picEasy_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            switch (pic.Name)
            {
                case "picEasy":
                    Check.Eye = "easy";
                    break;
                case "picMedium":
                    Check.Eye = "medium";
                    break;
                case "picHard":
                    Check.Eye = "hard";
                    break;
            }
            Eye eye = new Eye();
            eye.Show();

        }

        private void picEasy_MouseEnter(object sender, EventArgs e)
        {
            picEasy.Image = Properties.Resources.easy2;
        }

        private void picEasy_MouseLeave(object sender, EventArgs e)
        {
            picEasy.Image = Properties.Resources.easy1;
        }

        private void picMedium_MouseEnter(object sender, EventArgs e)
        {
            picMedium.Image = Properties.Resources.medium2;
        }

        private void picMedium_MouseLeave(object sender, EventArgs e)
        {
            picMedium.Image = Properties.Resources.medium1;

        }

        private void picHard_MouseEnter(object sender, EventArgs e)
        {
            picHard.Image = Properties.Resources.hard2;
        }

        private void picHard_MouseLeave(object sender, EventArgs e)
        {
            picHard.Image = Properties.Resources.hard1;
        }

        private void pic_Eye_MouseEnter(object sender, EventArgs e)
        {
            pic_Eye.Image = Properties.Resources.decrease2;
        }

        private void pic_Eye_MouseLeave(object sender, EventArgs e)
        {
            pic_Eye.Image = Properties.Resources.decrease1;

        }

        private void pic_TestMatlab_MouseEnter(object sender, EventArgs e)
        {
            pic_TestMatlab.Image = Properties.Resources.practice_tond2;
        }

        private void pic_TestMatlab_MouseLeave(object sender, EventArgs e)
        {
            pic_TestMatlab.Image = Properties.Resources.practice_tond1;

        }

        private void pic_Word_MouseEnter(object sender, EventArgs e)
        {
            pic_Word.Image = Properties.Resources.word2 ;

        }

        private void pic_Word_MouseLeave(object sender, EventArgs e)
        {
            pic_Word.Image = Properties.Resources.word1;

        }

        private void pic_Point_MouseEnter(object sender, EventArgs e)
        {
            pic_Point.Image = Properties.Resources.point21;
        }

        private void pic_Point_MouseLeave(object sender, EventArgs e)
        {
            pic_Point.Image = Properties.Resources.point11;

        }

        private void pic_Time_MouseEnter(object sender, EventArgs e)
        {
            pic_Time.Image = Properties.Resources.time2_2;
        }

        private void pic_Time_MouseLeave(object sender, EventArgs e)
        {
            pic_Time.Image = Properties.Resources.time1_2;
        }

        private void picBall_MouseEnter(object sender, EventArgs e)
        {
            lblBall.Visible = true;
            picBall.Image = Properties.Resources.ball2;
        }

        private void picBall_MouseLeave(object sender, EventArgs e)
        {
            lblBall.Visible = false;
            picBall.Image = Properties.Resources.ball1;

        }

        private void picBall_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Ball);
            if (Ball == false)
            {
                Ball ball = new Ball();
                ball.Show();
                Ball = true;
            }
        }

        private void picWord_MouseEnter(object sender, EventArgs e)
        {
            lblWord.Visible = true;
            picWord.Image = Properties.Resources.word21;
        }

        private void picWord_MouseLeave(object sender, EventArgs e)
        {
            lblWord.Visible = false;
            picWord.Image = Properties.Resources.word11;
        }

        private void picMemory_MouseEnter(object sender, EventArgs e)
        {
            lblMemory.Visible = true;
            picMemory.Image = Properties.Resources.memory2;
        }

        private void picMemory_MouseLeave(object sender, EventArgs e)
        {
            lblMemory.Visible = false;
            picMemory.Image = Properties.Resources.memory1;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            lbl_Incorrect.Visible = true;
            pic_asab.Image = Properties.Resources.asab2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lbl_Incorrect.Visible = false;
            pic_asab.Image = Properties.Resources.asab1;
        }

        private void picTamarkoz_MouseEnter(object sender, EventArgs e)
        {
            lblTamarkoz.Visible = true;
            picTamarkoz.Image = Properties.Resources.tamarkoz2;
        }

        private void picTamarkoz_MouseLeave(object sender, EventArgs e)
        {
            lblTamarkoz.Visible = false;
            picTamarkoz.Image = Properties.Resources.tamarkoz1;
        }

        private void picSpring_MouseEnter(object sender, EventArgs e)
        {
            lblSpring.Visible = true;
            picSpring.Image = Properties.Resources.Spring2_2;
        }

        private void picSpring_MouseLeave(object sender, EventArgs e)
        {
            lblSpring.Visible = false;
            picSpring.Image = Properties.Resources.Spring1_1;
        }
        private void picMemory_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Memory);
            if (Memory == false)
            {
                Process.Start(Application.StartupPath + @"\memory\Memory.exe");
                Memory = true;
            }
        }

        private void pic_asab_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Asab);
            if (Asab == false)
            {
                panelAssab.Visible = true;
                Asab = true;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pic_easy.Image = Properties.Resources.easy2;
        }

        private void pic_easy_MouseLeave(object sender, EventArgs e)
        {
            pic_easy.Image = Properties.Resources.easy1;
        }

        private void pic_easy_MouseClick(object sender, MouseEventArgs e)
        {
            Assab asb = new Assab();
            asb.Show();
        }

        private void pic_medium_MouseEnter(object sender, EventArgs e)
        {
            pic_medium.Image = Properties.Resources.medium2;
        }

        private void pic_medium_MouseLeave(object sender, EventArgs e)
        {
            pic_medium.Image = Properties.Resources.medium1;

        }

        private void pic_hard_MouseEnter(object sender, EventArgs e)
        {
            pic_hard.Image = Properties.Resources.hard2;
        }

        private void pic_hard_MouseLeave(object sender, EventArgs e)
        {
            pic_hard.Image = Properties.Resources.hard1;

        }

        private void pic_medium_MouseClick(object sender, MouseEventArgs e)
        {
            Assab2 asb = new Assab2();
            asb.Show();
        }

        private void pic_hard_MouseClick(object sender, MouseEventArgs e)
        {
            Assab3 asb = new Assab3();
            asb.Show();
        }

        private void picTamarkoz_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Tamarkoz);
            if (Tamarkoz == false)
            {
                Tamorkoz tm = new Tamorkoz();
                tm.Show();
                Tamarkoz = true;
            }
          
        }
        private void picSpring_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Spring);
            if (Spring == false)
            {
                Spring spr = new Spring();
                spr.Show();
                Spring = true;
            }
        }

        private void picWord_MouseClick(object sender, MouseEventArgs e)
        {
            Active(Word);
            if (Word == false)
            {
                SearchWord word = new SearchWord();
                word.Show();
                Word = true;
            }
        }
        private void lbltitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                Mousex = e.X;
                Mousey = e.Y;
                click = true;
            }
        }
    }
}
