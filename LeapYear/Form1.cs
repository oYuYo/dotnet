/// Test
/// This is a joke program
/// Judging a leap year using Try Catch.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDay.Text = monthCalendar.SelectionStart.ToShortDateString();
        }

        private void selectedDay_TextChanged(object sender, EventArgs e)
        {
            DateTime tDate = DateTime.Parse(selectedDay.Text);
            try {
                tDate = new DateTime(tDate.Year, 2, 29);
                MessageBox.Show("Leap Year");
            }
            catch
            {
                MessageBox.Show("Not Leap Year");
            }
        }
    }
}
