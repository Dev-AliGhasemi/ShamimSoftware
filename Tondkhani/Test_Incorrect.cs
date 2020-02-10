using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tondkhani
{
    public partial class Test_Incorrect : Form
    {
        public Test_Incorrect()
        {
            InitializeComponent();
        }
        int time = 1;
        int i = 0;
        bool Clear = false;
        int label, check = 0, numQuestion = 0, second = 0;
        public void question()
        {
            numQuestion++;
            lblQuestion.Text = numQuestion.ToString();
            btnStart.Enabled = false;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Acc.accdb;" + "Persist Security Info=True;Jet OLEDB:DataBase Password=20200001");
            OleDbCommand com = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            OleDbCommand com3 = new OleDbCommand();
            OleDbCommand com_incorrect = new OleDbCommand();

            Random rnd = new Random();
            Random rnd_incorrect = new Random();
            Random rnd2 = new Random();

            com.Connection = con;
            com_incorrect.Connection = con;
            com2.Connection = con;
            com3.Connection = con;
            com.Parameters.AddWithValue("@word1", rnd.Next(1, 51));
            com_incorrect.Parameters.AddWithValue("@word4", rnd_incorrect.Next(1, 51));
            com2.Parameters.AddWithValue("@word2", rnd.Next(1, 51));
            com3.Parameters.AddWithValue("@word3", rnd.Next(1, 51));
            com.CommandText = "select word from correct where id= @word1";
            com_incorrect.CommandText = "select word from incorrect where id= @word4";
            com2.CommandText = "select word from correct where id= @word2";
            com3.CommandText = "select word from correct where id= @word3";

            con.Open();
            for (int i = 0; i <=2; i++)
            {
                a1: label = rnd2.Next(1, 5);
                //word1
                if (i == 0)
                {
                    if (label == 1)
                    {
                        lblWord1.Text = com.ExecuteScalar().ToString();
                    }
                    else if (label == 2)
                    {
                        lblWord2.Text = com.ExecuteScalar().ToString();
                    }
                    else if (label == 3)
                    {
                        lblWord3.Text = com.ExecuteScalar().ToString();
                    }
                    else if (label == 4)
                    {
                        lblWord4.Text = com.ExecuteScalar().ToString();
                    }
                }
                //word2
                 if (i == 1)
                {
                    if (label == 1)
                    {
                        if (lblWord1.Text == "")
                        {
                            lblWord1.Text = com2.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 2)
                    {
                        if (lblWord2.Text == "")
                        {
                            lblWord2.Text = com2.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 3)
                    {
                        if (lblWord3.Text == "")
                        {
                            lblWord3.Text = com2.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 4)
                    {
                        if (lblWord4.Text == "")
                        {
                            lblWord4.Text = com2.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                }
                //word3
                if (i == 2)
                {
                    if (label == 1)
                    {
                        if (lblWord1.Text == "")
                        {
                            lblWord1.Text = com3.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 2)
                    {
                        if (lblWord2.Text == "")
                        {
                            lblWord2.Text = com3.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 3)
                    {
                        if (lblWord3.Text == "")
                        {
                            lblWord3.Text = com3.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                    else if (label == 4)
                    {
                        if (lblWord4.Text == "")
                        {
                            lblWord4.Text = com3.ExecuteScalar().ToString();
                        }
                        else
                        {
                            goto a1;
                        }
                    }
                }
            }
            //word incorrect
            if (lblWord1.Text == "")
            {
                lblWord1.Text = com_incorrect.ExecuteScalar().ToString()+" ";
            }
            else if (lblWord2.Text == "")
            {
                lblWord2.Text = com_incorrect.ExecuteScalar().ToString() + " ";
            }
            else if (lblWord3.Text == "")
            {
                lblWord3.Text = com_incorrect.ExecuteScalar().ToString() + " ";
            }
            else if (lblWord4.Text == "")
            {
                lblWord4.Text = com_incorrect.ExecuteScalar().ToString() + " ";
            }
            con.Close();
            timer.Start();
        }

        private void lblWord1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.LightSkyBlue;
        }

        private void lblWord1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.LightBlue;
        }
        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    btnNext.Enabled = false;
        //    if (numQuestion == 11)
        //    {
        //        lblWord1.Text = "";
        //        lblWord2.Text = "";
        //        lblWord3.Text = "";
        //        lblWord4.Text = "";
        //        timer.Stop();
        //        timer1.Start();
        //        this.Close();
        //    }
        //    lblWord1.Text = "";
        //    lblWord2.Text = "";
        //    lblWord3.Text = "";
        //    lblWord4.Text = "";
        //    second =0;
        //    question();
        //    btnNext.Enabled = true;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time==3)
            {
                timer.Start();
                Clear = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

                second++;
                if (second == 3)
                {
                    lblWord1.Text = "";
                    lblWord2.Text = "";
                    lblWord3.Text = "";
                    lblWord4.Text = "";
                    second = 0;
                if (Clear==true)
                {
                    question();
                    Clear = false;
                }
                else
                {
                    timer.Stop();
                    time = 0;
                    timer1.Start();
                }
            }
                if (numQuestion == 11)
                {
                    lblQuestion.Text = "10";
                    lblWord1.Text = "";
                    lblWord2.Text = "";
                    lblWord3.Text = "";
                    lblWord4.Text = "";
                    timer.Stop();
                    MessageBox.Show(" تعداد پاسخ های درست شما: " + check, "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        private void lblWord1_MouseClick(object sender, MouseEventArgs e)
        {
           // btnNext.Enabled = false;
               second = 0;        
                Label lbl = (Label)sender;
                if (lbl.Text.IndexOf(" ") >= 0)
                {
                    check++;
                }
                if (numQuestion == 11)
                {
                    lblWord1.Text = "";
                    lblWord2.Text = "";
                    lblWord3.Text = "";
                    lblWord4.Text = "";
                    timer.Stop();
                    this.Close();
                }
                lblWord1.Text = "";
                lblWord2.Text = "";
                lblWord3.Text = "";
                lblWord4.Text = "";
                second = 0;
            if (Clear == true)
            {
                question();
                Clear = false;
            }
            else
            {
                timer.Stop();
                time = 0;
                timer1.Start();
            }
        //    btnNext.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private void Test_Incorrect_Load(object sender, EventArgs e)
        {
            lblWord1.Text = "";
            lblWord2.Text = "";
            lblWord3.Text = "";
            lblWord4.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            question();
         //   btnNext.Enabled = true;
        }
    }
}
