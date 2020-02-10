namespace Tondkhani
{
    partial class Test_Incorrect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.lblWord4 = new System.Windows.Forms.Label();
            this.lblWord3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStart.Location = new System.Drawing.Point(729, 561);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 35);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(4, 561);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(147)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 43);
            this.label1.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.LightBlue;
            this.lblQuestion.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblQuestion.Location = new System.Drawing.Point(337, 7);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(38, 56);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 69);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(375, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 56);
            this.label4.TabIndex = 8;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(402, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(211, 97);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(378, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "در عرض سه ثانیه واژه غلط را بیابید.";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(134, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(533, 239);
            this.label7.TabIndex = 11;
            // 
            // lblWord1
            // 
            this.lblWord1.AutoSize = true;
            this.lblWord1.BackColor = System.Drawing.Color.LightBlue;
            this.lblWord1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWord1.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWord1.Location = new System.Drawing.Point(511, 264);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(80, 35);
            this.lblWord1.TabIndex = 12;
            this.lblWord1.Text = "word1";
            this.lblWord1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblWord1_MouseClick);
            this.lblWord1.MouseEnter += new System.EventHandler(this.lblWord1_MouseEnter);
            this.lblWord1.MouseLeave += new System.EventHandler(this.lblWord1_MouseLeave);
            // 
            // lblWord2
            // 
            this.lblWord2.AutoSize = true;
            this.lblWord2.BackColor = System.Drawing.Color.LightBlue;
            this.lblWord2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWord2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWord2.Location = new System.Drawing.Point(225, 264);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(80, 35);
            this.lblWord2.TabIndex = 13;
            this.lblWord2.Text = "word2";
            this.lblWord2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblWord1_MouseClick);
            this.lblWord2.MouseEnter += new System.EventHandler(this.lblWord1_MouseEnter);
            this.lblWord2.MouseLeave += new System.EventHandler(this.lblWord1_MouseLeave);
            // 
            // lblWord4
            // 
            this.lblWord4.AutoSize = true;
            this.lblWord4.BackColor = System.Drawing.Color.LightBlue;
            this.lblWord4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWord4.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWord4.Location = new System.Drawing.Point(225, 357);
            this.lblWord4.Name = "lblWord4";
            this.lblWord4.Size = new System.Drawing.Size(80, 35);
            this.lblWord4.TabIndex = 14;
            this.lblWord4.Text = "word4";
            this.lblWord4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblWord1_MouseClick);
            this.lblWord4.MouseEnter += new System.EventHandler(this.lblWord1_MouseEnter);
            this.lblWord4.MouseLeave += new System.EventHandler(this.lblWord1_MouseLeave);
            // 
            // lblWord3
            // 
            this.lblWord3.AutoSize = true;
            this.lblWord3.BackColor = System.Drawing.Color.LightBlue;
            this.lblWord3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWord3.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWord3.Location = new System.Drawing.Point(511, 357);
            this.lblWord3.Name = "lblWord3";
            this.lblWord3.Size = new System.Drawing.Size(80, 35);
            this.lblWord3.TabIndex = 15;
            this.lblWord3.Text = "word3";
            this.lblWord3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblWord1_MouseClick);
            this.lblWord3.MouseEnter += new System.EventHandler(this.lblWord1_MouseEnter);
            this.lblWord3.MouseLeave += new System.EventHandler(this.lblWord1_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Test_Incorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblWord3);
            this.Controls.Add(this.lblWord4);
            this.Controls.Add(this.lblWord2);
            this.Controls.Add(this.lblWord1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test_Incorrect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test_Incorrect";
            this.Load += new System.EventHandler(this.Test_Incorrect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWord1;
        private System.Windows.Forms.Label lblWord2;
        private System.Windows.Forms.Label lblWord4;
        private System.Windows.Forms.Label lblWord3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
    }
}