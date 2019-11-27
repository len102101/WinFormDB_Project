namespace WinFormDB_Project
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewMember = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioMen = new System.Windows.Forms.RadioButton();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioAuth = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("CookieRun Bold", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Life Share ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("CookieRun Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(25, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("CookieRun Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(264, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "회원가입";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(118, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copyrigth 2019. TeamLifeShare. All reserved.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewMember
            // 
            this.gridViewMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMember.Location = new System.Drawing.Point(25, 249);
            this.gridViewMember.Name = "gridViewMember";
            this.gridViewMember.RowTemplate.Height = 23;
            this.gridViewMember.Size = new System.Drawing.Size(466, 115);
            this.gridViewMember.TabIndex = 5;
            this.gridViewMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMember_CellClick);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("굴림", 10F);
            this.textName.Location = new System.Drawing.Point(77, 129);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(138, 23);
            this.textName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "이름";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("굴림", 10F);
            this.textEmail.Location = new System.Drawing.Point(77, 170);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(138, 23);
            this.textEmail.TabIndex = 19;
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(386, 210);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(75, 23);
            this.buttonSerch.TabIndex = 20;
            this.buttonSerch.Text = "검색";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.ButtonSerch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioMen);
            this.panel2.Controls.Add(this.radioWoman);
            this.panel2.Location = new System.Drawing.Point(325, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 37);
            this.panel2.TabIndex = 38;
            // 
            // radioMen
            // 
            this.radioMen.AutoSize = true;
            this.radioMen.Font = new System.Drawing.Font("굴림", 10F);
            this.radioMen.Location = new System.Drawing.Point(83, 7);
            this.radioMen.Name = "radioMen";
            this.radioMen.Size = new System.Drawing.Size(50, 21);
            this.radioMen.TabIndex = 24;
            this.radioMen.TabStop = true;
            this.radioMen.Tag = "";
            this.radioMen.Text = "남성";
            this.radioMen.UseCompatibleTextRendering = true;
            this.radioMen.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.radioUser);
            this.panel1.Controls.Add(this.radioAuth);
            this.panel1.Location = new System.Drawing.Point(325, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 35);
            this.panel1.TabIndex = 37;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("굴림", 10F);
            this.radioUser.Location = new System.Drawing.Point(83, 7);
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
            this.label8.Location = new System.Drawing.Point(247, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "auth";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 18F);
            this.label7.Location = new System.Drawing.Point(221, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Gender";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("CookieRun Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(386, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 43);
            this.button3.TabIndex = 39;
            this.button3.Text = "회원삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("CookieRun Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(145, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 43);
            this.button4.TabIndex = 40;
            this.button4.Text = "정보수정";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 535);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Life Share";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMember)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewMember;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioMen;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioAuth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

