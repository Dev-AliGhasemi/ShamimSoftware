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
    public partial class Tamorkoz : Form
    {
        public Tamorkoz()
        {
            InitializeComponent();
        }
        int Target = 0;
        int Second = 0, Minute = 0;
        bool on = false;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (on==true)
            {
                Button btn = (Button)sender;
                if (btn.BackColor == Color.Green)
                {
                    Target--;
                    btn.BackColor = Color.Red;
                    lblTarget.Text = Target.ToString();
                    if (lblTarget.Text == "0")
                    {
                        timer1.Stop();
                        Second = 0;
                        Minute = 0;
                        lblMinute.Text = "00";
                        lblSecond.Text = "00";
                        MessageBox.Show(".آفرین شما برنده شدید");
                        foreach (Button btn2 in panel.Controls)
                        {
                            btn2.BackColor = Color.White;
                            Target = 0;
                            lblTarget.Text = "0";
                            on = false;
                        }
                    }
                }
                else if(btn.BackColor==Color.White)
                {
                    
                    timer1.Stop();
                    Second = 0;
                    Minute = 0;
                    lblMinute.Text = "00";
                    lblSecond.Text = "00";
                    MessageBox.Show(".متاسفانه روی مربع سفید کلیک کردید");
                    foreach (Button btn2 in panel.Controls)
                    {
                        btn2.BackColor = Color.White;
                        Target = 0;
                        lblTarget.Text = "0";
                        on = false;
                    }
                }
              
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblBorder.Text = "";
            Minute = 0;
            Second = 0;
            lblMinute.Text = "0"+Minute.ToString();
            lblSecond.Text = "0"+Second.ToString();
            timer1.Start();
           
            on = true;
            Random rnd = new Random();
            foreach (Button btn in panel.Controls)
            {
                        btn.BackColor = Color.White;
                Target = 0;
                lblTarget.Text = "0";
             }
            foreach (Button btn in panel.Controls)
            {
                switch (rnd.Next(1, 3))
                {
                    case 1:
                        Target++;
                        lblTarget.Text = Target.ToString();
                        btn.BackColor = Color.Green;
                    break;
                }         
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblMinute.Text == "02" && lblSecond.Text == "00")
            {
                timer1.Stop();
                MessageBox.Show(".وقت شما تمام شد");
                on = false;
                Second = 0;
                Minute = 0;
                lblMinute.Text = "00";
                lblSecond.Text = "00";
                foreach (Button btn in panel.Controls)
                {
                    btn.BackColor = Color.White;
                    Target = 0;
                    lblTarget.Text = "0";
                }
            }
            else
            {
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
}
