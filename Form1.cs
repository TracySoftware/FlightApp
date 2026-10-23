using System;
using System.Windows.Forms;
using miniClockLib;

namespace FlightApp
{
    public partial class Form1 : Form
    {
        private readonly Clock departureClock = new Clock();
        //private readonly Clock arrivalClock = new Clock();

        public Form1()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                if (!departureClock.Show("IL", panel1.Handle))
                    MessageBox.Show("Departure: " + departureClock.LastError);

                //if (!arrivalClock.Show("US-EAST", panel2.Handle));
                //    MessageBox.Show("Arrival: " + arrivalClock.LastError);
            };
            FormClosing += (s, e) =>
            {
                departureClock.Close();
           //     arrivalClock.Close();
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}