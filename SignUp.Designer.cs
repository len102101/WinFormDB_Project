namespace WinFormDB_Project
{
    partial class Signup
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
            this.textPW = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textP = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAge = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.radioMen = new System.Windows.Forms.RadioButton();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.overlap = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAuth = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPW
            // 
            this.textPW.Font = new System.Drawing.Font("굴림", 10F);
            this.textPW.Location = new System.Drawing.Point(178, 264);
            this.textPW.Name = "textPW";
            this.textPW.PasswordChar = '*';
            this.textPW.Size = new System.Drawing.Size(180, 23);
            this.textPW.TabIndex = 16;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("굴림", 10F);
            this.textID.Location = new System.Drawing.Point(178, 204);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(180, 23);
            this.textID.TabIndex = 15;
            this.textID.TextChanged += new System.EventHandler(this.TextID_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textP
            // 
            this.textP.Font = new System.Drawing.Font("굴림", 18F);
            this.textP.Location = new System.Drawing.Point(103, 264);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(45, 27);
            this.textP.TabIndex = 13;
            this.textP.Text = "PW";
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("굴림", 18F);
            this.text.Location = new System.Drawing.Point(103, 207);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(33, 27);
            this.text.TabIndex = 12;
            this.text.Text = "ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 23F);
            this.label2.Location = new System.Drawing.Point(172, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("CookieRun Bold", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 81);
            this.label1.TabIndex = 10;
            this.label1.Text = "Life Share ";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("굴림", 10F);
            this.textName.Location = new System.Drawing.Point(178, 362);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(180, 23);
            this.textName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 18F);
            this.label5.Location = new System.Drawing.Point(79, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 18F);
            this.label6.Location = new System.Drawing.Point(98, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Age";
            // 
            // comboAge
            // 
            this.comboAge.Font = new System.Drawing.Font("굴림", 10F);
            this.comboAge.FormattingEnabled = true;
            this.comboAge.Location = new System.Drawing.Point(178, 414);
            this.comboAge.Name = "comboAge";
            this.comboAge.Size = new System.Drawing.Size(180, 21);
            this.comboAge.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 18F);
            this.label7.Location = new System.Drawing.Point(61, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gender";
            // 
            // radioWoman
            // 
            this.radioWoman.AutoSize = true;
            this.radioWoman.Font = new System.Drawing.Font("굴림", 10F);
            this.radioWoman.Location = new System.Drawing.Point(13, 7);
            this.radioWoman.Name = "radioWoman";
            this.radioWoman.Size = new System.Drawing.Size(53, 18);
            this.radioWoman.TabIndex = 23;
            this.radioWoman.TabStop = true;
            this.radioWoman.Text = "여성";
            this.radioWoman.UseVisualStyleBackColor = true;
            // 
            // radioMen
            // 
            this.radioMen.AutoSize = true;
            this.radioMen.Font = new System.Drawing.Font("굴림", 10F);
            this.radioMen.Location = new System.Drawing.Point(129, 7);
            this.radioMen.Name = "radioMen";
            this.radioMen.Size = new System.Drawing.Size(50, 21);
            this.radioMen.TabIndex = 24;
            this.radioMen.TabStop = true;
            this.radioMen.Tag = "";
            this.radioMen.Text = "남성";
            this.radioMen.UseCompatibleTextRendering = true;
            this.radioMen.UseVisualStyleBackColor = true;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("굴림", 10F);
            this.textPhone.Location = new System.Drawing.Point(178, 457);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(180, 23);
            this.textPhone.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 18F);
            this.label3.Location = new System.Drawing.Point(25, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "PhoneNum";
            // 
            // overlap
            // 
            this.overlap.Location = new System.Drawing.Point(381, 204);
            this.overlap.Name = "overlap";
            this.overlap.Size = new System.Drawing.Size(85, 23);
            this.overlap.TabIndex = 27;
            this.overlap.Text = "중복확인";
            this.overlap.UseVisualStyleBackColor = true;
            this.overlap.Click += new System.EventHandler(this.Overlap_Click);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("굴림", 10F);
            this.textEmail.Location = new System.Drawing.Point(178, 313);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(180, 23);
            this.textEmail.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 18F);
            this.label4.Location = new System.Drawing.Point(83, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("굴림", 10F);
            this.radioUser.Location = new System.Drawing.Point(129, 9);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(53, 18);
            this.radioUser.TabIndex = 32;
            this.radioUser.TabStop = true;
            this.radioUser.Tag = "";
            this.radioUser.Text = "손님";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioAuth
            // 
            this.radioAuth.AutoSize = true;
            this.radioAuth.Font = new System.Drawing.Font("굴림", 10F);
            this.radioAuth.Location = new System.Drawing.Point(13, 9);
            this.radioAuth.Name = "radioAuth";
            this.radioAuth.Size = new System.Drawing.Size(53, 18);
            this.radioAuth.TabIndex = 31;
            this.radioAuth.TabStop = true;
            this.radioAuth.Tag = "";
            this.radioAuth.Text = "주인";
            this.radioAuth.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 18F);
            this.label8.Location = new System.Drawing.Point(87, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "auth";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioUser);
            this.panel1.Controls.Add(this.radioAuth);
            this.panel1.Location = new System.Drawing.Point(165, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 35);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioMen);
            this.panel2.Controls.Add(this.radioWoman);
            this.panel2.Location = new System.Drawing.Point(165, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 37);
            this.panel2.TabIndex = 34;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.overlap);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Sing Up";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textP;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.RadioButton radioMen;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button overlap;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioAuth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}