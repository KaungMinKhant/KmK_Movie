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
    public partial class Receipt : Form
    {
        public Receipt(string a, string b, string c, string d, string e, string f)
        {
            InitializeComponent();
            label8.Text = a;
            label9.Text = b;
            label10.Text = c;
            label11.Text = d;
            label12.Text = e;
            label13.Text = f;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseMovie chooseMovie = new ChooseMovie(label8.Text);
            chooseMovie.ShowDialog();
            this.Close();
        }
    }
}
