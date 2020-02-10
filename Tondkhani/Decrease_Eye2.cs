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
    public partial class Decrease_Eye2 : Form
    {
        public Decrease_Eye2()
        {
            InitializeComponent();
        }
        string text;
        int numText = 0;
        int num = 0;
        private void Decrease_Eye2_Load(object sender, EventArgs e)
        {
            int interval = 999 - Check.interval;
            if (interval<0)
            {
                interval=Math.Abs(interval);
            }
            else if (interval==0)
            {
                interval++;
            }
            timer.Interval = interval;
            Random rdn = new Random();
            numText=rdn.Next(11, 18);
            numText = 15;
            text = File.ReadAllText(Application.StartupPath + @"\Text\Text"+ numText  +".txt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string word = text.Remove(text.IndexOf(" ", num));
                lblText.Text = word;
                lblText.Text = lblText.Text.Remove(0, num);
                lblText.Left = (this.Width - lblText.Width) / 2;
                lblText.Top = (this.Height - lblText.Height) / 2;
                num = text.IndexOf(" ", num);
                num++;
            }
            catch
            {
                timer.Stop();
                this.Close();
                //Decrease_Eye de = new Decrease_Eye();
                //    de.ShowDialog();
            }
        }
    }
}
