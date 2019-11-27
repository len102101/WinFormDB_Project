using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB_Project
{
    public partial class Houselist : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        private string userId;
        private string userName;

        public Houselist(string userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
            InitializeComponent();
        }

        private void Houselist_Load(object sender, EventArgs e)
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
            labelUserName.Text = userName + " 하우스 주인님!";

            setgridViewHouse();
        }

        private void setgridViewHouse()
        {
            dataAdapter = new MySqlDataAdapter($"SELECT id, name, address, information FROM houses WHERE userId = '{this.userId}'", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Houses");
            gridViewHouse.DataSource = dataSet.Tables[0];
            this.gridViewHouse.Columns[0].Visible = false;
        }

        private void ButtonInfor_Click(object sender, EventArgs e)
        {
            try
            {
                Houseinformation houseInforForm = new Houseinformation(Convert.ToInt32(gridViewHouse.SelectedRows[0].Cells["id"].Value));
                houseInforForm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("하우스를 선택해 주세요");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Houseregister registerForm = new Houseregister(this.userId);
            registerForm.ShowDialog();
        }

        private void ButtonReSet_Click(object sender, EventArgs e)
        {
            setgridViewHouse();
        }

        private void ButtonSerch_Click(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter($"SELECT id, name, address, information FROM houses WHERE name LIKE '%{textName.Text}%' and address LIKE '%{textAddress.Text}%' and userId = '{this.userId}'", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Houses");
            gridViewHouse.DataSource = dataSet.Tables[0];
            this.gridViewHouse.Columns[0].Visible = false;
        }
    }
}
