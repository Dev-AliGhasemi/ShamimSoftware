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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }
        int score = 0;
        int Second = 0, Minute = 0, Hour = 0;
        int change = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnExit.Enabled = true;
            Second = 0;
            Minute = 0;
            Hour = 0;
            timer.Start();
            panel_Result.Visible = false;
            button1.Enabled = true;
            foreach (TextBox txt in panel_txt.Controls)
            {
                txt.Text = "";
                txt.BackColor = Color.FromArgb(103, 65, 114);
            }
            foreach (TextBox txt in panel2_txt.Controls)
            {
                txt.Text = "";
                txt.BackColor = Color.FromArgb(103, 65, 114);
            }
            foreach (TextBox txt in panel3_txt.Controls)
            {
                txt.Text = "";
                txt.BackColor = Color.FromArgb(103, 65, 114);
            }
            foreach (TextBox txt in panel4_txt.Controls)
            {
                txt.Text = "";
                txt.BackColor = Color.FromArgb(103, 65, 114);
            }
            Random rnd = new Random();
            Random operators = new Random();
            foreach (Label lbl in panel_Num1.Controls)
            {
                lbl.Text = rnd.Next(8, 15).ToString();
            }
            foreach (Label lbl in panel2_Num1.Controls)
            {
                lbl.Text = rnd.Next(8,15).ToString();
            }
            foreach (Label lbl in panel3_Num1.Controls)
            {
                lbl.Text = rnd.Next(8, 15).ToString();
            }
            foreach (Label lbl in panel4_Num1.Controls)
            {
                lbl.Text = rnd.Next(8, 15).ToString();
            }
            foreach (Label lbl in panel_Num2.Controls)
            {
                if (lbl.Name.IndexOf("Num") >= 0)
                {
                    lbl.Text = rnd.Next(1, 8).ToString();
                }
            }
            foreach (Label lbl in panel2_Num2.Controls)
            {
                if (lbl.Name.IndexOf("Num") >= 0)
                {
                    lbl.Text = rnd.Next(1, 8).ToString();
                }
            }
            foreach (Label lbl in panel3_Num2.Controls)
            {
                if (lbl.Name.IndexOf("Num") >= 0)
                {
                    lbl.Text = rnd.Next(1, 8).ToString();
                }
            }
            foreach (Label lbl in panel4_Num2.Controls)
            {
                if (lbl.Name.IndexOf("Num") >= 0)
                {
                    lbl.Text = rnd.Next(1, 8).ToString();
                }
            }
            foreach (Label lbl in panel_Num2.Controls)
            {
                for (int i = 1; i <= 14; i++)
                {
                    if (lbl.Name.IndexOf("label") >= 0)
                    {
                        if (operators.Next(1, 4) == 1)
                        {
                            lbl.Text = "+";
                        }
                        else if (operators.Next(1, 4) == 2)
                        {
                            lbl.Text = "-";
                        }
                        else if (operators.Next(1, 4) == 3)
                        {
                            lbl.Text = "×";
                        }
                    }
                }
            }
            foreach (Label lbl in panel2_Num2.Controls)
            {
                if (lbl.Name.IndexOf("label") >= 0)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        if (lbl.Name.IndexOf("label") >= 0)
                        {
                            if (operators.Next(1, 4) == 1)
                            {
                                lbl.Text = "+";
                            }
                            else if (operators.Next(1, 4) == 2)
                            {
                                lbl.Text = "-";
                            }
                            else if (operators.Next(1, 4) == 3)
                            {
                                lbl.Text = "×";
                            }
                        }
                    }
                }
            }
            foreach (Label lbl in panel3_Num2.Controls)
            {
                if (lbl.Name.IndexOf("label") >= 0)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        if (lbl.Name.IndexOf("label") >= 0)
                        {
                            if (operators.Next(1, 4) == 1)
                            {
                                lbl.Text = "+";
                            }
                            else if (operators.Next(1, 4) == 2)
                            {
                                lbl.Text = "-";
                            }
                            else if (operators.Next(1, 4) == 3)
                            {
                                lbl.Text = "×";
                            }
                        }
                    }
                }
            }
            foreach (Label lbl in panel4_Num2.Controls)
            {
                if (lbl.Name.IndexOf("label") >= 0)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        if (lbl.Name.IndexOf("label") >= 0)
                        {
                            if (operators.Next(1, 4) == 1)
                            {
                                lbl.Text = "+";
                            }
                            else if (operators.Next(1, 4) == 2)
                            {
                                lbl.Text = "-";
                            }
                            else if (operators.Next(1, 4) == 3)
                            {
                                lbl.Text = "×";
                            }
                        }
                    }
                }
            }
        }

        private void txt4_14_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.IndexOf("-") == 0 && txt.TextLength > 1)
            {
                string letter = txt.Text.Substring(txt.Text.IndexOf("-") + 1, 1);
                txt.Tag = "-" + letter;
            }
            else if (txt.Text.IndexOf("-") > 0 && txt.TextLength > 1)
            {
                string letter = txt.Text.Substring(txt.Text.IndexOf("-") - 1, 1);
                txt.Tag = "-" + txt.Text.Substring(0, 1);
            }
            else
            {
                txt.Tag = txt.Text;
            }
            if (txt.Text.IndexOf("-") == 0 && txt.TextLength > 1)
            {
                string letter = "";
                try
                {
                    letter = txt.Text.Substring(txt.Text.IndexOf("-") + 1, 1);
                }
                catch
                {
                    letter = txt.Text.Substring(txt.Text.IndexOf("-") - 1, 1);
                }
                finally
                {
                    txt.Text = letter + txt.Text.Substring(txt.Text.IndexOf("-"), 1);
                }
            }
        }

        private void txt4_14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar==(char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            panel_Result.Visible = false;
            button1.Enabled = false;
            //Column1
            foreach (TextBox txt in panel_txt.Controls)
            {
                try
                {
                    //text1
                    if (txt.Name == "txt1")
                    {
                        switch (label14.Text)
                        {
                            case "+":
                                if (int.Parse(lbl1_Num1.Text) + int.Parse(lbl1_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl1_Num1.Text) - int.Parse(lbl1_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength>0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl1_Num1.Text) * int.Parse(lbl1_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    //text2
                    else if (txt.Name == "txt2")
                    {
                        switch (label13.Text)
                        {
                            case "+":
                                if (int.Parse(lbl2_Num1.Text) + int.Parse(lbl2_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl2_Num1.Text) - int.Parse(lbl2_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl2_Num1.Text) * int.Parse(lbl2_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt3")
                    {
                        switch (label12.Text)
                        {
                            case "+":
                                if (int.Parse(lbl3_Num1.Text) + int.Parse(lbl3_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl3_Num1.Text) - int.Parse(lbl3_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl3_Num1.Text) * int.Parse(lbl3_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt4")
                    {
                        switch (label11.Text)
                        {
                            case "+":
                                if (int.Parse(lbl4_Num1.Text) + int.Parse(lbl4_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl4_Num1.Text) - int.Parse(lbl4_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl4_Num1.Text) * int.Parse(lbl4_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt5")
                    {
                        switch (label10.Text)
                        {
                            case "+":
                                if (int.Parse(lbl5_Num1.Text) + int.Parse(lbl5_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl5_Num1.Text) - int.Parse(lbl5_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl5_Num1.Text) * int.Parse(lbl5_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt6")
                    {
                        switch (label9.Text)
                        {
                            case "+":
                                if (int.Parse(lbl6_Num1.Text) + int.Parse(lbl6_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl6_Num1.Text) - int.Parse(lbl6_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl6_Num1.Text) * int.Parse(lbl6_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt7")
                    {
                        switch (label8.Text)
                        {
                            case "+":
                                if (int.Parse(lbl7_Num1.Text) + int.Parse(lbl7_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl7_Num1.Text) - int.Parse(lbl7_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl7_Num1.Text) * int.Parse(lbl7_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt8")
                    {
                        switch (label7.Text)
                        {
                            case "+":
                                if (int.Parse(lbl8_Num1.Text) + int.Parse(lbl8_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl8_Num1.Text) - int.Parse(lbl8_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl8_Num1.Text) * int.Parse(lbl8_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt9")
                    {
                        switch (label6.Text)
                        {
                            case "+":
                                if (int.Parse(lbl9_Num1.Text) + int.Parse(lbl9_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl9_Num1.Text) - int.Parse(lbl9_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl9_Num1.Text) * int.Parse(lbl9_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt.Name == "txt10")
                    {
                        switch (label5.Text)
                        {
                            case "+":
                                if (int.Parse(lbl10_Num1.Text) + int.Parse(lbl10_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl10_Num1.Text) - int.Parse(lbl10_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl10_Num1.Text) * int.Parse(lbl10_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt.Name == "txt11")
                    {
                        switch (label4.Text)
                        {
                            case "+":
                                if (int.Parse(lbl11_Num1.Text) + int.Parse(lbl11_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl11_Num1.Text) - int.Parse(lbl11_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl11_Num1.Text) * int.Parse(lbl11_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt12")
                    {
                        switch (label3.Text)
                        {
                            case "+":
                                if (int.Parse(lbl12_Num1.Text) + int.Parse(lbl12_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl12_Num1.Text) - int.Parse(lbl12_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl12_Num1.Text) * int.Parse(lbl12_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt.Name == "txt13")
                    {
                        switch (label2.Text)
                        {
                            case "+":
                                if (int.Parse(lbl13_Num1.Text) + int.Parse(lbl13_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl13_Num1.Text) - int.Parse(lbl13_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl13_Num1.Text) * int.Parse(lbl13_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt.Name == "txt14")
                    {
                        switch (label1.Text)
                        {
                            case "+":
                                if (int.Parse(lbl14_Num1.Text) + int.Parse(lbl14_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl14_Num1.Text) - int.Parse(lbl14_Num2.Text) == Convert.ToInt32(txt.Tag) && txt.TextLength > 0)
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl14_Num1.Text) * int.Parse(lbl14_Num2.Text) == int.Parse(txt.Text))
                                {
                                    txt.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                }
                catch
                {
                    txt.BackColor = Color.Red;
                }
            }
                //---------------------------------------------------------
                //Column2
                foreach (TextBox txt2 in panel2_txt.Controls)
                    {
                    try
                    {
                        //text1
                        if (txt2.Name == "txt2_1")
                        {
                            switch (label42.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl1_2_Num1.Text) + int.Parse(lbl1_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl1_2_Num1.Text) - int.Parse(lbl1_2_Num1.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl1_2_Num1.Text) * int.Parse(lbl1_2_Num1.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                            }
                        }
                        //text2
                        else if (txt2.Name == "txt2_2")
                        {
                            switch (label41.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl2_2_Num1.Text) + int.Parse(lbl2_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl2_2_Num1.Text) - int.Parse(lbl2_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl2_2_Num1.Text) * int.Parse(lbl2_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_3")
                        {
                            switch (label40.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl3_2_Num1.Text) + int.Parse(lbl3_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl3_2_Num1.Text) - int.Parse(lbl3_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl3_2_Num1.Text) * int.Parse(lbl3_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_4")
                        {
                            switch (label39.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl4_2_Num1.Text) + int.Parse(lbl4_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl4_2_Num1.Text) - int.Parse(lbl4_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl4_2_Num1.Text) * int.Parse(lbl4_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_5")
                        {
                            switch (label38.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl5_2_Num1.Text) + int.Parse(lbl5_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl5_2_Num1.Text) - int.Parse(lbl5_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl5_2_Num1.Text) * int.Parse(lbl5_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_6")
                        {
                            switch (label37.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl6_2_Num1.Text) + int.Parse(lbl6_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl6_2_Num1.Text) - int.Parse(lbl6_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl6_2_Num1.Text) * int.Parse(lbl6_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_7")
                        {
                            switch (label36.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl7_2_Num1.Text) + int.Parse(lbl7_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl7_2_Num1.Text) - int.Parse(lbl7_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl7_2_Num1.Text) * int.Parse(lbl7_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_8")
                        {
                            switch (label35.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl8_2_Num1.Text) + int.Parse(lbl8_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl8_2_Num1.Text) - int.Parse(lbl8_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl8_2_Num1.Text) * int.Parse(lbl8_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_9")
                        {
                            switch (label34.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl9_2_Num1.Text) + int.Parse(lbl9_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl9_2_Num1.Text) - int.Parse(lbl9_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl9_2_Num1.Text) * int.Parse(lbl9_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                            }
                        }
                        else if (txt2.Name == "txt2_10")
                        {
                            switch (label33.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl10_2_Num1.Text) + int.Parse(lbl10_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl10_2_Num1.Text) - int.Parse(lbl10_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl10_2_Num1.Text) * int.Parse(lbl10_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                            }
                        }
                        else if (txt2.Name == "txt2_11")
                        {
                            switch (label32.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl11_2_Num1.Text) + int.Parse(lbl11_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl11_2_Num1.Text) - int.Parse(lbl11_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl11_2_Num1.Text) * int.Parse(lbl11_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_12")
                        {
                            switch (label31.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl12_2_Num1.Text) + int.Parse(lbl11_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl12_2_Num1.Text) - int.Parse(lbl12_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl12_2_Num1.Text) * int.Parse(lbl12_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;

                            }
                        }
                        else if (txt2.Name == "txt2_13")
                        {
                            switch (label30.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl13_2_Num1.Text) + int.Parse(lbl13_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl13_2_Num1.Text) - int.Parse(lbl13_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl13_2_Num1.Text) * int.Parse(lbl13_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                            }
                        }
                        else if (txt2.Name == "txt2_14")
                        {
                            switch (label29.Text)
                            {
                                case "+":
                                    if (int.Parse(lbl14_2_Num1.Text) + int.Parse(lbl14_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "-":
                                    if (int.Parse(lbl14_2_Num1.Text) - int.Parse(lbl14_2_Num2.Text) == Convert.ToInt32(txt2.Tag) && txt2.TextLength > 0)
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                                case "×":
                                    if (int.Parse(lbl14_2_Num1.Text) * int.Parse(lbl14_2_Num2.Text) == int.Parse(txt2.Text))
                                    {
                                        txt2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        txt2.BackColor = Color.Red;
                                    }
                                    break;
                            }
                        }
                    }
                    catch
                    {
                        txt2.BackColor = Color.Red;
                    }
                }
                //----------------------------------------------------------------
            //Column3
            foreach (TextBox txt3 in panel3_txt.Controls)
            {
                try
                {
                    //text1
                    if (txt3.Name == "txt3_1")
                    {
                        switch (label56.Text)
                        {
                            case "+":
                                if (int.Parse(lbl1_3_Num1.Text) + int.Parse(lbl1_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl1_3_Num1.Text) - int.Parse(lbl1_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl1_3_Num1.Text) * int.Parse(lbl1_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    //text2
                    else if (txt3.Name == "txt3_2")
                    {
                        switch (label55.Text)
                        {
                            case "+":
                                if (int.Parse(lbl2_3_Num1.Text) + int.Parse(lbl2_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl2_3_Num1.Text) - int.Parse(lbl2_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl2_3_Num1.Text) * int.Parse(lbl2_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_3")
                    {
                        switch (label54.Text)
                        {
                            case "+":
                                if (int.Parse(lbl3_3_Num1.Text) + int.Parse(lbl3_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl3_3_Num1.Text) - int.Parse(lbl3_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl3_3_Num1.Text) * int.Parse(lbl3_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_4")
                    {
                        switch (label53.Text)
                        {
                            case "+":
                                if (int.Parse(lbl4_3_Num1.Text) + int.Parse(lbl4_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl4_3_Num1.Text) - int.Parse(lbl4_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl4_3_Num1.Text) * int.Parse(lbl4_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_5")
                    {
                        switch (label52.Text)
                        {
                            case "+":
                                if (int.Parse(lbl5_3_Num1.Text) + int.Parse(lbl5_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl5_3_Num1.Text) - int.Parse(lbl5_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl5_3_Num1.Text) * int.Parse(lbl5_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_6")
                    {
                        switch (label51.Text)
                        {
                            case "+":
                                if (int.Parse(lbl6_3_Num1.Text) + int.Parse(lbl6_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl6_3_Num1.Text) - int.Parse(lbl6_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl6_3_Num1.Text) * int.Parse(lbl6_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_7")
                    {
                        switch (label50.Text)
                        {
                            case "+":
                                if (int.Parse(lbl7_3_Num1.Text) + int.Parse(lbl7_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl7_3_Num1.Text) - int.Parse(lbl7_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl7_3_Num1.Text) * int.Parse(lbl7_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_8")
                    {
                        switch (label49.Text)
                        {
                            case "+":
                                if (int.Parse(lbl8_3_Num1.Text) + int.Parse(lbl8_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl8_3_Num1.Text) - int.Parse(lbl8_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl8_3_Num1.Text) * int.Parse(lbl8_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_9")
                    {
                        switch (label48.Text)
                        {
                            case "+":
                                if (int.Parse(lbl9_3_Num1.Text) + int.Parse(lbl9_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl9_3_Num1.Text) - int.Parse(lbl9_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl9_3_Num1.Text) * int.Parse(lbl9_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt3_10")
                    {
                        switch (label47.Text)
                        {
                            case "+":
                                if (int.Parse(lbl10_3_Num1.Text) + int.Parse(lbl10_3_Num2.Text) == int.Parse(txt2.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl10_3_Num1.Text) - int.Parse(lbl10_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl10_3_Num1.Text) * int.Parse(lbl10_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt3_11")
                    {
                        switch (label46.Text)
                        {
                            case "+":
                                if (int.Parse(lbl11_3_Num1.Text) + int.Parse(lbl11_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl11_3_Num1.Text) - int.Parse(lbl11_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl11_3_Num1.Text) * int.Parse(lbl11_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_12")
                    {
                        switch (label45.Text)
                        {
                            case "+":
                                if (int.Parse(lbl12_3_Num1.Text) + int.Parse(lbl12_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl12_3_Num1.Text) - int.Parse(lbl12_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl12_3_Num1.Text) * int.Parse(lbl12_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt3_13")
                    {
                        switch (label44.Text)
                        {
                            case "+":
                                if (int.Parse(lbl13_3_Num1.Text) + int.Parse(lbl13_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl13_3_Num1.Text) - int.Parse(lbl13_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl13_3_Num1.Text) * int.Parse(lbl13_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt3_14")
                    {
                        switch (label43.Text)
                        {
                            case "+":
                                if (int.Parse(lbl14_3_Num1.Text) + int.Parse(lbl14_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl14_3_Num1.Text) - int.Parse(lbl14_3_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl14_3_Num1.Text) * int.Parse(lbl14_3_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                }
                catch
                {
                    txt3.BackColor = Color.Red;
                }
            }
           //--------------------------------------------------------
                 //Column4
            foreach (TextBox txt3 in panel4_txt.Controls)
            {
                try
                {
                    //text1
                    if (txt3.Name == "txt4_1")
                    {
                        switch (label70.Text)
                        {
                            case "+":
                                if (int.Parse(lbl1_4_Num1.Text) + int.Parse(lbl1_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl1_4_Num1.Text) - int.Parse(lbl1_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl1_4_Num1.Text) * int.Parse(lbl1_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    //text2
                    else if (txt3.Name == "txt4_2")
                    {
                        switch (label69.Text)
                        {
                            case "+":
                                if (int.Parse(lbl2_4_Num1.Text) + int.Parse(lbl2_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl2_4_Num1.Text) - int.Parse(lbl2_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl2_4_Num1.Text) * int.Parse(lbl2_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_3")
                    {
                        switch (label68.Text)
                        {
                            case "+":
                                if (int.Parse(lbl3_4_Num1.Text) + int.Parse(lbl3_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl3_4_Num1.Text) - int.Parse(lbl3_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl3_4_Num1.Text) * int.Parse(lbl3_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_4")
                    {
                        switch (label67.Text)
                        {
                            case "+":
                                if (int.Parse(lbl4_4_Num1.Text) + int.Parse(lbl4_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl4_4_Num1.Text) - int.Parse(lbl4_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl4_4_Num1.Text) * int.Parse(lbl4_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_5")
                    {
                        switch (label66.Text)
                        {
                            case "+":
                                if (int.Parse(lbl5_4_Num1.Text) + int.Parse(lbl5_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl5_4_Num1.Text) - int.Parse(lbl5_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl5_4_Num1.Text) * int.Parse(lbl5_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_6")
                    {
                        switch (label65.Text)
                        {
                            case "+":
                                if (int.Parse(lbl6_4_Num1.Text) + int.Parse(lbl6_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl6_4_Num1.Text) - int.Parse(lbl6_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl6_4_Num1.Text) * int.Parse(lbl6_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_7")
                    {
                        switch (label64.Text)
                        {
                            case "+":
                                if (int.Parse(lbl7_4_Num1.Text) + int.Parse(lbl7_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl7_4_Num1.Text) - int.Parse(lbl7_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl7_4_Num1.Text) * int.Parse(lbl7_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_8")
                    {
                        switch (label63.Text)
                        {
                            case "+":
                                if (int.Parse(lbl8_4_Num1.Text) + int.Parse(lbl8_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl8_4_Num1.Text) - int.Parse(lbl8_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl8_4_Num1.Text) * int.Parse(lbl8_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_9")
                    {
                        switch (label62.Text)
                        {
                            case "+":
                                if (int.Parse(lbl9_4_Num1.Text) + int.Parse(lbl9_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl9_4_Num1.Text) - int.Parse(lbl9_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl9_4_Num1.Text) * int.Parse(lbl9_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt4_10")
                    {
                        switch (label61.Text)
                        {
                            case "+":
                                if (int.Parse(lbl10_4_Num1.Text) + int.Parse(lbl10_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl10_4_Num1.Text) - int.Parse(lbl10_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl10_4_Num1.Text) * int.Parse(lbl10_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt4_11")
                    {
                        switch (label60.Text)
                        {
                            case "+":
                                if (int.Parse(lbl11_4_Num1.Text) + int.Parse(lbl11_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl11_4_Num1.Text) - int.Parse(lbl11_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl11_4_Num1.Text) * int.Parse(lbl11_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_12")
                    {
                        switch (label59.Text)
                        {
                            case "+":
                                if (int.Parse(lbl12_4_Num1.Text) + int.Parse(lbl12_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl12_4_Num1.Text) - int.Parse(lbl12_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl12_4_Num1.Text) * int.Parse(lbl12_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;

                        }
                    }
                    else if (txt3.Name == "txt4_13")
                    {
                        switch (label58.Text)
                        {
                            case "+":
                                if (int.Parse(lbl13_4_Num1.Text) + int.Parse(lbl13_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl13_4_Num1.Text) - int.Parse(lbl13_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl13_4_Num1.Text) * int.Parse(lbl13_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                    else if (txt3.Name == "txt4_14")
                    {
                        switch (label57.Text)
                        {
                            case "+":
                                if (int.Parse(lbl14_4_Num1.Text) + int.Parse(lbl14_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "-":
                                if (int.Parse(lbl14_4_Num1.Text) - int.Parse(lbl14_4_Num2.Text) == Convert.ToInt32(txt3.Tag) && txt3.TextLength > 0)
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                            case "×":
                                if (int.Parse(lbl14_4_Num1.Text) * int.Parse(lbl14_4_Num2.Text) == int.Parse(txt3.Text))
                                {
                                    txt3.BackColor = Color.Green;
                                }
                                else
                                {
                                    txt3.BackColor = Color.Red;
                                }
                                break;
                        }
                    }
                }
                catch
                {
                    txt3.BackColor = Color.Red;
                }
            }
            foreach (TextBox txt in panel_txt.Controls)
            {
                if (txt.BackColor == Color.Green)
                {
                    score++;
                }
            }
            foreach (TextBox txt in panel2_txt.Controls)
            {
                if (txt.BackColor == Color.Green)
                {
                    score++;
                }
            }
            foreach (TextBox txt in panel3_txt.Controls)
            {
                if (txt.BackColor == Color.Green)
                {
                    score++;
                }
            }
            foreach (TextBox txt in panel4_txt.Controls)
            {
                if (txt.BackColor == Color.Green)
                {
                    score++;
                }
            }
            lbl_Correct.Text = score.ToString();
            lbl_Incorrect.Text =(Math.Abs(score - 56)).ToString();
            panel_Result.Visible = true;
            btnStart.Enabled = false;
            btnExit.Enabled = false;
            score = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Second < 10)
            {
                lblSecond.Text = "0" + Second.ToString();
            }
            else
            {
                lblSecond.Text = Second.ToString();
            }
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
                if (Minute == 61)
                {
                    Second = 0;
                    Minute = 0;
                    Hour++;
                    if (Hour < 10)
                    {
                        lblHour.Text = "0" + Hour.ToString();
                    }
                    else
                    {
                        lblHour.Text = Hour.ToString();
                    }
                }
            }
               
        }
    }
    }
