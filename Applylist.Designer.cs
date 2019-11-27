namespace WinFormDB_Project
{
    partial class Applylist
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.gridViewApply = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioMen = new System.Windows.Forms.RadioButton();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApply)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("굴림", 18F);
            this.labelUserName.Location = new System.Drawing.Point(12, 30);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(344, 27);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "name 하우스 신청자목록";
            // 
            // gridViewApply
            // 
            this.gridViewApply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewApply.Location = new System.Drawing.Point(16, 244);
            this.gridViewApply.Name = "gridViewApply";
            this.gridViewApply.RowTemplate.Height = 23;
            this.gridViewApply.Size = new System.Drawing.Size(465, 136);
            this.gridViewApply.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioMen);
            this.panel2.Controls.Add(this.radioWoman);
            this.panel2.Location = new System.Drawing.Point(332, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 37);
            this.panel2.TabIndex = 42;
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
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 18F);
            this.label7.Location = new System.Drawing.Point(239, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Gender";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("굴림", 10F);
            this.textName.Location = new System.Drawing.Point(74, 97);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(138, 23);
            this.textName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "이름";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("굴림", 10F);
            this.textEmail.Location = new System.Drawing.Point(74, 142);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(138, 23);
            this.textEmail.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "Email";
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(393, 146);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(75, 23);
            this.buttonSerch.TabIndex = 45;
            this.buttonSerch.Text = "검색";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.ButtonSerch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(393, 386);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 26);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(299, 386);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(88, 26);
            this.buttonInsert.TabIndex = 47;
            this.buttonInsert.Text = "추가";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(205, 386);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(88, 26);
            this.buttonUpdate.TabIndex = 48;
            this.buttonUpdate.Text = "수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // Applylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewApply);
            this.Controls.Add(this.labelUserName);
            this.Name = "Applylist";
            this.Text = "Apply List";
            this.Load += new System.EventHandler(this.Applylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApply)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DataGridView gridViewApply;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioMen;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
    }
}