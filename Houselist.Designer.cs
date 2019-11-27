namespace WinFormDB_Project
{
    partial class Houselist
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewHouse = new System.Windows.Forms.DataGridView();
            this.buttonInfor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReSet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.buttonSerch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "안녕하세요";
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("굴림", 18F);
            this.labelUserName.Location = new System.Drawing.Point(1, 31);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(261, 27);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "name 하우스 주인님!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(19, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "내가 등록한 하우스들";
            // 
            // gridViewHouse
            // 
            this.gridViewHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridViewHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHouse.Location = new System.Drawing.Point(29, 255);
            this.gridViewHouse.Name = "gridViewHouse";
            this.gridViewHouse.RowTemplate.Height = 23;
            this.gridViewHouse.Size = new System.Drawing.Size(421, 100);
            this.gridViewHouse.TabIndex = 9;
            // 
            // buttonInfor
            // 
            this.buttonInfor.Location = new System.Drawing.Point(278, 361);
            this.buttonInfor.Name = "buttonInfor";
            this.buttonInfor.Size = new System.Drawing.Size(75, 23);
            this.buttonInfor.TabIndex = 10;
            this.buttonInfor.Text = "세부정보";
            this.buttonInfor.UseVisualStyleBackColor = true;
            this.buttonInfor.Click += new System.EventHandler(this.ButtonInfor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "하우스 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonReSet
            // 
            this.buttonReSet.Location = new System.Drawing.Point(197, 361);
            this.buttonReSet.Name = "buttonReSet";
            this.buttonReSet.Size = new System.Drawing.Size(75, 23);
            this.buttonReSet.TabIndex = 12;
            this.buttonReSet.Text = "새로고침";
            this.buttonReSet.UseVisualStyleBackColor = true;
            this.buttonReSet.Click += new System.EventHandler(this.ButtonReSet_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "이름으로 검색하기";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "주소로 검색하기";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("굴림", 10F);
            this.textName.Location = new System.Drawing.Point(219, 93);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(193, 23);
            this.textName.TabIndex = 15;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("굴림", 10F);
            this.textAddress.Location = new System.Drawing.Point(219, 148);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(193, 23);
            this.textAddress.TabIndex = 16;
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(337, 187);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(75, 23);
            this.buttonSerch.TabIndex = 17;
            this.buttonSerch.Text = "검색";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.ButtonSerch_Click);
            // 
            // Houselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 431);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInfor);
            this.Controls.Add(this.gridViewHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label2);
            this.Name = "Houselist";
            this.Text = "House List";
            this.Load += new System.EventHandler(this.Houselist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInfor;
        private System.Windows.Forms.DataGridView gridViewHouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button buttonSerch;
    }
}