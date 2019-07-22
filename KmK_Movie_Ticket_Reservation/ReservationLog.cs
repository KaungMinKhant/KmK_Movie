using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace KmK_Movie_Ticket_Reservation
{
    public partial class ReservationLog : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public ReservationLog()
        {
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);



            InitializeComponent();
            if (OpenConnection())
            {
                Show_Table();
                Show_Chart();
            }
        }
        DataTable dbdataset;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Show_Table()
        {
            String query = "SELECT * FROM reservation_logs";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bs = new BindingSource();
                bs.DataSource = dbdataset;
                dataGridView1.DataSource = bs;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Show_Chart()
        {
            String query = "SELECT * FROM movies";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader mySqlDataReader;
            try
            {
                mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    this.chart1.Series["Movies"].Points.AddXY(mySqlDataReader.GetString("name"), mySqlDataReader.GetString("amount"));
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("server username or password incorrect");
                        break;
                }
                return false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dbdataset);
            dataView.RowFilter = string.Format("movie_name LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dataView;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dbdataset);
            dataView.RowFilter = string.Format("auditorium_name LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dataView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dbdataset);
            dataView.RowFilter = string.Format("cashier_name LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dataView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Show_Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dbdataset);
            dataView.RowFilter = string.Format("start_time LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dataView;
        }
    }
}
