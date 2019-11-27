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
    public partial class Main : Form
    {

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        String idCell;
        public Main()
        {
            InitializeComponent();
        }

         private void  Button1_Click(object sender, EventArgs e)
        {
            Houselist listForm = new Houselist(gridViewMember.SelectedRows[0].Cells["id"].Value.ToString(), gridViewMember.SelectedRows[0].Cells["name"].Value.ToString());
            this.Hide();
            listForm.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Signup signForm = new Signup();
            this.Hide();
            signForm.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
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

            setgridViewMember();
        }

        private void setgridViewMember()
        {
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM members", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Member");
            gridViewMember.DataSource = dataSet.Tables[0];
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter($"SELECT * FROM members WHERE name LIKE '%{textName.Text}%' AND email LIKE '%{textEmail.Text}%' AND gender = '{genderCheck()}' AND auth = '{authCheck()}'", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Member");
            gridViewMember.DataSource = dataSet.Tables[0];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM members WHERE (id = '{gridViewMember.SelectedRows[0].Cells["id"].Value.ToString()}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공");
                    setgridViewMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private String authCheck()
        {
            if (radioAuth.Checked)
                return "0";
            else if (radioUser.Checked)
                return "1";
            else
                return "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selected = gridViewMember.SelectedRows[0].Cells;
            String sql = $"UPDATE members SET  `pw` = '{selected["pw"].Value.ToString()}', `email` = '{selected["email"].Value.ToString()}', `name` = '{selected["name"].Value.ToString()}', `age` = '{selected["age"].Value.ToString()}', `phone_number` = '{selected["phone_number"].Value.ToString()}', `auth` = '{selected["auth"].Value.ToString()}'WHERE(`id` = '{this.idCell}')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("수정 성공!");
                    setgridViewMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewMember.SelectedCells[0].ColumnIndex == 0)
                this.idCell = gridViewMember.SelectedCells[0].Value.ToString();
        }
    }
}
