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

    public partial class Houseinformation : Form
    {
        MySqlConnection conn;
        private int houseId;
        public Houseinformation(int houseId)
        {
            InitializeComponent();
            this.houseId = houseId;
        }

        private void Houseinformation_Load(object sender, EventArgs e)
        {
            setCombo();
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

            string sql = $"SELECT * FROM houses WHERE id='{this.houseId}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    textName.Text = reader.GetString("name");
                    textAddress.Text = reader.GetString("address");
                    textGenderLimit.Text = reader.GetString("genderLimit");
                    comboAgeLimit.Text = reader.GetString("ageLimit");
                    comboMaxMember.Text = reader.GetString("maxMember");
                    textContractperiod.Text = reader.GetString("contractperiod");
                    textInformation.Text = reader.GetString("information");
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
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
                string sql = $"UPDATE houses SET `name` = '{textName.Text}', `address` = '{textAddress.Text}', `genderLimit` = '{textGenderLimit.Text}', `ageLimit` = '{comboAgeLimit.Text}', `maxMember` = '{comboMaxMember.Text}', `contractperiod` = '{textContractperiod.Text}', `information` = '{textInformation.Text}' WHERE(`id` = '{this.houseId}')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("수정 성공!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void setCombo()
        {
            for (int i = 1; i < 100; i++)
            {
                comboAgeLimit.Items.Add(i);
                comboMaxMember.Items.Add(i);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM houses WHERE id='{this.houseId}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            Applylist applyForm = new Applylist(this.houseId);
            applyForm.ShowDialog();
        }
    }
}
