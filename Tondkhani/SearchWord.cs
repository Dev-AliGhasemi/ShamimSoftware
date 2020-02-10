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
    public partial class SearchWord : Form
    {
        public SearchWord()
        {
            InitializeComponent();
        }
        int num = 0; 
        int loop = 0;
        int score = 0;
        int random = 0;
        int Second = 60, Minute = 1;
        bool question = true;
        bool entity = false;
        public void word()
        {
            foreach (Label lbl in panel1.Controls)
            {
                if (lbl.Name.IndexOf("label") >= 0)
                {
                    lbl.Tag = lbl.Text;
                    lbl.Text = "";
                }
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Acc.accdb;Persist Security Info=True;Jet OLEDB:DataBase Password=20200001");
            OleDbCommand com = new OleDbCommand();
            OleDbDataReader read;
            com.Connection = con;
            Random rnd = new Random();
            con.Open();
            foreach (Label lbl in panel1.Controls)
            {
                if (lbl.Name.IndexOf("label") >= 0)
                {
                    a1: com.CommandText = "select word from correct where id=" + rnd.Next(1, 51);
                    loop = 0;
                    read = com.ExecuteReader();
                    while (read.Read() && loop == 0)
                    {
                        foreach (Label lbl2_2 in panel1.Controls)
                        {
                            if (lbl2_2.Text.IndexOf(read[0].ToString()) >= 0)
                            {
                                entity = true;
                                break;
                            }
                        }
                        if (entity == false)
                        {
                            lbl.Text = read[0].ToString();
                            loop++;
                        }
                        else
                        {
                            entity = false;
                            read.Close();
                            goto a1;
                        }
                    }
                    read.Close();
                }
            }
            con.Close();
            btnStart.Enabled = false;
            btnQuestion.Enabled = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Visible = true;
            lblMinute.Visible = true;
            lblSecond.Visible = true;
            label17.Visible = true;
            btnQuestion.Visible = true;
            lblBorder.Text = "";
            word();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            
            txtWord.Visible = true;
            label19.Visible = true;
            btnQuestion.Enabled = false;
            if (num<10)
            {      
                try
                {
                    if (int.Parse(txtWord.Text) == random)
                    {
                            score++;
                    }
                }
                catch
                {

                }
                if (question == true)
                {
                    foreach (Label lbl in panel1.Controls)
                    {
                        if (lbl.Name.IndexOf("label") >= 0)
                        {
                            lbl.Tag = lbl.Text;
                            lbl.Text = "";
                            timer1.Stop();
                            label17.Visible = false;
                            lblMinute.Visible = false;
                            lblSecond.Visible = false;
                        }
                    }
                    Random rnd = new Random();
                    random = rnd.Next(1, 10);
                    foreach (Label lbl2_2 in panel1.Controls)
                    {
                        if (lbl2_2.Name.IndexOf("label" + random) >= 0)
                        {
                            num++;
                            label11.Text = num.ToString();
                            lblword.Text = lbl2_2.Tag.ToString();
                            question = false;
                            break;
                        }
                    }
                }
                else
                {
                        txtWord.Text = "";
                        lblword.Text = "";
                    label17.Visible = true;
                    lblMinute.Visible = true;
                    lblSecond.Visible = true;
                    Second = 60;
                    Minute = 1;
                    timer1.Start();
                    lblMinute.Text = Minute.ToString();
                        word();
                        question = true;   
                }
                btnQuestion.Enabled = true;
            }
       else
            {
                try
                {
                    if (int.Parse(txtWord.Text) == random)
                    {
                        score++;
                    }
                }
                catch 
                {
                }            
                MessageBox.Show("تعداد جواب های درست شما : " + score);
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Second--;
            if (Second<10)
            {
                lblSecond.Text = "0" + Second;
            }
            else
            {
                lblSecond.Text = Second.ToString();
            }
            if (Second==0)
            {
                Second = 60;
                Minute--;
                if (Minute < 10)
                {
                    lblMinute.Text = "0" + Minute;
                }
                else
                {
                    lblMinute.Text = Minute.ToString();
                }
                if (Minute<0)
                {
                    timer1.Stop();
                    Minute = 1;
                    lblMinute.Text = "00";
                    label17.Visible = false;
                    lblMinute.Visible = false;
                    lblSecond.Visible = false;
                    txtWord.Visible = true;
                    label19.Visible = true;
                    btnQuestion.Enabled = false;
                    if (num < 10)
                    {
                        try
                        {
                            if (int.Parse(txtWord.Text) == random)
                            {
                                score++;
                            }
                        }
                        catch
                        {

                        }
                        if (question == true)
                        {
                            foreach (Label lbl in panel1.Controls)
                            {
                                if (lbl.Name.IndexOf("label") >= 0)
                                {
                                    lbl.Tag = lbl.Text;
                                    lbl.Text = "";
                                }
                            }
                            Random rnd = new Random();
                            random = rnd.Next(1, 10);
                            foreach (Label lbl2_2 in panel1.Controls)
                            {
                                if (lbl2_2.Name.IndexOf("label" + random) >= 0)
                                {
                                    num++;
                                    label11.Text = num.ToString();
                                    lblword.Text = lbl2_2.Tag.ToString();
                                    question = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            txtWord.Text = "";
                            lblword.Text = "";
                            word();
                            question = true;
                        }
                        btnQuestion.Enabled = true;
                    }
                    else
                    {
                        try
                        {
                            if (int.Parse(txtWord.Text) == random)
                            {
                                score++;
                            }
                        }
                        catch
                        {
                        }
                        MessageBox.Show("تعداد جواب های درست شما : " + score);
                        this.Close();
                    }
                }
            }
            }
        }
    }
