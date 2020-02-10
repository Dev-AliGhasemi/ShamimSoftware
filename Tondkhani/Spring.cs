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
    public partial class Spring : Form
    {
        public Spring()
        {
            InitializeComponent();
        }
        int numPicture = 0;
        int confirm = 0;
        int second = 10;
        int once = 0;
        int check = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txtNumber.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            lblOnce.Visible = true;
            lblBorder.Text = "";
            numPicture = rnd.Next(1, 14);
            confirm = numPicture;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\time\" + numPicture + ".png");
            btnStart.Enabled = false;
            timer1.Start();
            lblSecond.Visible = true;
            label1.Visible = true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (numPicture)
                {
                    case 1:
                        if (int.Parse(txtNumber.Text) == 9)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (int.Parse(txtNumber.Text) == 8)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (int.Parse(txtNumber.Text) == 12)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (int.Parse(txtNumber.Text) == 3)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (int.Parse(txtNumber.Text) == 18)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (int.Parse(txtNumber.Text) == 5)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (int.Parse(txtNumber.Text) == 15)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (int.Parse(txtNumber.Text) == 6)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (int.Parse(txtNumber.Text) == 8)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (int.Parse(txtNumber.Text) == 7)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (int.Parse(txtNumber.Text) == 15)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (int.Parse(txtNumber.Text) == 10)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (int.Parse(txtNumber.Text) == 11)
                        {
                            txtNumber.BackColor = Color.FromArgb(30, 130, 76);
                        }
                        else
                        {
                            txtNumber.BackColor = Color.Red;
                        }
                        break;
                }
            }
            catch 
            {
                txtNumber.BackColor = Color.FromArgb(30, 130, 76);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            lblSecond.Text = "0" + second;
            if (second==0)
            {
                once++;
                lblOnce.Text = once.ToString();
                try
                {
                    switch (numPicture)
                    {
                        case 1:
                            if (int.Parse(txtNumber.Text) == 9)
                            {
                                check++;
                            }
                            break;
                        case 2:
                            if (int.Parse(txtNumber.Text) == 8)
                            {
                                check++;
                            }
                            break;
                        case 3:
                            if (int.Parse(txtNumber.Text) == 12)
                            {
                                check++;
                            }
                            break;
                        case 4:
                            if (int.Parse(txtNumber.Text) == 3)
                            {
                                check++;
                            }
                            break;
                        case 5:
                            if (int.Parse(txtNumber.Text) == 18)
                            {
                                check++;
                            }
                            break;
                        case 6:
                            if (int.Parse(txtNumber.Text) == 5)
                            {
                                check++;
                            }
                            break;
                        case 7:
                            if (int.Parse(txtNumber.Text) == 15)
                            {
                                check++;
                            }
                            break;
                        case 8:
                            if (int.Parse(txtNumber.Text) == 6)
                            {
                                check++;
                            }
                            break;
                        case 9:
                            if (int.Parse(txtNumber.Text) == 8)
                            {
                                check++;
                            }
                            break;
                        case 10:
                            if (int.Parse(txtNumber.Text) == 7)
                            {
                                check++;
                            }
                            break;
                        case 11:
                            if (int.Parse(txtNumber.Text) == 15)
                            {
                                check++;
                            }
                            break;
                        case 12:
                            if (int.Parse(txtNumber.Text) == 10)
                            {
                                check++;
                            }
                            break;
                        case 13:
                            if (int.Parse(txtNumber.Text) == 11)
                            {
                                check++;
                            }
                            break;
                    }
                }
                catch 
                {
                                
                }       
                second = 10;
                lblSecond.Text =second.ToString();
                Random rnd = new Random();
           a1:     numPicture = rnd.Next(1, 14);
                if (numPicture==confirm)
                {
                    goto a1;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\time\" + numPicture + ".png");
                    txtNumber.Text = "";
                }      
            }
            if (once==11)
            {
                timer1.Stop();
                second = 10;
                once = 0;
                lblOnce.Text = "0";
                pictureBox1.Image = null;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                lblOnce.Visible = false;
                txtNumber.Visible = false;
                lblSecond.Visible = false;
                lblBorder.Text = "اشکال را دنبال کنید.";
                btnStart.Enabled = true;
                MessageBox.Show(" امتیاز شما: "+check );
            }
        }
    }
}
