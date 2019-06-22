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
    public partial class ScreeningsAdmin : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string movie_name;
        private string auditorium_name;
        private string start_time;
        
        public ScreeningsAdmin()
        {
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);

            InitializeComponent();
           
           
            Fill_Combo("movies", "name", comboBox1);
            Fill_Combo("auditoriums", "name", comboBox2);
            Show_Table();
        }

        public void Delete_Screening()
        {
            string itemToDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string deletedMovie = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string query = $"DELETE FROM screenings WHERE id = {itemToDelete};";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{deletedMovie} has been deleted.");
                        Show_Table();

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                conn.Close();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            MessageBox.Show(time.ToString());
        }

        public void Fill_Combo(string table_name, string data_name, ComboBox comboBox)
        {
            string query = $"SELECT * FROM {table_name}";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        String data = reader.GetString(data_name);
                        comboBox.Items.Add(data);
                    }
                    conn.Close();
                    reader.Close();
                }
                else
                {
                    conn.Close();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{table_name} had this error{ex.ToString()}");
                conn.Close();               
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

        public bool Insert_Screening(string a, string b, string c)
        {
            string query = $"INSERT INTO screenings(id, movie_name, auditorium_name, start_time) values('','{a}', '{b}', '{c}');";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            movie_name = comboBox1.SelectedItem.ToString();
            auditorium_name = comboBox2.SelectedItem.ToString();
            start_time = dateTimePicker1.Value.ToString();
            if (Insert_Screening(movie_name, auditorium_name, start_time))
            {
                MessageBox.Show($"{movie_name} is inserted into {auditorium_name} with time {start_time}.");
                Show_Table();
            }
        }
        public void Show_Table()
        {
            String query = "SELECT * FROM screenings";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Screening();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
