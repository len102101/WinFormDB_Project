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
    public partial class Applylist : Form
    {
        private int houseId;
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        public Applylist(int houseId)
        {
            this.houseId = houseId;
            InitializeComponent();
        }

        private void Applylist_Load(object sender, EventArgs e)
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

            setGridView();

            String sql = $"SELECT * FROM houses WHERE id = '{this.houseId}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    labelUserName.Text = reader.GetString("name") + " 하우스 신청목록";
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM applies WHERE user_name LIKE '%{textName.Text}%' AND email LIKE '%{textEmail.Text}%' AND gender = '{genderCheck()}' AND houseId = '{this.houseId}'", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Member");
            gridViewApply.DataSource = dataSet.Tables[0];
        }
        private String genderCheck()
        {
            if (radioWoman.Checked)
                return "0";
            else if (radioMen.Checked)
                return "1";
            else
                return "";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try { 
                string sql = $"DELETE FROM applies WHERE (id = '{gridViewApply.SelectedRows[0].Cells["id"].Value.ToString()}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공");
                    setGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void setGridView()
        {
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM applies WHERE houseId = '{this.houseId}'", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "apply");
            gridViewApply.DataSource = dataSet.Tables[0];
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selected = gridViewApply.SelectedRows[0].Cells;
            String sql = "INSERT INTO`applies` (`id`, `user_name`, `houseId`, `email`, `userId`, `message`, `user_age`, `gender`, `join_date`) " +
                $"VALUES('{selected["id"].Value.ToString()}', '{selected["user_name"].Value.ToString()}', '{this.houseId}', '{selected["email"].Value.ToString()}', '{selected["userId"].Value.ToString()}', '{selected["message"].Value.ToString()}', '{selected["user_age"].Value.ToString()}', '{selected["gender"].Value.ToString()}', '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("등록 성공!");
                    setGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selected = gridViewApply.SelectedRows[0].Cells;
            String sql = $"UPDATE `applies` SET `user_name` = '{selected["userId"].Value.ToString()}',  `email` = '{selected["email"].Value.ToString()}', `userId` = '{selected["userId"].Value.ToString()}', `message` = '{selected["message"].Value.ToString()}', `user_age` = '{selected["user_age"].Value.ToString()}', `gender` = '{selected["gender"].Value.ToString()}' WHERE(`id` = '{selected["id"].Value.ToString()}')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("수정 성공!");
                    setGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
