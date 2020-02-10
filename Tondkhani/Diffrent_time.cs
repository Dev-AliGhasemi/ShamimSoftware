using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tondkhani
{
    public partial class Diffrent_time : Form
    {
        public Diffrent_time()
        {
            InitializeComponent();
        }
        int confirm = 0,confirm2=0,num=0;
        int Second = 0, Minute = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHour_TextChanged(object sender, EventArgs e)
        {
            txtHour.BackColor = Color.FromArgb(211, 84, 0);
            try
            {
                byte num = byte.Parse(txtHour.Text);
                if (confirm == 1 && num != 1)
                {
                    txtHour.BackColor = Color.Red;
                }
                else if (confirm == 2 && num!=1)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 3 && num != 2)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 4 && num != 3)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 5 && num != 3)
                {
                    txtHour.BackColor = Color.Red;


                }
                else if (confirm == 6 && num != 5)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 7 && num != 5)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 8 && num != 5)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 9 && num != 5)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 10 && num != 6)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 11 && num != 7)
                {
                    txtHour.BackColor = Color.Red;

                }
                else if (confirm == 12 && num !=10 )
                {
                    txtHour.BackColor = Color.Red;

                }
            }
            catch 
            {

            }
     
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            txtMinute.BackColor = Color.FromArgb(211, 84, 0);
            try
            {
                byte num = byte.Parse(txtMinute.Text);
                if (confirm == 1 && num != 25)
                {
                    txtMinute.BackColor = Color.Red;
                }
                else if (confirm == 2 && num != 50)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 3 && num != 25)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 4 && num != 5)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 5 && num != 35)
                {
                    txtMinute.BackColor = Color.Red;
                }
                else if (confirm == 6 && num != 10)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 7 && num !=30)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 8 && num != 40)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 9 && num != 50)
                {
                    txtMinute.BackColor = Color.Red;

                }
                else if (confirm == 10 && num != 45)
                {
                    txtMinute.BackColor = Color.Red;
                }
                else if (confirm == 11 && num != 5)
                {
                    txtMinute.BackColor = Color.Red;
                }
                else if (confirm == 12 && num != 5)
                {
                    txtMinute.BackColor = Color.Red;
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Second < 10)
            {
                lblSecond.Text = "0" + Second.ToString();
            }
            else
            {
                lblSecond.Text = Second.ToString();
            }
            Second++;
            if (Second == 61)
            {
                Second = 0;
                Minute++;
                if (Minute < 10)
                {
                    lblMinute.Text = "0" + Minute.ToString();
                }
                else
                {
                    lblMinute.Text = Minute.ToString();
                }
            }
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar))  && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Second = 0;
            Minute = 0;
            lblMinute.Text = "0"+Minute.ToString();

            timer1.Start();       
            if (num==10)
            {
                this.Close();
            }
            label10.Visible = true;
            label9.Visible = true;
            button1.Enabled = true;
            txtMinute.Text = "";
            txtHour.Text = "";
            num++;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            txtHour.Visible = true;
            txtMinute.Visible = true;
            btnStart.Enabled = false;
            label7.Text = num.ToString();
            Random rnd = new Random();
          a1:  confirm2 = rnd.Next(1, 12);
            if (confirm2 !=confirm)
            {
                confirm = confirm2;
            }
            else
            {
                goto a1;
            }
            switch (confirm)
            {
                case 1:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\1.png");
                    break;
                case 2:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\2.png");
                    break;
                case 3:
                    pic_Time.Image= Image.FromFile(Application.StartupPath + @"\picture\time2\3.png");

                    break;
                case 4:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\4.png");

                    break;
                case 5:
                    pic_Time.Image = (Image.FromFile(Application.StartupPath + @"\picture\time2\5.png"));

                    break;
                case 6:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\6.png");

                    break;
                case 7:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\7.png");

                    break;
                case 8:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\8.png");

                    break;
                case 9:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\9.png");

                    break;
                case 10:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\10.png");
                    break;
                case 11:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\11.png");
                    break;
                    case 12:
                    pic_Time.Image = Image.FromFile(Application.StartupPath + @"\picture\time2\12.png");
                    break;
            }
        }
    }
}
