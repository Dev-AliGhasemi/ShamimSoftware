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
    public partial class Point_Test : Form
    {
        string[] check = new string[9];
        string Name;
        int Hour=0, Minute=0, Second=0;
        public void location()
        {
            lblQuestion.Left = (this.Width - lblQuestion.Width) / 2;
            rdo_answer1.Left =10;
            rdo_answer2.Left = 10;
            rdo_answer3.Left = 10;
            rdo_answer4.Left = 10;
            rdo_answer1.Checked = false;
            rdo_answer2.Checked = false;
            rdo_answer3.Checked = false;
            rdo_answer4.Checked = false;
        }

        byte part = 0;
        bool correct = false;
        byte i;
        int second =0;
        byte numScore=0;
        byte numQuestion = 1;
        int part2 = 1;
        public Point_Test()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Shamim shm = new Shamim();
            part++;
            if (Check.click==true)
            {
                if (part2 == 1)
                {
                    try
                    {
                        switch (Name.Remove(0, 11))
                        {
                            case "1":
                                lblTitr.Text = "اعماق زمین";
                                break;
                            case "2":
                                lblTitr.Text = "بیل گیتس";
                                break;
                            case "3":
                                lblTitr.Text = "روان شناسی شناختی";
                                break;
                            case "4":
                                lblTitr.Text = "کودکان";
                                break;
                            case "5":
                                lblTitr.Text = "مدیر";
                                break;
                            case "6":
                                lblTitr.Text = "موفقیت";
                                break;
                            case "7":
                                lblTitr.Text = "نیمکره های مغز";
                                break;
                            case "8":
                                lblTitr.Text = "هوش مصنوعی";
                                break;
                        }
                        panel4.Visible = false;
                        panel1.Visible = true;
                        lblDescription.Visible = false;
                        lblTitr.Visible = true;
                        btnExit.Visible = true;
                        txtText.Visible = true;
                        lblHour.Visible = true;
                        lblMinute.Visible = true;
                        lblSecond.Visible = true;
                        label9.Visible = true;
                        label7.Visible = true;
                        lblTitr.Left = (this.Width - lblTitr.Width) / 2;
                        txtText.Text = File.ReadAllText(Application.StartupPath + @"\Text\" + Name.Remove(0, 11) + ".txt");
                        timer.Start();
                        part2++;
                    }
                    catch
                    {
                       MessageBox.Show(".لطفا متن خود را انتخاب کنید", "خطا!", MessageBoxButtons.OK);
                    }
                }
                else if (part2==2)
                {
                    panel4.Visible = false;
                    panel2.Visible = true;
                    label2.Text = "زمان مطالعه:";
                    btnNext.Visible = true;
                    btnBack.Visible = true;
                    btnSubmit.Visible = false;
                    lblHour.Visible = false;
                    lblMinute.Visible = false;
                    lblSecond.Visible = false;
                    label9.Visible = false;
                    label7.Visible = false;
                    timer.Stop();
                    switch (Name.Remove(0,11))
                    {
                        case "1":
                            lblQuestion.Text = "عمیق ترین چاهی که تاکنون حفر شده در کدام کشور و با چه عمقی بوده است؟";
                            location();
                            rdo_answer1.Text += "ژاپن 2203 کیلومتر";
                            rdo_answer2.Text += "آمریکا 1203 کیلومتر";
                            rdo_answer3.Text += "روسیه 1203 کیلومتر";
                            rdo_answer4.Text += "چین 2203 کیلومتر";
                            break;
                        case "2":
                            lblQuestion.Text = "بیل گیتس در چند سالگی وارد مدرسه ی لاکی ساید شد؟";
                            location();
                            rdo_answer1.Text += "15 سالگی";
                            rdo_answer2.Text += "13 سالگی";
                            rdo_answer3.Text += "17 سالگی";
                            rdo_answer4.Text += "12 سالگی";
                            break;
                        case "3":
                            lblQuestion.Text = "شخصیت به همه قسمت ها و ویژگی هایی اطلاق می شود که معرف.......... یک شخص است.";
                            location();
                            rdo_answer1.Text += "احساسات";
                            rdo_answer2.Text += "تفکر";
                            rdo_answer3.Text += "رفتار";
                            rdo_answer4.Text += "ادراک";
                            break;
                        case "4":
                            lblQuestion.Text = "مسئولیت طراحی  و سازماندهی رفتار ها مربوط به کدام قسمت مغز است؟";
                            location();
                            rdo_answer1.Text += "قسمت عقبی مغز";
                            rdo_answer2.Text += "قسمت بالایی مغز";
                            rdo_answer3.Text += "قسمت جلوی مغز";
                            rdo_answer4.Text += "قسمت پایینی مغز";
                            break;
                        case "5":
                            lblQuestion.Text = "سختترین کار یک مدیردر مدرسه چیست؟";
                            location();
                            rdo_answer1.Text += "قضاوت کردن در مورد والدین کودکان";
                            rdo_answer2.Text += "قضاوت کردن در اختلافات کودکان";
                            rdo_answer3.Text += "منضبط کردن کودکان";
                            rdo_answer4.Text += "تربیت کردن کودکان";
                            break;
                        case "6":
                            lblQuestion.Text = "دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text += "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text += "خودم و دیگران";
                            rdo_answer3.Text += "هدفم و خودم";
                            rdo_answer4.Text += "خودم و خواسته‌هایم";
                            break;
                        case "7":
                            lblQuestion.Text = "ما انسان ها از چند درصد توانایی مغز استفاده می کنیم ؟";
                            location();
                            rdo_answer1.Text += "6 تا 10 درصد";
                            rdo_answer2.Text += "15 تا 20 درصد";
                            rdo_answer3.Text += "10 تا 20 درصد";
                            rdo_answer4.Text += "30 درصد";
                            break;
                        case "8":
                            lblQuestion.Text = "بنیانگذار علم هوش مصنوعی چه کسی است ؟";
                            location();
                            rdo_answer1.Text += "واینر";
                            rdo_answer2.Text += "تورینگ";
                            rdo_answer3.Text += "جان مک کارتی";
                            rdo_answer4.Text += "بول ";
                            break;
                    }
                }
              //-----
            }
          else if (part==1)
            { 
                lblDescription.Visible = false;
                lblTitr.Visible = true;
                btnExit.Visible = true;
                btnSubmit.Location = new Point(713, 564);
                txtText.Visible = true;
                Random rdm = new Random();
                i= Convert.ToByte(rdm.Next(1, 9));
                switch (i)
                {
                    case 1:
                        lblTitr.Text = "اعماق زمین";
                        break;
                    case 2:
                        lblTitr.Text = "بیل گیتس";
                        break;
                    case 3:
                        lblTitr.Text = "روان شناسی شناختی";
                        break;
                    case 4:
                        lblTitr.Text = "کودکان";
                        break;
                    case 5:
                        lblTitr.Text = "مدیر";
                        break;
                    case 6:
                        lblTitr.Text = "موفقیت";
                        break;
                    case 7:
                        lblTitr.Text = "نیمکره های مغز";
                        break;
                    case 8:
                        lblTitr.Text = "هوش مصنوعی";
                        break;
                }
                lblTitr.Left = (this.Width - lblTitr.Width) / 2;
              //  i = 1;
                txtText.Text = File.ReadAllText(Application.StartupPath + @"\Text\" +i+ ".txt");
                timer.Start();
            }
            else if (part==2)
            {
                timer.Stop();
                panel1.Visible = false;
                lblHour.Visible = false;
                lblMinute.Visible = false;
                lblSecond.Visible = false;
                label9.Visible = false;
                label7.Visible = false;
                panel2.Visible = true;
                btnNext.Visible = true;
                btnBack.Visible = true;
                btnSubmit.Visible = false;      
                switch (i)
                {
                    case 1:
                        lblQuestion.Text = "عمیق ترین چاهی که تاکنون حفر شده در کدام کشور و با چه عمقی بوده است؟";
                        location();
                        rdo_answer1.Text += "ژاپن 2203 کیلومتر";
                        rdo_answer2.Text += "آمریکا 1203 کیلومتر";
                        rdo_answer3.Text += "روسیه 1203 کیلومتر";
                        rdo_answer4.Text += "چین 2203 کیلومتر";
                        break;
                    case 2:
                        lblQuestion.Text = "بیل گیتس در چند سالگی وارد مدرسه ی لاکی ساید شد؟";
                        location();
                        rdo_answer1.Text += "15 سالگی";
                        rdo_answer2.Text += "13 سالگی";
                        rdo_answer3.Text += "17 سالگی";
                        rdo_answer4.Text += "12 سالگی";
                        break;
                    case 3:
                        lblQuestion.Text = "شخصیت به همه قسمت ها و ویژگی هایی اطلاق می شود که معرف.......... یک شخص است.";
                        location();
                        rdo_answer1.Text += "احساسات";
                        rdo_answer2.Text += "تفکر";
                        rdo_answer3.Text += "رفتار";
                        rdo_answer4.Text += "ادراک";
                        break;
                    case 4:
                        lblQuestion.Text = "مسئولیت طراحی  و سازماندهی رفتار ها مربوط به کدام قسمت مغز است؟";
                        location();
                        rdo_answer1.Text += "قسمت عقبی مغز";
                        rdo_answer2.Text += "قسمت بالایی مغز";
                        rdo_answer3.Text += "قسمت جلوی مغز";
                        rdo_answer4.Text += "قسمت پایینی مغز";
                        break;
                    case 5:
                        lblQuestion.Text = "سختترین کار یک مدیردر مدرسه چیست؟";
                        location();
                        rdo_answer1.Text += "قضاوت کردن در مورد والدین کودکان";
                        rdo_answer2.Text += "قضاوت کردن در اختلافات کودکان";
                        rdo_answer3.Text += "منضبط کردن کودکان";
                        rdo_answer4.Text += "تربیت کردن کودکان";
                        break;
                    case 6:
                        lblQuestion.Text = "دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                        location();
                        rdo_answer1.Text += "از خودم و آنچه برایم اتفاق می افتد";
                        rdo_answer2.Text += "خودم و دیگران";
                        rdo_answer3.Text += "هدفم و خودم";
                        rdo_answer4.Text += "خودم و خواسته‌هایم";
                        break;
                    case 7:
                        lblQuestion.Text = "ما انسان ها از چند درصد توانایی مغز استفاده می کنیم ؟";
                        location();
                        rdo_answer1.Text += "6 تا 10 درصد"; 
                        rdo_answer2.Text += "15 تا 20 درصد";
                        rdo_answer3.Text += "10 تا 20 درصد";
                        rdo_answer4.Text += "30 درصد";
                        break;
                    case 8:
                        lblQuestion.Text = "بنیانگذار علم هوش مصنوعی چه کسی است ؟";
                        location();
                        rdo_answer1.Text += "واینر";
                        rdo_answer2.Text += "تورینگ";
                        rdo_answer3.Text += "جان مک کارتی";
                        rdo_answer4.Text += "بول ";
                        break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Check.click = false;
            part = 0;
            part2 = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Check.click==true)
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
                if (Second==61)
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
                    if (Minute==61)
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
            else
            {
                second++;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Check.click==true)
            {
                switch (Name.Remove(0,11))
                {
                    case "1":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            lblQuestion.Text = "ژول ورن سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();

                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "ژول ورن سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "قطر هسته درونی زمین چقدر است؟";
                            location();
                            rdo_answer1.Text = "500 کیلومتر";
                            rdo_answer2.Text = "5000 کیلومتر";
                            rdo_answer3.Text = "6000 کیلومتر";
                            rdo_answer4.Text = "1220 کیلومتر";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "قطر هسته درونی زمین چقدر است؟";
                            location();
                            rdo_answer1.Text = "500 کیلومتر";
                            rdo_answer2.Text = "5000 کیلومتر";
                            rdo_answer3.Text = "6000 کیلومتر";
                            rdo_answer4.Text = "1220 کیلومتر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case "2":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اولین دانشگاهی که بیل گیتس در آن پذیرفته شد کدام بود؟";
                            location();
                            rdo_answer1.Text = "هاروارد";
                            rdo_answer2.Text = "بروکلین";
                            rdo_answer3.Text = "استکهلم";
                            rdo_answer4.Text = "کمبریج";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "اولین دانشگاهی که بیل گیتس در آن پذیرفته شد کدام بود؟";
                            location();
                            rdo_answer1.Text = "هاروارد";
                            rdo_answer2.Text = "بروکلین";
                            rdo_answer3.Text = "استکهلم";
                            rdo_answer4.Text = "کمبریج";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case "3":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "-  قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "مطالعات بیولوژیکی";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "-  مطالعات بیولوژیکی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مطالعات موردی به شدت وابسته به.......... است.";
                            location();
                            rdo_answer1.Text = " رفتار مشاهده شونده";
                            rdo_answer2.Text = "تفکرات مشاهده شونده";
                            rdo_answer3.Text = " تفسیر مشاهده کننده";
                            rdo_answer4.Text = " تفکرات مشاهده کننده";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "مطالعات موردی به شدت وابسته به.......... است.";
                            location();
                            rdo_answer1.Text = " رفتار مشاهده شونده";
                            rdo_answer2.Text = "تفکرات مشاهده شونده";
                            rdo_answer3.Text = " تفسیر مشاهده کننده";
                            rdo_answer4.Text = " تفکرات مشاهده کننده";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case "4":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = "3تا 5 سال";
                            rdo_answer2.Text = "2 تا 4سال";
                            rdo_answer3.Text = "4 تا 6 سال";
                            rdo_answer4.Text = " 3 تا 4 سال";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = "3تا 5 سال";
                            rdo_answer2.Text = "2 تا 4سال";
                            rdo_answer3.Text = "4 تا 6 سال";
                            rdo_answer4.Text = " 3 تا 4 سال";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند.";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند.";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "در فعالیت‌های خود ثبات قدم دارند";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "در فعالیت‌های خود ثبات قدم دارند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = "20 تا 30 دقیقه";
                            rdo_answer2.Text = "15 تا 20 دقیقه";
                            rdo_answer3.Text = "10 تا 20 دقیقه";
                            rdo_answer4.Text = "10 تا 40 دقیقه";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = " 20 تا 30 دقیقه";
                            rdo_answer2.Text = "15 تا 20 دقیقه";
                            rdo_answer3.Text = "10 تا 20 دقیقه";
                            rdo_answer4.Text = "10 تا 40 دقیقه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "500 تا 600 کلمه";
                            rdo_answer2.Text = "1200 کلمه";
                            rdo_answer3.Text = "5000 تا 6000 کلمه";
                            rdo_answer4.Text = "50 کلمه";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "500 تا 600 کلمه";
                            rdo_answer2.Text = "1200 کلمه";
                            rdo_answer3.Text = "5000 تا 6000 کلمه";
                            rdo_answer4.Text = "50 کلمه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چرا کودکان بسیار سوال می پرسند؟";
                            location();
                            rdo_answer1.Text = " نداشتن اطلاعات کافی";
                            rdo_answer2.Text = "ارضای حس کنجکاوی";
                            rdo_answer3.Text = " کسب توجه بزرگسالان";
                            rdo_answer4.Text = "ب و ج";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "چرا کودکان بسیار سوال می پرسند؟";
                            location();
                            rdo_answer1.Text = " نداشتن اطلاعات کافی";
                            rdo_answer2.Text = "ارضای حس کنجکاوی";
                            rdo_answer3.Text = " کسب توجه بزرگسالان";
                            rdo_answer4.Text = "ب و ج";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case "5":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "مهربان و منعطف";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "مهربان و منعطف";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بزرگترین  قصور مدرسه در........ میباشد";
                            location();
                            rdo_answer1.Text = "دروس آموزشی";
                            rdo_answer2.Text = "تنبیه کودکان";
                            rdo_answer3.Text = "قوانین انضباطی";
                            rdo_answer4.Text = "مکاتبات";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "بزرگترین  قصور مدرسه در........ میباشد";
                            location();
                            rdo_answer1.Text = "دروس آموزشی";
                            rdo_answer2.Text = "تنبیه کودکان";
                            rdo_answer3.Text = "قوانین انضباطی";
                            rdo_answer4.Text = "مکاتبات";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case "6":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Font = new Font("B Mitra", 14);
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Font = new Font("B Mitra", 14);
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            lblQuestion.Font = new Font("B Mitra", 16);
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Font = new Font("B Mitra", 16);
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "آن شخص در چند سالگی به حال خود تا سف می خورد ؟";
                            location();
                            rdo_answer1.Text = "بیست سالگی";
                            rdo_answer2.Text = "سی سالگی";
                            rdo_answer3.Text = "چهل سالگی";
                            rdo_answer4.Text = "میانسالی";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "آن شخص در چند سالگی به حال خود تا سف می خورد ؟";
                            location();
                            rdo_answer1.Text = "بیست سالگی";
                            rdo_answer2.Text = "سی سالگی";
                            rdo_answer3.Text = "چهل سالگی";
                            rdo_answer4.Text = "میانسالی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case "7":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در هنگام خواب بسیار عمیق فرکانس مغز انسان چند است؟";
                            location();
                            rdo_answer1.Text = "21 سیکل در ثانیه";
                            rdo_answer2.Text = "85 سیکل در ثانیه ";
                            rdo_answer3.Text = "حدود 1 سیکل در ثانیه";
                            rdo_answer4.Text = "40سیکل در ثانیه";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "در هنگام خواب بسیار عمیق فرکانس مغز انسان چند است؟";
                            location();
                            rdo_answer1.Text = "21 سیکل در ثانیه";
                            rdo_answer2.Text = "85 سیکل در ثانیه ";
                            rdo_answer3.Text = "حدود 1 سیکل در ثانیه";
                            rdo_answer4.Text = "40سیکل در ثانیه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case "8":
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یک عامل هوشمند سیستمی است که";
                            location();
                            rdo_answer1.Text = "با شناخت محیط اطراف خود شانس موفقیت خود را بالا می برد";
                            rdo_answer2.Text = "با شناخت از وجود خود شانس موفقیت خود را بالا می برد";
                            rdo_answer3.Text = "با شناخت عکس العمل در مقابل کنش ها شانس موفقیت خود را بالا می برد";
                            rdo_answer4.Text = "با شناخت قوانین و رویه ها شانس موفقیت خود را بالا میبرد";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "یک عامل هوشمند سیستمی است که";
                            location();
                            rdo_answer1.Text = "با شناخت محیط اطراف خود شانس موفقیت خود را بالا می برد";
                            rdo_answer2.Text = "با شناخت از وجود خود شانس موفقیت خود را بالا می برد";
                            rdo_answer3.Text = "با شناخت عکس العمل در مقابل کنش ها شانس موفقیت خود را بالا می برد";
                            rdo_answer4.Text = "با شناخت قوانین و رویه ها شانس موفقیت خود را بالا میبرد";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Visible = false;
                            label1.Visible = false;
                            lblSpeed.Text = Hour + ":" + Minute + ":" + Second;
                            btnBack.Visible = false;
                            btnNext.Visible = false;
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                }
            }
            else
            {
              //------------------------------------------------------------------------------------------------------------------------------
                     switch (i)
                {
                    case 1:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            lblQuestion.Text = "ژول ورن سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();

                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "ژول ورن سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "قطر هسته درونی زمین چقدر است؟";
                            location();
                            rdo_answer1.Text = "500 کیلومتر";
                            rdo_answer2.Text = "5000 کیلومتر";
                            rdo_answer3.Text = "6000 کیلومتر";
                            rdo_answer4.Text = "1220 کیلومتر";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "قطر هسته درونی زمین چقدر است؟";
                            location();
                            rdo_answer1.Text = "500 کیلومتر";
                            rdo_answer2.Text = "5000 کیلومتر";
                            rdo_answer3.Text = "6000 کیلومتر";
                            rdo_answer4.Text = "1220 کیلومتر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((67 * ((21 + 23 + 19) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;
                                lblSpeed.Text = (((67 * ((21 + 23 + 19) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case 2:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اولین دانشگاهی که بیل گیتس در آن پذیرفته شد کدام بود؟";
                            location();
                            rdo_answer1.Text = "هاروارد";
                            rdo_answer2.Text = "بروکلین";
                            rdo_answer3.Text = "استکهلم";
                            rdo_answer4.Text = "کمبریج";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "اولین دانشگاهی که بیل گیتس در آن پذیرفته شد کدام بود؟";
                            location();
                            rdo_answer1.Text = "هاروارد";
                            rdo_answer2.Text = "بروکلین";
                            rdo_answer3.Text = "استکهلم";
                            rdo_answer4.Text = "کمبریج";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((58 * ((22 + 20 + 21) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((58 * ((22 + 20 + 21) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case 3:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "مطالعات بیولوژیکی";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "مطالعات بیولوژیکی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مطالعات موردی به شدت وابسته به.......... است.";
                            location();
                            rdo_answer1.Text = " رفتار مشاهده شونده";
                            rdo_answer2.Text = "تفکرات مشاهده شونده";
                            rdo_answer3.Text = " تفسیر مشاهده کننده";
                            rdo_answer4.Text = " تفکرات مشاهده کننده";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "مطالعات موردی به شدت وابسته به.......... است.";
                            location();
                            rdo_answer1.Text = " رفتار مشاهده شونده";
                            rdo_answer2.Text = "تفکرات مشاهده شونده";
                            rdo_answer3.Text = " تفسیر مشاهده کننده";
                            rdo_answer4.Text = " تفکرات مشاهده کننده";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((49 * ((19 + 20 + 23) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((49 * ((19 + 20 + 23) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case 4:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = "3تا 5 سال";
                            rdo_answer2.Text = "2 تا 4سال";
                            rdo_answer3.Text = "4 تا 6 سال";
                            rdo_answer4.Text = " 3 تا 4 سال";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = "3تا 5 سال";
                            rdo_answer2.Text = "2 تا 4سال";
                            rdo_answer3.Text = "4 تا 6 سال";
                            rdo_answer4.Text = " 3 تا 4 سال";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند.";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند.";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "در فعالیت‌های خود ثبات قدم دارند";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "در فعالیت‌های خود ثبات قدم دارند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = "20 تا 30 دقیقه";
                            rdo_answer2.Text = "15 تا 20 دقیقه";
                            rdo_answer3.Text = "10 تا 20 دقیقه";
                            rdo_answer4.Text = "10 تا 40 دقیقه";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = " 20 تا 30 دقیقه";
                            rdo_answer2.Text = "15 تا 20 دقیقه";
                            rdo_answer3.Text = "10 تا 20 دقیقه";
                            rdo_answer4.Text = "10 تا 40 دقیقه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "500 تا 600 کلمه";
                            rdo_answer2.Text = "1200 کلمه";
                            rdo_answer3.Text = "5000 تا 6000 کلمه";
                            rdo_answer4.Text = "50 کلمه";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "500 تا 600 کلمه";
                            rdo_answer2.Text = "1200 کلمه";
                            rdo_answer3.Text = "5000 تا 6000 کلمه";
                            rdo_answer4.Text = "50 کلمه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چرا کودکان بسیار سوال می پرسند؟";
                            location();
                            rdo_answer1.Text = " نداشتن اطلاعات کافی";
                            rdo_answer2.Text = "ارضای حس کنجکاوی";
                            rdo_answer3.Text = " کسب توجه بزرگسالان";
                            rdo_answer4.Text = "ب و ج";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "چرا کودکان بسیار سوال می پرسند؟";
                            location();
                            rdo_answer1.Text = " نداشتن اطلاعات کافی";
                            rdo_answer2.Text = "ارضای حس کنجکاوی";
                            rdo_answer3.Text = " کسب توجه بزرگسالان";
                            rdo_answer4.Text = "ب و ج";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((45 * ((20 + 21 + 21) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((45 * ((20 + 21 + 21) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case 5:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "مهربان و منعطف";
                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "مهربان و منعطف";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بزرگترین  قصور مدرسه در........ میباشد";
                            location();
                            rdo_answer1.Text = "دروس آموزشی";
                            rdo_answer2.Text = "تنبیه کودکان";
                            rdo_answer3.Text = "قوانین انضباطی";
                            rdo_answer4.Text = "مکاتبات";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "بزرگترین  قصور مدرسه در........ میباشد";
                            location();
                            rdo_answer1.Text = "دروس آموزشی";
                            rdo_answer2.Text = "تنبیه کودکان";
                            rdo_answer3.Text = "قوانین انضباطی";
                            rdo_answer4.Text = "مکاتبات";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((49 * ((22 + 23 + 24) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((49 * ((22 + 23 + 24) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case 6:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer1.Checked == true)
                        {
                            lblQuestion.Font = new Font("B Mitra", 14);
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Font = new Font("B Mitra", 14);
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            lblQuestion.Font = new Font("B Mitra", 16);
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Font = new Font("B Mitra", 16);
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "آن شخص در چند سالگی به حال خود تا سف می خورد ؟";
                            location();
                            rdo_answer1.Text = "بیست سالگی";
                            rdo_answer2.Text = "سی سالگی";
                            rdo_answer3.Text = "چهل سالگی";
                            rdo_answer4.Text = "میانسالی";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "آن شخص در چند سالگی به حال خود تا سف می خورد ؟";
                            location();
                            rdo_answer1.Text = "بیست سالگی";
                            rdo_answer2.Text = "سی سالگی";
                            rdo_answer3.Text = "چهل سالگی";
                            rdo_answer4.Text = "میانسالی";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((39 * ((24 + 20 + 21) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((39 * ((24 + 20 + 21) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;

                    case 7:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در هنگام خواب بسیار عمیق فرکانس مغز انسان چند است؟";
                            location();
                            rdo_answer1.Text = "21 سیکل در ثانیه";
                            rdo_answer2.Text = "85 سیکل در ثانیه ";
                            rdo_answer3.Text = "حدود 1 سیکل در ثانیه";
                            rdo_answer4.Text = "40سیکل در ثانیه";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "در هنگام خواب بسیار عمیق فرکانس مغز انسان چند است؟";
                            location();
                            rdo_answer1.Text = "21 سیکل در ثانیه";
                            rdo_answer2.Text = "85 سیکل در ثانیه ";
                            rdo_answer3.Text = "حدود 1 سیکل در ثانیه";
                            rdo_answer4.Text = "40سیکل در ثانیه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((39 * ((22 + 19 + 20) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((39 * ((22 + 19 + 20) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                    case 8:
                        //Qu 2
                        if (numQuestion == 1 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[0] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                        }
                        else if (numQuestion == 1)
                        {
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 3
                        else if (numQuestion == 2 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[1] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                        }
                        else if (numQuestion == 2)
                        {
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 4
                        else if (numQuestion == 3 && rdo_answer4.Checked == true)
                        {
                            numScore++;
                            check[2] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                        }
                        else if (numQuestion == 3)
                        {
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 5
                        else if (numQuestion == 4 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[3] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                        }
                        else if (numQuestion == 4)
                        {
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 6
                        else if (numQuestion == 5 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[4] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                        }
                        else if (numQuestion == 5)
                        {
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 7
                        else if (numQuestion == 6 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            check[5] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                        }
                        else if (numQuestion == 6)
                        {
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 8
                        else if (numQuestion == 7 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[6] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";

                        }
                        else if (numQuestion == 7)
                        {
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 9
                        else if (numQuestion == 8 && rdo_answer3.Checked == true)
                        {
                            numScore++;
                            check[7] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                        }
                        else if (numQuestion == 8)
                        {
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        //Qu 10
                        else if (numQuestion == 9 && rdo_answer2.Checked == true)
                        {
                            numScore++;
                            check[8] = "correct";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                            lblQuestion.Text = "یک عامل هوشمند سیستمی است که";
                            location();
                            rdo_answer1.Text = "با شناخت محیط اطراف خود شانس موفقیت خود را بالا می برد";
                            rdo_answer2.Text = "با شناخت از وجود خود شانس موفقیت خود را بالا می برد";
                            rdo_answer3.Text = "با شناخت عکس العمل در مقابل کنش ها شانس موفقیت خود را بالا می برد";
                            rdo_answer4.Text = "با شناخت قوانین و رویه ها شانس موفقیت خود را بالا میبرد";
                        }
                        else if (numQuestion == 9)
                        {
                            lblQuestion.Text = "یک عامل هوشمند سیستمی است که";
                            location();
                            rdo_answer1.Text = "با شناخت محیط اطراف خود شانس موفقیت خود را بالا می برد";
                            rdo_answer2.Text = "با شناخت از وجود خود شانس موفقیت خود را بالا می برد";
                            rdo_answer3.Text = "با شناخت عکس العمل در مقابل کنش ها شانس موفقیت خود را بالا می برد";
                            rdo_answer4.Text = "با شناخت قوانین و رویه ها شانس موفقیت خود را بالا میبرد";
                            numQuestion++;
                            lblNum1.Text = numQuestion.ToString();
                        }
                        else if (numQuestion == 10 && rdo_answer1.Checked == true)
                        {
                            numScore++;
                            numQuestion++;
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((30 * ((22 + 20 + 20) / 3))) / second*60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        else
                        {
                            panel2.Visible = false;
                            panel3.Visible = true;
                            lblAnswer.Text = numScore.ToString();
                            try
                            {
                                second--;

                                lblSpeed.Text = (((30 * ((22 + 20 + 20) / 3))) / second * 60).ToString();
                            }
                            catch
                            {
                                lblSpeed.Text = "0";
                            }
                            btnExit.Left = 359;
                            btnExit.ForeColor = Color.Red;
                        }
                        break;
                }
            }
           
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            numQuestion--;
            lblNum1.Text = numQuestion.ToString();
            if (numQuestion==0)
            {
                numQuestion = 1;
                lblNum1.Text = numQuestion.ToString();
            }
            if (Check.click==true)
            {
                switch (Name.Remove(0,11))
                {
                    case "1":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "عمیق ترین چاهی که تاکنون حفر شده در کدام کشور و با چه عمقی بوده است؟";
                            location();
                            rdo_answer1.Text = "ژاپن 2203 کیلومتر";
                            rdo_answer2.Text = "آمریکا 1203 کیلومتر";
                            rdo_answer3.Text = "روسیه 1203 کیلومتر";
                            rdo_answer4.Text = "چین 2203 کیلومتر";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ژول ورون سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                        }
                        break;
                    case "2":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس در چند سالگی وارد مدرسه ی لاکی ساید شد؟";
                            location();
                            rdo_answer1.Text = "15 سالگی";
                            rdo_answer2.Text = "13 سالگی";
                            rdo_answer3.Text = "17 سالگی";
                            rdo_answer4.Text = "12 سالگی";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                        }
                        break;
                    case "3":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "شخصیت به همه قسمت ها و ویژگی هایی اطلاق می شود که معرف.......... یک شخص است.";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "تفکر";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "ادراک";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "مطالعات بیولوژیکی";
                        }
                        break;
                    case "4":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مسئولیت طراحی  و سازماندهی رفتار ها مربوط به کدام قسمت مغز است؟";
                            location();
                            rdo_answer1.Text = "قسمت عقبی مغز";
                            rdo_answer2.Text = "قسمت بالایی مغز";
                            rdo_answer3.Text = "قسمت جلوی مغز";
                            rdo_answer4.Text = "قسمت پایینی مغز";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = " ۳ تا ۵ سال";
                            rdo_answer2.Text = "  ۲ تا ۴ سال";
                            rdo_answer3.Text = " ۴ تا ۶ سال";
                            rdo_answer4.Text = " ۳ تا ۴ سال";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = ".در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "-  در فعالیت‌های خود ثبات قدم دارند";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = " ۲۰ تا ۳۰ دقیقه";
                            rdo_answer2.Text = " ۱۵ تا ۲۰ دقیقه";
                            rdo_answer3.Text = "۱۰ تا ۲۰ دقیقه";
                            rdo_answer4.Text = "۱۰ تا ۴۰ دقیقه";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "۵۰۰ تا ۶۰۰ کلمه";
                            rdo_answer2.Text = "۱۲۰۰ کلمه";
                            rdo_answer3.Text = "۵۰۰۰ تا ۶۰۰۰ کلمه";
                            rdo_answer4.Text = "۵۰ کلمه";
                        }
                        break;
                    case "5":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سختترین کار یک مدیردر مدرسه چیست؟";
                            location();
                            rdo_answer1.Text = "قضاوت کردن در مورد والدین کودکان";
                            rdo_answer2.Text = "قضاوت کردن در اختلافات کودکان";
                            rdo_answer3.Text = "منضبط کردن کودکان";
                            rdo_answer4.Text = "تربیت کردن کودکان";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "تمهربان و منعطف";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                        }
                        break;
                    case "6":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Font = new Font("B Mitra", 16);
                            lblQuestion.Text = "دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Font = new Font("B Mitra", 14);
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Font = new Font("B Mitra", 16);
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                        }
                        break;

                    case "7":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ما انسان ها از چند درصد توانایی مغز استفاده می کنیم ؟";
                            location();
                            rdo_answer1.Text = "6 تا 10 درصد";
                            rdo_answer2.Text = "15 تا 20 درصد";
                            rdo_answer3.Text = "10 تا 20 درصد";
                            rdo_answer4.Text = "30 درصد";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                        }
                        break;
                    case "8":
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بنیانگذار علم هوش مصنوعی چه کسی است ؟";
                            location();
                            rdo_answer1.Text = "واینر";
                            rdo_answer2.Text = "تورینگ";
                            rdo_answer3.Text = "جان مک کارتی";
                            rdo_answer4.Text = "بول ";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                        }
                        break;
                }
            }
            else
            {
                     switch (i)
                {
                    case 1:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "عمیق ترین چاهی که تاکنون حفر شده در کدام کشور و با چه عمقی بوده است؟";
                            location();
                            rdo_answer1.Text = "ژاپن 2203 کیلومتر";
                            rdo_answer2.Text = "آمریکا 1203 کیلومتر";
                            rdo_answer3.Text = "روسیه 1203 کیلومتر";
                            rdo_answer4.Text = "چین 2203 کیلومتر";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ژول ورون سفر خود را به درون زمین از کجا شروع کرد؟";
                            location();
                            rdo_answer1.Text = "ایتالیا";
                            rdo_answer2.Text = "ایسلند";
                            rdo_answer3.Text = "آلمان";
                            rdo_answer4.Text = "شیلی";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "الماس در چه عمقی از زمین درست می شود؟";
                            location();
                            rdo_answer1.Text = "۶۰۰ کیلومتری";
                            rdo_answer2.Text = "۹۰۰ کیلومتری";
                            rdo_answer3.Text = "۱۲۰۳ کیلومتری";
                            rdo_answer4.Text = "۵۰۰ کیلومتری";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چگالی زمین در قسمتهای مختلف آن چگونه است؟";
                            location();
                            rdo_answer1.Text = "مواد درسطح چگالی کمتری دارند";
                            rdo_answer2.Text = "عمق زمین چگالی کمتری دارد";
                            rdo_answer3.Text = "مواد در سطح چگالی بالاتری دارد";
                            rdo_answer4.Text = "نتوانسته‌اند چگالی زمین را به دست آورند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چند درصد از هسته را آهن تشکیل میدهد؟";
                            location();
                            rdo_answer1.Text = "۲۰ درصد";
                            rdo_answer2.Text = "درصد 70";
                            rdo_answer3.Text = "درصد 80";
                            rdo_answer4.Text = "درصد10";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چگونه آهن به درون سیلیکات راه پیدا می کند؟";
                            location();
                            rdo_answer1.Text = "تحت دمای بسیار بالا";
                            rdo_answer2.Text = "اهن نمی‌تواند به سیلیکات راه پیدا کند";
                            rdo_answer3.Text = "تحت فشار بسیار بالا";
                            rdo_answer4.Text = "در دمای بسیار پایین";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سالی در شیلی زمین لرزه اتفاق افتاد؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1860";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1880";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "خاصیت امواج برشی چیست؟";
                            location();
                            rdo_answer1.Text = "نمی توانند از درون جامدات عبور کنند";
                            rdo_answer2.Text = "می‌توانند از درون سنگهای مذاب عبور کنند";
                            rdo_answer3.Text = "نمیتوانند از درون جامدات و مایعات عبور کنند";
                            rdo_answer4.Text = "می توانند از درون جامدات عبور کنند";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "زلزله شناسان اطلاعات خود را از چه طریقی به دست می‌آورند؟";
                            location();
                            rdo_answer1.Text = "انفجارهای هسته ای ";
                            rdo_answer2.Text = "ایجاد زمین لرزه های ساختگی";
                            rdo_answer3.Text = "از روی حدس و گمان";
                            rdo_answer4.Text = "زمین لرزه هایی که قبلا اتفاق افتاده";
                        }
                        break;
                    case 2:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس در چند سالگی وارد مدرسه ی لاکی ساید شد؟";
                            location();
                            rdo_answer1.Text = "15 سالگی";
                            rdo_answer2.Text = "13 سالگی";
                            rdo_answer3.Text = "17 سالگی";
                            rdo_answer4.Text = "12 سالگی";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس متولد چه ماهی و سالی است؟";
                            location();
                            rdo_answer1.Text = "بیست و پنجم اکتبر 1955";
                            rdo_answer2.Text = "بیست و پنجم اکتبر 1988 ";
                            rdo_answer3.Text = "بیست و هشتم اکتبر 1955";
                            rdo_answer4.Text = "بیست و هشتم اکتبر 1988";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سازمانCCC در چه سالی تعطیل شد؟";
                            location();
                            rdo_answer1.Text = "1970";
                            rdo_answer2.Text = "1980";
                            rdo_answer3.Text = "1880";
                            rdo_answer4.Text = "1890";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس مدیرعاملی شرکت مایکروسافت را به چه کسی سپرد؟";
                            location();
                            rdo_answer1.Text = "بیل و ملیندا";
                            rdo_answer2.Text = "آلن";
                            rdo_answer3.Text = "جونز";
                            rdo_answer4.Text = "استیو بالمر";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سالی تولید کامپیوترAltair  منتشر شد؟";
                            location();
                            rdo_answer1.Text = "اکتبر 1975";
                            rdo_answer2.Text = "ژانوایه 1955";
                            rdo_answer3.Text = "اکتبر 1995";
                            rdo_answer4.Text = "ژانویه 1975";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مایکروسافت در چه سالی به طور رسمی ثبت شد؟";
                            location();
                            rdo_answer1.Text = "1976";
                            rdo_answer2.Text = "1975";
                            rdo_answer3.Text = "1986";
                            rdo_answer4.Text = "1995";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس در چند سالگی به یک میلیونر تبدیل شد؟";
                            location();
                            rdo_answer1.Text = "21 سالگی";
                            rdo_answer2.Text = "31 سالگی";
                            rdo_answer3.Text = "45 سالگی";
                            rdo_answer4.Text = "32 سالگی";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بیل گیتس نشان افتخاری KBE  خود را از دست چه کسی گرفته است؟";
                            location();
                            rdo_answer1.Text = "باراک اوباما";
                            rdo_answer2.Text = "فرانسیس اولاند";
                            rdo_answer3.Text = "ملکه انگلستان";
                            rdo_answer4.Text = "جورج دبلیو بوش";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "رئیس جمهور آمریکا در چه سالی نشان افتخار را به او تقدیم کرد؟";
                            location();
                            rdo_answer1.Text = "2005";
                            rdo_answer2.Text = "2016";
                            rdo_answer3.Text = "2017";
                            rdo_answer4.Text = "2015";
                        }
                        break;
                    case 3:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "شخصیت به همه قسمت ها و ویژگی هایی اطلاق می شود که معرف.......... یک شخص است.";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "تفکر";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "ادراک";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "باصطلاح ویژگی شخصیت یعنی چه؟";
                            location();
                            rdo_answer1.Text = "به جنبه خاصی از کل شخصیت آدمی اطلاق می شود";
                            rdo_answer2.Text = "به جنبه رفتاری شخصیت آدمی اطلاق می شود";
                            rdo_answer3.Text = "به جنبه ی احساسی  شخصیت آدمی طلاق می شود";
                            rdo_answer4.Text = "به جنبه ادراکی  شخصیت آدمی طلاق می‌شود";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چه کسی عقیده داشت که شخصیت از نهاد، خود و فراخود ساخته شده است؟";
                            location();
                            rdo_answer1.Text = "گوردن آلپورت";
                            rdo_answer2.Text = "کارل راجرز";
                            rdo_answer3.Text = "هیلگارد";
                            rdo_answer4.Text = "زیگموند فروید";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "از دید روانشناسی";
                            location();
                            rdo_answer1.Text = "همه افراد دارای شخصیت هستند";
                            rdo_answer2.Text = "افراد به دو گروه با شخصیت و بی شخصیت تقسیم می شوند";
                            rdo_answer3.Text = "افراد به دو گروه شخصیت خوب و شخصیت بد تقسیم می شوند";
                            rdo_answer4.Text = "افراد به دو گروه شخصیت مثبت و شخصیت منفی تقسیم می‌شوند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در نظریه های شخصیت جنبه مهم، برداشت یا تصوری است که از........... انسان و شخصیت ارائه شده";
                            location();
                            rdo_answer1.Text = "احساسات";
                            rdo_answer2.Text = "ماهیت";
                            rdo_answer3.Text = "رفتار";
                            rdo_answer4.Text = "تفکرات";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "تاریخچه مطالعه روانشناسی شخصیت به چه زمانی برمیگردد؟";
                            location();
                            rdo_answer1.Text = "قرن بیستم";
                            rdo_answer2.Text = "قرن هجدهم";
                            rdo_answer3.Text = "مصر باستان";
                            rdo_answer4.Text = "یونان باستان";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در عهد باستان افراد به چند دسته شخصیتی تقسیم  می‌شدند؟";
                            location();
                            rdo_answer1.Text = "سه دسته";
                            rdo_answer2.Text = "پنج دسته";
                            rdo_answer3.Text = "چهار دسته";
                            rdo_answer4.Text = "تقسیم بندی نداشتن";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "همه روانشناسان در چه موردی با هم توافق نظر دارند؟";
                            location();
                            rdo_answer1.Text = "داده های مربوط به سوابق زندگی";
                            rdo_answer2.Text = "فایده بالقوه هر یک از انواع چهارگانه داده ها";
                            rdo_answer3.Text = "داده های حاصل از گزارش های شخصی";
                            rdo_answer4.Text = "داده های جمع آوری شده توسط مشاهده گر";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "علمی ترین روش تحقیق در مورد شخصیت چیست؟";
                            location();
                            rdo_answer1.Text = "روش تجربی";
                            rdo_answer2.Text = "مطالعات موردی";
                            rdo_answer3.Text = "تحقیقات بالینی";
                            rdo_answer4.Text = "مطالعات بیولوژیکی";
                        }
                        break;
                    case 4:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مسئولیت طراحی  و سازماندهی رفتار ها مربوط به کدام قسمت مغز است؟";
                            location();
                            rdo_answer1.Text = "قسمت عقبی مغز";
                            rdo_answer2.Text = "قسمت بالایی مغز";
                            rdo_answer3.Text = "قسمت جلوی مغز";
                            rdo_answer4.Text = "قسمت پایینی مغز";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه سنی کودکان نمی‌توانند در حلاجی مشکلات خود را جای  شخص دیگر قرار دهند؟";
                            location();
                            rdo_answer1.Text = " ۳ تا ۵ سال";
                            rdo_answer2.Text = "  ۲ تا ۴ سال";
                            rdo_answer3.Text = " ۴ تا ۶ سال";
                            rdo_answer4.Text = " ۳ تا ۴ سال";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = ".در سن ۳ تا ۵ سال کودکان روی...........و........ متمرکز می‌شوند";
                            location();
                            rdo_answer1.Text = "دلیل ها و چراها";
                            rdo_answer2.Text = "صداها و رنگها";
                            rdo_answer3.Text = "علت ها و پیامدها";
                            rdo_answer4.Text = "جزئیات و رنگ ها";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان در پایان پنج سالگی";
                            location();
                            rdo_answer1.Text = "فرق بین کار خوب و بد را درک می کنند";
                            rdo_answer2.Text = "فرق بین کار خوب و بد را درک نمی کنند";
                            rdo_answer3.Text = "ارتباط بین علت و معلول را درک میکنند";
                            rdo_answer4.Text = "ارتباط بین علت و معلول را درک نمی کنند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سنی تمرکز آنان روی ظواهر است؟";
                            location();
                            rdo_answer1.Text = "۵ سالگی";
                            rdo_answer2.Text = "4 سالگی";
                            rdo_answer3.Text = "2 سالگی";
                            rdo_answer4.Text = "3 سالگی";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان در سن ۳ سالگی";
                            location();
                            rdo_answer1.Text = "از فعالیتی که شروع کردند خسته نمی شوند";
                            rdo_answer2.Text = "نمی تنوانند مدت زمان توجه خود را افزایش دهند";
                            rdo_answer3.Text = "قدرت تخیل و تصور ندارند";
                            rdo_answer4.Text = "-  در فعالیت‌های خود ثبات قدم دارند";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "دو کودک ۴ ساله چقدر به طول می انجامد؟";
                            location();
                            rdo_answer1.Text = " ۲۰ تا ۳۰ دقیقه";
                            rdo_answer2.Text = " ۱۵ تا ۲۰ دقیقه";
                            rdo_answer3.Text = "۱۰ تا ۲۰ دقیقه";
                            rdo_answer4.Text = "۱۰ تا ۴۰ دقیقه";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یادگیری در کودکان اغلب";
                            location();
                            rdo_answer1.Text = "تقلید از رفتار همبازی‌های خود است";
                            rdo_answer2.Text = "تقلید از رفتار همسالان خود است";
                            rdo_answer3.Text = "تقلید از فیلم های کارتون است";
                            rdo_answer4.Text = "تقلید از رفتار بزرگسالان است";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در پنج سالگی چند کلمه می توانند به کار بگیرند؟";
                            location();
                            rdo_answer1.Text = "۵۰۰ تا ۶۰۰ کلمه";
                            rdo_answer2.Text = "۱۲۰۰ کلمه";
                            rdo_answer3.Text = "۵۰۰۰ تا ۶۰۰۰ کلمه";
                            rdo_answer4.Text = "۵۰ کلمه";
                        }
                        break;
                    case 5:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "سختترین کار یک مدیردر مدرسه چیست؟";
                            location();
                            rdo_answer1.Text = "قضاوت کردن در مورد والدین کودکان";
                            rdo_answer2.Text = "قضاوت کردن در اختلافات کودکان";
                            rdo_answer3.Text = "منضبط کردن کودکان";
                            rdo_answer4.Text = "تربیت کردن کودکان";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یکی از موثرترین راهبردهای انضباطی........ است";
                            location();
                            rdo_answer1.Text = "منعطف بودن";
                            rdo_answer2.Text = "نرم برخورد کردن";
                            rdo_answer3.Text = "مهربانی";
                            rdo_answer4.Text = "قاطعیت";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودکان رفتارهای چه کسی را بهتر یاد می‌گیرند؟";
                            location();
                            rdo_answer1.Text = "کودکانی که نا آرام و ناسازگارند";
                            rdo_answer2.Text = "کودکانی که آرام و سازگار ند";
                            rdo_answer3.Text = "کودکانی که قانون شکن هستند";
                            rdo_answer4.Text = "کودکانی که شادترند";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "مدیران در شروع سال تحصیلی چه باید بکنند؟";
                            location();
                            rdo_answer1.Text = "قوانین انضباطی را جدی بگیرند";
                            rdo_answer2.Text = "قوانین انضباطی را به کودکان بیاموزند";
                            rdo_answer3.Text = "قوانین  انضباطی را نادیده بگیرند";
                            rdo_answer4.Text = "به دانستن خط مشی های انضباطی مدرسه بپردازند";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "پسر بچه که به دفتر مدرسه آورده شده بود چند سال داشت؟";
                            location();
                            rdo_answer1.Text = "7 سال";
                            rdo_answer2.Text = "8 سال";
                            rdo_answer3.Text = "6 سال";
                            rdo_answer4.Text = "5 سال";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "تنبیه کودکی که از پنجره دستمال بیرون انداخته بود چه بود؟";
                            location();
                            rdo_answer1.Text = "معذرت خواهی از معلم";
                            rdo_answer2.Text = "از دست دادن فرصت بازگشت به کلاس";
                            rdo_answer3.Text = "تنبیه بدنی";
                            rdo_answer4.Text = "تمیز کردن کلاس";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودک برای چه کاری مورد تشویق معلم قرار گرفت؟";
                            location();
                            rdo_answer1.Text = "گرفتن نمره خوب";
                            rdo_answer2.Text = "تمیز کردن کلاس";
                            rdo_answer3.Text = "معذرت خواهی";
                            rdo_answer4.Text = "تعویض تمام دستمال های دستشویی";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "کودک به والدینی..........و......... نیاز دارد";
                            location();
                            rdo_answer1.Text = "جدی و مقرراتی";
                            rdo_answer2.Text = "آرام و خونسرد";
                            rdo_answer3.Text = "قاطع و مهربان";
                            rdo_answer4.Text = "تمهربان و منعطف";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بر اساس قوانین و حقوق آموزشی فدرال";
                            location();
                            rdo_answer1.Text = "والدین باید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer2.Text = "والدین نباید همه اتفاقات در مورد کودک خود در مدرسه را بدانند";
                            rdo_answer3.Text = "والدین می توانند اطلاعات کودکان دیگر در مدرسه را بدانند";
                            rdo_answer4.Text = "والدین نمی‌توانند  اطلاعات کودکان دیگر در مدرسه را بدانند";
                        }
                        break;
                    case 6:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "راهگشای سوم زمانی وارد عمل شد که: 1-دومین راهگشای زندگی من زمانی حاصل شد که دانستم در قبال.......... و......... مسئول هستم.";
                            location();
                            rdo_answer1.Text = "از خودم و آنچه برایم اتفاق می افتد";
                            rdo_answer2.Text = "خودم و دیگران";
                            rdo_answer3.Text = "هدفم و خودم";
                            rdo_answer4.Text = "خودم و خواسته‌هایم";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "شما با............ و..............خود می توانید آینده خود را رقم بزنید.";
                            location();
                            rdo_answer1.Text = "فکر و اندیشه فعلی";
                            rdo_answer2.Text = "احساس و تصاویر ذهنی";
                            rdo_answer3.Text = " رفتار و عمل خود";
                            rdo_answer4.Text = "عمل و احساس خود";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "رفتارهای بیرونی شما.............شماست ؟";
                            location();
                            rdo_answer1.Text = "نتیجه تلاش‌های";
                            rdo_answer2.Text = "عکس العمل رفتار اطرافیان";
                            rdo_answer3.Text = "نتیجه توانمندی‌ها و استعدادهای درونی";
                            rdo_answer4.Text = "نماد باورهای درونی";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "حکایت انسان های موفق حکایت چه کسانی است؟";
                            location();
                            rdo_answer1.Text = "کسانی که تلاش فراوانی کردند";
                            rdo_answer2.Text = "تحصیلات عالی داشتند";
                            rdo_answer3.Text = "کسانی که با هیچ شروع کردند";
                            rdo_answer4.Text = "از کمک دیگران استفاده کردند";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "برای تحقق هدف ها و برنامه ریزی برای آنها چه باید کرد ؟";
                            location();
                            rdo_answer1.Text = "تمام سعی و تلاش‌مان را می‌کنیم";
                            rdo_answer2.Text = "آنها را مکتوب کنیم";
                            rdo_answer3.Text = "عالی و بی‌کم و کاست باشیم";
                            rdo_answer4.Text = "به نقطه شروع فکر کنیم";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در چه صورتی هیچ چیز نمی تواند مانع رسیدن به موفقیت شود ؟";
                            location();
                            rdo_answer1.Text = "باور اینکه برای موفقیت خلق شده ایم";
                            rdo_answer2.Text = "در صورتیکه پول و تحصیلات داریم";
                            rdo_answer3.Text = "نهایت سعی و تلاش خود را بکنیم";
                            rdo_answer4.Text = "همه اطرافیان به ما در رسیدن به هدف تلاش کنند";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "برای تغییر دادن زندگی خود باید ؟";
                            location();
                            rdo_answer1.Text = "پول بیشتری به دست آورید";
                            rdo_answer2.Text = "روش زندگیتان را عوض کنید";
                            rdo_answer3.Text = "تلاش بیشتری بکنید";
                            rdo_answer4.Text = "فکر خود را عوض کنید";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ثروت ،کار ،روابط و سلامتی در زندگی بیان گر چه چیزی است ؟";
                            location();
                            rdo_answer1.Text = "بیانگر این که فرصتهای مناسب تری داشته‌اید";
                            rdo_answer2.Text = "بیانگر تصاویر درونی شماست";
                            rdo_answer3.Text = "بیانگر میزان تلاش و کوشش شما";
                            rdo_answer4.Text = "بیانگر اینکه شما فرد خلاقی هستید";
                        }
                        break;

                    case 7:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ما انسان ها از چند درصد توانایی مغز استفاده می کنیم ؟";
                            location();
                            rdo_answer1.Text = "6 تا 10 درصد";
                            rdo_answer2.Text = "15 تا 20 درصد";
                            rdo_answer3.Text = "10 تا 20 درصد";
                            rdo_answer4.Text = "30 درصد";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "ضمیر ناخودآگاه:";
                            location();
                            rdo_answer1.Text = "خودمان آن را برنامه‌ریزی می‌کنیم.";
                            rdo_answer2.Text = "از قبل برنامه ریزی شده است.";
                            rdo_answer3.Text = "نمی توانیم آن را تغییر دهیم.";
                            rdo_answer4.Text = "هیچگاه تکامل می یابد.";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "نیمکره چپ مغز:";
                            location();
                            rdo_answer1.Text = "در جهان معنوی است.";
                            rdo_answer2.Text = "دنیای ادراک است.";
                            rdo_answer3.Text = " در جهان مادی است.";
                            rdo_answer4.Text = "دنیای تفکرات و احساسات است.";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "نیمکره ی راست:";
                            location();
                            rdo_answer1.Text = "بیشتر در جهان مادی است.";
                            rdo_answer2.Text = "به جزئیات توجه دارد.";
                            rdo_answer3.Text = "کل گراست.";
                            rdo_answer4.Text = "به تفاوت ها توجه میکند.";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "واحد اندازه گیری دستگاه الکتروانسفالو گراف چیست؟";
                            location();
                            rdo_answer1.Text = "زمان بر دقیقه. ";
                            rdo_answer2.Text = "زمان بر ثانیه.";
                            rdo_answer3.Text = "سیکل در دقیقه. ";
                            rdo_answer4.Text = "سیکل در ثانیه.";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "یک فرد معمولی در یک زمان معمولی و در یک روز معمولی در چه محیطی از امواج می باشد؟";
                            location();
                            rdo_answer1.Text = "دتا";
                            rdo_answer2.Text = "تتا ";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در کدام سطح از امواج مغزی افکار  ما بسیار واقعی و ملموس هستند؟";
                            location();
                            rdo_answer1.Text = "تتا";
                            rdo_answer2.Text = "دتا";
                            rdo_answer3.Text = "آلفا";
                            rdo_answer4.Text = "بتا";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بدرمان طبیعی و نرمال فعالیت مغز به هنگام بیداری چگونه است؟";
                            location();
                            rdo_answer1.Text = "بین ۳۰ تا ۴۰ است ";
                            rdo_answer2.Text = "پایین تر از ده است";
                            rdo_answer3.Text = "بالاتر از ۱۰ و پایین تر از ۲۰ است ";
                            rdo_answer4.Text = "بالاتر از ۲۰ است";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "امواج آلفا باعث می شود که کدام یک از مواد موجود در بدن در تعادل باشد؟";
                            location();
                            rdo_answer1.Text = "سدیم و پتاسیم";
                            rdo_answer2.Text = "سدیم و کلسیم ";
                            rdo_answer3.Text = "کلسیم و فسفر";
                            rdo_answer4.Text = "پتاسیم و کلسیم";
                        }
                        break;
                    case 8:
                        //Qu 1
                        if (numQuestion == 1)
                        {
                            if (check[0] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "بنیانگذار علم هوش مصنوعی چه کسی است ؟";
                            location();
                            rdo_answer1.Text = "واینر";
                            rdo_answer2.Text = "تورینگ";
                            rdo_answer3.Text = "جان مک کارتی";
                            rdo_answer4.Text = "بول ";
                        }
                        else if (numQuestion == 2)
                        {
                            if (check[1] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "چند دهه طول کشید تا هوش مصنوعی وارد بازار شود؟";
                            location();
                            rdo_answer1.Text = "چهار دهه";
                            rdo_answer2.Text = "سه دهه";
                            rdo_answer3.Text = "دو دهه";
                            rdo_answer4.Text = "یک دهه";
                        }
                        //Qu 3
                        else if (numQuestion == 3)
                        {
                            if (check[2] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "در زمان جنگ جهانی دوم............ زمینه را برای پیشرفت هوش مصنوعی  به وجود آورد.";
                            location();
                            rdo_answer1.Text = "مک کارتی";
                            rdo_answer2.Text = "بول";
                            rdo_answer3.Text = "تورینگ";
                            rdo_answer4.Text = "واینر";
                        }
                        //Qu 4
                        else if (numQuestion == 4)
                        {
                            if (check[3] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اولین چالش ها پیرامون هوش مصنوعی در چه سالی آغاز شد ؟";
                            location();
                            rdo_answer1.Text = "1945";
                            rdo_answer2.Text = "1843";
                            rdo_answer3.Text = "1943";
                            rdo_answer4.Text = "1845";
                        }
                        //Qu 5
                        else if (numQuestion == 5)
                        {
                            if (check[4] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اصطلاح AL شامل...........و...........است.";
                            location();
                            rdo_answer1.Text = "روان شناسی و فلسفه";
                            rdo_answer2.Text = "یادگیری و سازش";
                            rdo_answer3.Text = "محاسبات هوشمندانه و ترکیبی";
                            rdo_answer4.Text = "علم رایانه و فلسفه";
                        }
                        //Qu 6
                        else if (numQuestion == 6)
                        {
                            if (check[5] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "توسعه و پیشرفت تحقیقات در زمینه هوش مصنوعی در چه دهه ای اتفاق افتاد ؟";
                            location();
                            rdo_answer1.Text = "1960";
                            rdo_answer2.Text = "1970";
                            rdo_answer3.Text = "1980";
                            rdo_answer4.Text = "1950";
                        }
                        //Qu 7
                        else if (numQuestion == 7)
                        {
                            if (check[6] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "آزمون تورینگ چیست ؟";
                            location();
                            rdo_answer1.Text = "برای تست موفقیت شخص در مقایسه با ماشین";
                            rdo_answer2.Text = "برای تست هوش ماشین";
                            rdo_answer3.Text = "برای تست هوش شخص";
                            rdo_answer4.Text = "برای تست شناخت از وجود خود ";
                        }
                        //Qu 8
                        else if (numQuestion == 8)
                        {
                            if (check[7] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "اساس کار ربات امدادگر چگونه است ؟";
                            location();
                            rdo_answer1.Text = "شنا خت وجود خود";
                            rdo_answer2.Text = "نشان دادن عکس العمل در مقابل کنش ها";
                            rdo_answer3.Text = "شناخت محیط پیرامون خود";
                            rdo_answer4.Text = "بنشان دادن عکس العمل در مقابل وجود خود ";
                        }
                        //Qu 9
                        else if (numQuestion == 9)
                        {
                            if (check[8] == "correct")
                            {
                                numScore--;
                            }
                            lblQuestion.Text = "هوش مصنوعی مبنی بر............و..........میباشد.";
                            location();
                            rdo_answer1.Text = "قوانین و رویه های که خود تجربه و تحلیل می‌کند";
                            rdo_answer2.Text = "قوانین و رویه های از قبل تعبیه شده";
                            rdo_answer3.Text = "نظارت و اخذ تصمیم";
                            rdo_answer4.Text = "اخذ تصمیم و قوانین ";
                        }
                        break;
                }
            }
           
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            Name = rdo.Name;
        }
    }
    }
