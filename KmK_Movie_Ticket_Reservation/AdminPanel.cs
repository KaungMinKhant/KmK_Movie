﻿using System;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieAdmin movieAdmin = new MovieAdmin();
            movieAdmin.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuditoriumsAdmin auditoriumsAdmin = new AuditoriumsAdmin();
            auditoriumsAdmin.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeatsAdmin seatsAdmin = new SeatsAdmin();
            seatsAdmin.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScreeningsAdmin screeningsAdmin = new ScreeningsAdmin();
            screeningsAdmin.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReservationLog reservationLog = new ReservationLog();
            reservationLog.ShowDialog();
            this.Close();
        }
    }
}
