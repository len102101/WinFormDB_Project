using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB_Project
{
    public partial class Signup : Form
    {
        MySqlConnection conn;
        int checkID = 0;
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;username=root;database='life-share-db';password=dotori1021";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setAgeCombo();
        }

        private void setAgeCombo()
        {
            for (int i = 1; i < 100; i++)
                comboAge.Items.Add(i);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int gender = genderCheck();
            int auth = authCheck();
            
            if (textID.Text == "")
                MessageBox.Show("아이디를 입력하세요");
            else if (textPW.Text == "")
                MessageBox.Show("비밀번호를 입력하세요");
            else if (textEmail.Text == "")
                MessageBox.Show("이메일을 입력하세요");
            else if (textName.Text == "")
                MessageBox.Show("이름을 입력하세요");
            else if (comboAge.Text == "")
                MessageBox.Show("나이를 입력하세요");
            else if (textPhone.Text == "")
                MessageBox.Show("전화번호를 입력하세요");
            else if (gender == 2)
                MessageBox.Show("성별을 입력하세요");
            else if (auth == 2)
                MessageBox.Show("유저 구분을 입력하세요");
            else if (checkID == 0)
                MessageBox.Show("아이디 중복을 확인하세요");

            else
            {
                
                string sql = $"INSERT INTO members (`id`, `pw`, `email`, `name`, `age`, `phone_number`, `auth`, `gender`, `join_date`) VALUES('{textID.Text}', '{textPW.Text}', '{textEmail.Text}', '{textName.Text}', '{comboAge.Text}', '{textPhone.Text}', {auth}, '{gender}', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("회원가입 성공!");
                        Main mainForm = new Main();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private int genderCheck()
        {
            if (radioWoman.Checked)
                return 0;
            else if (radioMen.Checked)
                return 1;
            else
                return 2;
        }

        private int authCheck()
        {
            if (radioAuth.Checked)
                return 0;
            else if (radioUser.Checked)
                return 1;
            else
                return 2;
        }
        private void Overlap_Click(object sender, EventArgs e)
        {
            if (textID.Text == "")
                MessageBox.Show("아이디를 입력하세요");
            else
            {
                string sql = $"select * from members WHERE id ='{textID.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("이미 가입된 회원입니다.");
                    }
                    else
                    {
                        checkID = 1;

                        MessageBox.Show("사용가능한 아이디입니다.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TextID_TextChanged(object sender, EventArgs e)
        {
            checkID = 0;
        }
    }
}
