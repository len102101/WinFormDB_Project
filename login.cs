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
    public partial class Login : Form
    {
        MySqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

            if (textID.Text == "")
                MessageBox.Show("아이디를 입력하세요");
            else if (textPW.Text == "")
                MessageBox.Show("비밀번호를 입력하세요");

            else
            {
                string sql = $"select * from members WHERE id ='{textID.Text}' AND pw ='{textPW.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show(reader.GetString("name")+"님 환영합니다.", "로그인 성공");
                        Houselist houseListForm = new Houselist(reader.GetString("id"), reader.GetString("name"));
                        this.Hide();
                        houseListForm.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("가입되지 않은 회원입니다.", "로그인 실패");

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
