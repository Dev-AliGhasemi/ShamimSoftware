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
    public partial class Word : Form
    {
        public Word()
        {
            InitializeComponent();
        }
        string text;
        int numText = 0;
        int num = 0;
        int num2 = 0;
        int diffrent = 0;
        bool check = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Word_Load(object sender, EventArgs e)
        {
            int interval = 999 - Check.interval;
            if (interval < 0)
            {
                interval = Math.Abs(interval);
            }
            else if (interval == 0)
            {
                interval++;
            }
            timer.Interval = interval;
        //    timer.Interval = 400;
            Random rdn = new Random();
            numText = rdn.Next(16, 21);
            text = File.ReadAllText(Application.StartupPath+@"\Text\Text"+numText+".txt");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lblText.Width > 720)
                {
                    lblText.Text = "";
                    lblText.Left = 791;
                    lblText.Width = 0;
                }
                num2 = text.IndexOf(" ", num);
                num2++;
                diffrent = num2 - num;
                lblText.Text += text.Substring(num, diffrent);
                num = num2;
                lblText.Left = 791 - lblText.Width;
            }
            catch 
            {
                timer.Stop();
                this.Close();
                //Decrease_Eye de = new Decrease_Eye();
                //de.ShowDialog();
            }
        }
    }
}
