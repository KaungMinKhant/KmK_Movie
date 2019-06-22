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
    public partial class MovieAdmin : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string name;

        public MovieAdmin()
        {
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);

           

            InitializeComponent();
            Show_Table();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if(Insert_Movie(name)){
                MessageBox.Show($"Movie {name} is inserted.");
                Show_Table();
                textBox1.Clear();
            }
        }

        public bool Insert_Movie(string a)
        {
            string query = $"INSERT INTO movies(id, name) values('','{a}');";
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

        public void Delete_Movie()
        {
            string itemToDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string deletedMovie = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string query = $"DELETE FROM movies WHERE id = {itemToDelete};";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Movie {deletedMovie} has been deleted.");
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
        public void Show_Table()
        {
            String query = "SELECT * FROM movies";
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
            Delete_Movie();
        }
    }
}
