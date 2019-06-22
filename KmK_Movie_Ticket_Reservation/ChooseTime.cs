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
    public partial class ChooseTime : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string user_name;
        private string movie_name;
        private string start_time;
        public ChooseTime(string a, string b)
        {
            user_name = a;
            movie_name = b;
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);

            InitializeComponent();
            Fill_Combo("screenings", "start_time", comboBox1);
        }
        public void Fill_Combo(string table_name, string data_name, ComboBox comboBox)
        {
            string query = $"SELECT * FROM {table_name} WHERE movie_name = '{movie_name}';";
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

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseMovie chooseMovie = new ChooseMovie(user_name);
            chooseMovie.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseMovie chooseMovie = new ChooseMovie(user_name);
            chooseMovie.ShowDialog();
            this.Close();
        }
    }
}
