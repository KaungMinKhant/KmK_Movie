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
    public partial class ChooseSeats : Form
    {
        private int calculate_amount = 0;
        private string calculate_seat = "";
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string user_name;
        private string movie_name;
        private string start_time;
        private string auditorium_name;
        private string seats;
        private string amount;
        public ChooseSeats(string a, string b, string c, string d)
        {
            user_name = a;
            movie_name = b;
            start_time = c;
            auditorium_name = d;
            server = "localhost";
            database = "kmk_movie";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password}";

            conn = new MySqlConnection(connString);

            InitializeComponent();
        }
        String data;


        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button4.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button5.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button7.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button8.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button9.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button10.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button11.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button12.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button13.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 3000;
            calculate_seat = calculate_seat + $" {button14.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 4000;
            calculate_seat = calculate_seat + $" {button15.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 4000;
            calculate_seat = calculate_seat + $" {button16.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 4000;
            calculate_seat = calculate_seat + $" {button17.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 4000;
            calculate_seat = calculate_seat + $" {button18.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 4000;
            calculate_seat = calculate_seat + $" {button19.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 5000;
            calculate_seat = calculate_seat + $" {button20.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 5000;
            calculate_seat = calculate_seat + $" {button21.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 5000;
            calculate_seat = calculate_seat + $" {button22.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 5000;
            calculate_seat = calculate_seat + $" {button23.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.FromName("ControlDarkDark");
            calculate_amount = calculate_amount + 5000;
            calculate_seat = calculate_seat + $" {button24.Text}";
            textBox1.Text = calculate_seat;
            textBox2.Text = calculate_amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seats = textBox1.Text;
            amount = textBox2.Text;
            if (Insert_Movie(movie_name, start_time, auditorium_name, seats, amount, user_name))
            {
                String query1 = $"SELECT * FROM movies WHERE name = '{movie_name}'";
                MySqlCommand mySqlCommand = new MySqlCommand(query1, conn);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    try
                    {
                        data = reader.GetString("amount");                       
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                reader.Close();
                int amount_value = Convert.ToInt32(data);
                int current_amount = Convert.ToInt32(amount);
                amount_value = amount_value + current_amount;
                //UPDATE `movies` SET `amount` = '48000' WHERE `movies`.`id` = 3;
                String query2 = $"UPDATE movies SET amount = '{amount_value}' WHERE name = '{movie_name}'";
                MySqlCommand mySqlCommand1 = new MySqlCommand(query2, conn);
                try
                {
                    mySqlCommand1.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                conn.Close();
                MessageBox.Show($"Reservation okay");                
                textBox1.Clear();
                textBox2.Clear();
                Receipt receipt = new Receipt(user_name, movie_name, auditorium_name, start_time, seats, amount);
                receipt.ShowDialog();
                this.Close();
            }
        }

        public bool Insert_Movie(string a, string b, string c, string d, string e, string f)
        {
           
            string query = $"INSERT INTO reservation_logs(id, movie_name, start_time, auditorium_name, seats, amount, cashier_name) values('','{a}', '{b}', '{c}', '{d}', '{e}', '{f}');";
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
                        MessageBox.Show(ex.ToString());
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

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChooseMovie chooseMovie = new ChooseMovie(user_name);
            chooseMovie.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChooseAuditorium chooseAuditorium = new ChooseAuditorium(user_name, movie_name, start_time);
            chooseAuditorium.ShowDialog();
            this.Close();
        }
    }
}
