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

namespace Tondkhani
{
    public partial class Test_Matlab : Form
    {
        public Test_Matlab()
        {
            InitializeComponent();
        }
        int Hour = 0, Minute = 0, Second = 0;
        int second = 0;
        int random = 0;
        private void button1_Click(object sender, EventArgs e)
        {
                button1.Enabled = false;
                timer.Start();
                Random rdn = new Random();
                random = rdn.Next(9, 16);
                txtText.Text = File.ReadAllText(Application.StartupPath + @"\Text\" + random + ".txt");
            }

        private void btnFinish_Click(object sender, EventArgs e)
        {
         //   lblSpeed.Text = (((49 * ((19 + 20 + 23) / 3))) / second * 60).ToString();

            timer.Stop();
            try
            {
                        switch (random)
                        {
                            case 9:
                                lblSpeed.Text = (((22 * ((18 + 17 + 20) / 3))) / second*60).ToString();
                                break;
                            case 10:
                                lblSpeed.Text = (((19 * ((21 + 22 + 23) / 3))) / second*60).ToString();
                                break;
                            case 11:
                                lblSpeed.Text = (((22 * ((21 + 22 + 23) / 3))) / second*60).ToString();
                                break;
                            case 12:
                                lblSpeed.Text = (((20 * ((21 + 22 + 23) / 3))) / second*60).ToString();
                                break;
                            case 13:
                                lblSpeed.Text = (((24 * ((20 + 21 + 22) / 3))) / second*60).ToString();
                                break;
                            case 14:
                                lblSpeed.Text = (((18 * ((22 + 24 + 23) / 3))) / second*60).ToString();
                                break;
                            case 15:
                                lblSpeed.Text = (((21 * ((22 + 22 + 22) / 3))) / second*60).ToString();
                                break;         
                        }
            }
            catch 
            {
                lblSpeed.Text = "0";
            }
           
         //   lblSpeed.Text = (52 * ((21 + 16 + 21) / 3) / second).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            if (lblCamera.Visible==true)
            {
                lblCamera.Visible = false;
            }
            else
            {
                lblCamera.Visible = true;

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
                if (Minute == 61)
                {
                    Second = 0;
                    Minute = 0;
                    Hour++;
                    if (Hour < 9)
                    {
                        lblHour.Text = "0" + Hour.ToString();
                    }
                    else
                    {
                        lblHour.Text = Hour.ToString();
                    }
                }
            }
            if (Second < 10)
            {
                lblSecond.Text = "0" + Second.ToString();
            }
            else
            {
                lblSecond.Text = Second.ToString();
            }
        }
    }
}
