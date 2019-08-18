using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        private string deskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // counter for number of snaps
        private int snapCount = 0;

        private void SaveControlImage(Control theControl)
        {
            snapCount++;

            Bitmap controlBitMap = new Bitmap(theControl.Width, theControl.Height);
            Graphics g = Graphics.FromImage(controlBitMap);
            g.CopyFromScreen(PointToScreen(theControl.Location), new Point(0, 0), theControl.Size);

            // example of saving to the desktop
            controlBitMap.Save(deskTopPath + @"/snap_" + snapCount.ToString() + @".png", ImageFormat.Png);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveControlImage(panel1);
        }
    }
}
