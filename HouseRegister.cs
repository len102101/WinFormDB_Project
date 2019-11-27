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
    public partial class Houseregister : Form
    {
        MySqlConnection conn;
        private string userId;
        public Houseregister(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Houseregister_Load(object sender, EventArgs e)
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
            setCombo();
        }

        private void setCombo()
        {
            for (int i = 1; i < 100; i++)
            {
                comboAgeLimit.Items.Add(i);
                comboMaxMember.Items.Add(i);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
                MessageBox.Show("이름을 입력하세요");
            else if (textAddress.Text == "")
                MessageBox.Show("주소를 입력하세요");
            else if (textGenderLimit.Text == "")
                MessageBox.Show("성별제한을 입력하세요");
            else if (comboAgeLimit.Text == "")
                MessageBox.Show("나이제한을 입력하세요");
            else if (comboMaxMember.Text == "")
                MessageBox.Show("인원제한을 입력하세요");
            else if (textContractperiod.Text == "")
                MessageBox.Show("계약기간을 입력하세요");
            else if (textInformation.Text == "")
                MessageBox.Show("세부정보를 입력하세요");
            else
            {
                string sql = "INSERT INTO `life-share-db`.`houses` (`userId`, `name`, `address`, `genderLimit`, `ageLimit`, `maxMember`, `contractperiod`, `information`, `imageData`, `join_date`) " +
                    $"VALUES ('{this.userId}', '{textName.Text}', '{textAddress.Text}', '{textGenderLimit.Text}', '{comboAgeLimit.Text}', '{comboMaxMember.Text}', '{textContractperiod.Text}', '{textInformation.Text}', 'temp.jpg', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("방등록 성공!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
