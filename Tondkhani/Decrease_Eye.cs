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
    public partial class Decrease_Eye : Form
    {
        public Decrease_Eye()
        {
            InitializeComponent();
        }
        int Mousex, Mousey;
        bool Click = false;

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close2;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close;
        }

        private void picclose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Click==true)
            {
                this.Top += e.Y - Mousey;
                this.Left += e.X - Mousex;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mousex = e.X;
                Mousey = e.Y;
                Click = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Check.click)
            {
                case true:
                    Decrease_Eye2 de = new Decrease_Eye2();
                    Check.interval = (int)(numericUpDown1.Value);
                    de.Show();
                    this.Close();
                    Check.click = false;
                    break;
                case false:
                    Word word = new Word();
                    Check.interval = (int)(numericUpDown1.Value);
                    word.Show();
                    this.Close();
                    break;
            }
         
        }

        private void Decrease_Eye_Load(object sender, EventArgs e)
        {
            if (Check.click==true)
            {
                label4.Text = "عبارت خوانی";
               
            }
            else
            {
                label4.Text = "کاهش مکث چشمی";
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Click = false;
            }
        }
    }
}
