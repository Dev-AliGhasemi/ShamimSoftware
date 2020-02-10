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
    public partial class Connect_us : Form
    {
        public Connect_us()
        {
            InitializeComponent();
        }
        bool click = false;
        int mousex, mousey;
        private void picclose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void lblBorder_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (click==true)
            {
                this.Left += e.X - mousex;
                this.Top += e.Y - mousey;
            }
        }

        private void lblBorder_title_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                click = false;
            }
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close2;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close;
        }

        private void lblBorder_title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                mousex = e.X;
                mousey = e.Y;
                click = true;
            }
        }
    }
}
