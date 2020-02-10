namespace Tondkhani
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picmini = new System.Windows.Forms.PictureBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.lblwarning = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblusername.Location = new System.Drawing.Point(400, 151);
            this.lblusername.Name = "lblusername";
            this.lblusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblusername.Size = new System.Drawing.Size(0, 16);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "نام کاربری:";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Orange;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(131, 152);
            this.txtusername.MaxLength = 12;
            this.txtusername.Name = "txtusername";
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtusername.Size = new System.Drawing.Size(268, 26);
            this.txtusername.TabIndex = 2;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Transparent;
            this.picclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picclose.Image = global::Tondkhani.Properties.Resources.buttonclose;
            this.picclose.Location = new System.Drawing.Point(388, 48);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(55, 56);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picclose.TabIndex = 4;
            this.picclose.TabStop = false;
            this.toolTip1.SetToolTip(this.picclose, "خروج");
            this.picclose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picclose_MouseClick);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picmini
            // 
            this.picmini.BackColor = System.Drawing.Color.Transparent;
            this.picmini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmini.Image = global::Tondkhani.Properties.Resources.buttonminimize;
            this.picmini.Location = new System.Drawing.Point(151, 48);
            this.picmini.Name = "picmini";
            this.picmini.Size = new System.Drawing.Size(55, 56);
            this.picmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmini.TabIndex = 5;
            this.picmini.TabStop = false;
            this.toolTip1.SetToolTip(this.picmini, "کوچک نمایی");
            this.picmini.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.picmini.MouseEnter += new System.EventHandler(this.picmini_MouseEnter);
            this.picmini.MouseLeave += new System.EventHandler(this.picmini_MouseLeave);
            // 
            // btnenter
            // 
            this.btnenter.AutoSize = true;
            this.btnenter.BackColor = System.Drawing.Color.Orange;
            this.btnenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenter.Font = new System.Drawing.Font("B Koodak", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnenter.Image = global::Tondkhani.Properties.Resources.enter1;
            this.btnenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenter.Location = new System.Drawing.Point(248, 191);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(93, 44);
            this.btnenter.TabIndex = 8;
            this.btnenter.Text = "ورود";
            this.btnenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnenter, "ایجاد حساب");
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            this.btnenter.MouseHover += new System.EventHandler(this.btnenter_MouseHover);
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.BackColor = System.Drawing.Color.Transparent;
            this.lblwarning.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblwarning.ForeColor = System.Drawing.Color.Red;
            this.lblwarning.Location = new System.Drawing.Point(164, 265);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblwarning.Size = new System.Drawing.Size(0, 16);
            this.lblwarning.TabIndex = 6;
            this.lblwarning.Text = "لطفا فقط از کاراکتر های فارسی استفاده نمایید.";
            this.lblwarning.Visible = false;
            // 
            // piclogo
            // 
            this.piclogo.BackColor = System.Drawing.Color.Transparent;
            this.piclogo.Image = global::Tondkhani.Properties.Resources.Shamim;
            this.piclogo.Location = new System.Drawing.Point(196, 15);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(201, 107);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 7;
            this.piclogo.TabStop = false;
            this.piclogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.piclogo_MouseDown);
            this.piclogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.piclogo_MouseMove);
            this.piclogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.piclogo_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "شمیم";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Shamim";
            this.notifyIcon1.Visible = true;
            // 
            // login
            // 
            this.AcceptButton = this.btnenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Tondkhani.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(588, 363);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.lblwarning);
            this.Controls.Add(this.picmini);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.piclogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picmini;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnenter;
    }
}

