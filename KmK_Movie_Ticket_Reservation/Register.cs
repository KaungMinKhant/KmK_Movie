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
    public partial class Register : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string name, email, pass, employee_type;

        public Register()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            email = textBox2.Text;
            if (textBox3.Text == textBox4.Text)
            {
                pass = textBox3.Text;
                if (radioButton1.Checked)
                {
                    employee_type = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    employee_type = radioButton2.Text;
                }

                if (Register_user(name, email, pass, employee_type))
                {                                      
                    if (IsManager(name, pass))
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();
                        this.Close();
                    }
                    else if (IsStaff(name, pass))
                    {
                        ChooseMovie chooseMovie = new ChooseMovie(name);
                        chooseMovie.ShowDialog();
                        this.Close();
                    }                  
                }
                else
                {
                    MessageBox.Show($"{name} has not been created.");
                }
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password Doesn't Match");
            }
            

        }
       
        public bool Register_user(string a, string b, string c, string d)
        {
            string query = $"INSERT INTO users(id, name, email, password, employee_type) values('','{a}', '{b}', '{c}', '{d}');";
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
            catch(Exception ex)
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
            catch(MySqlException ex)
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

        public bool IsStaff(string a, string b)
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
                        if (type == "Staff")
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
                return false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
