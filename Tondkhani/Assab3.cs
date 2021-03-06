﻿using System;
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
    public partial class Assab3 : Form
    {
        public Assab3()
        {
            InitializeComponent();
        }
        bool on = false;
        int Second = 0, Minute = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblBorder.Text = "";
            btnExit.Left = 367;
            on = true;
        }

        private void Assab3_MouseEnter(object sender, EventArgs e)
        {
            if (on == true)
            {
                timer1.Stop();
                MessageBox.Show("!شما باختید");
                Second = 0;
                Minute = 0;
                lblMinute.Text = "00";
                lblSecond.Text = "00";
                on = false;
            }
        }

        private void lblfinish_MouseEnter(object sender, EventArgs e)
        {
            if (on == true)
            {
                timer1.Stop();
                MessageBox.Show(".تبریک شما برنده شدید");
                Second = 0;
                Minute = 0;
                lblMinute.Text = "00";
                lblSecond.Text = "00";
                on = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblMinute.Text == "00" && lblSecond.Text == "55")
            {
                timer1.Stop();
                MessageBox.Show(".وقت شما تمام شد");
                on = false;
                Second = 0;
                Minute = 0;
                lblMinute.Text = "00";
                lblSecond.Text = "00";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
