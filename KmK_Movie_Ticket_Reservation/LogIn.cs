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

namespace KmK_Movie_Ticket_Reservation
{
    public partial class LogIn : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string name, pass;

        

        public LogIn()
        {
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            pass = textBox3.Text;


            if (LogIn_user(name, pass))
            {
                if(IsStaff(name, pass))
                {
                    ChooseMovie chooseMovie = new ChooseMovie(name);
                    chooseMovie.ShowDialog();
                    this.Close();
                }
                else if(IsManager(name, pass))
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
                    this.Close();                   
                }
 
            }
            else
            {
                MessageBox.Show("Something wrong.");
            }
        }

        public bool LogIn_user(string a, string b)
        {
            string query = $"SELECT * FROM users WHERE name = '{a}' AND password = '{b}';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
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

        public bool IsStaff(string a, string b) {
            string query = $"SELECT * FROM users WHERE name = '{a}' AND password = '{b}';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string type = reader.GetString("employee_type");
                        if(type == "Staff")
                        {
                            reader.Close();
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
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

        public bool IsManager(string a, string b)
        {
            string query = $"SELECT * FROM users WHERE name = '{a}' AND password = '{b}';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string type = reader.GetString("employee_type");
                        if (type == "Manager")
                        {
                            reader.Close();
                            conn.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return false;
                        }
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
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

        private void label7_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
