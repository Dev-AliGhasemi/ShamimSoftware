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
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace Tondkhani
{
    public partial class login : Form
    {
        bool click = false;
        int  mousex, mousey;
        public login()
        {
            InitializeComponent();
        }
        public void Music(string filepath)
        {
            SoundPlayer sound = new SoundPlayer(filepath);
            sound.Play();
        }

        private void picclose_MouseClick(object sender, MouseEventArgs e)
        {
            Music(Application.StartupPath + @"\sound\Click1.wav");
            Application.Exit();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Music(Application.StartupPath + @"\sound\Click1.wav");
            this.WindowState = FormWindowState.Minimized;
        }
        private void frmlogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (click==true)
            {
                this.Top += e.Y - mousey;
                this.Left += e.X - mousex;
            }
        }
        private void frmlogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                click = false;
            }
        }
        private void btnsubmit_MouseHover(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\High1.wav");
        }

        private void btncreat_MouseHover(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\High1.wav");
        }
        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar>='a' && e.KeyChar<='z') || (e.KeyChar>='A' && e.KeyChar<='Z')) && (char.IsNumber(e.KeyChar)==false))
            {
                lblwarning.Visible = true;
                e.Handled = true;
            }
            if (!char.IsLetter(e.KeyChar) && (! (e.KeyChar=='\b')) && !(e.KeyChar==(char)Keys.Space))
            {
                lblwarning.Visible = true;
                e.Handled = true;
            }
       
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lblwarning.Visible = false;
        }

        private void piclogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                mousex = e.X;
                mousey = e.Y;
                click = true;
            }
        }

        private void piclogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (click==true)
            {
                this.Left += e.X - mousex;
                this.Top += e.Y - mousey;
            }
        }

        private void piclogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                click = false;
            }
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.buttonclose;
        }

        private void picmini_MouseLeave(object sender, EventArgs e)
        {
            picmini.Image = Properties.Resources.buttonminimize;
        }
        private void btnenter_MouseHover(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\High1.wav");
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\High1.wav");
            picclose.Image = Properties.Resources.buttonclose2;
        }

        private void picmini_MouseEnter(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\High1.wav");
            picmini.Image = Properties.Resources.buttonminimize2;
        }
        private void btnenter_Click(object sender, EventArgs e)
        {
            Music(Application.StartupPath + @"\sound\Click1.wav");
            if (txtusername.Text == "")
            {
                MessageBox.Show(".لطفا فیلد نام کاربری را پر کنید", "! خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Shamim shm = new Shamim();
                shm.Show();
                notifyIcon1.BalloonTipText = txtusername.Text+" به برنامه شمیم خوش آمدید " ;
                notifyIcon1.ShowBalloonTip(5000);
            }
        }
        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                mousex = e.X;
                mousey =e.Y;
                click = true;
            }
        }
    }
}
