using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DB_CourseWork.ProgramForms.SubForms;
using DB_CourseWork.ProgramForms.MasterDetails;

namespace DB_CourseWork.ProgramForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustomersTable_Click(object sender, EventArgs e)
        {
            Customers custs = new Customers();
            custs.ShowDialog();
        }

        private void RoomsTable_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.ShowDialog();
        }

        private void PaymentsTable_Click(object sender, EventArgs e)
        {
            Payments pay = new Payments();
            pay.ShowDialog();
        }

        private void BookingsTable_Click(object sender, EventArgs e)
        {
            Bookings bookings = new Bookings();
            bookings.ShowDialog();
        }

        private void MasterDetailOne_Click(object sender, EventArgs e)
        {
            CustomersAndRooms md1 = new CustomersAndRooms();
            md1.ShowDialog();
        }

        private void bookingsAndCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingsAndCustomers md2 = new BookingsAndCustomers();
            md2.ShowDialog();
        }

        private void paymentsAndBookings_Click(object sender, EventArgs e)
        {
            BookingsAndPayments bae = new BookingsAndPayments();
            bae.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    CustomersTable_Click(sender, e);
                    break;
                case 1:
                    BookingsTable_Click(sender, e);
                    break;
                case 2:
                    PaymentsTable_Click(sender, e);
                    break;
                case 3:
                    RoomsTable_Click(sender, e);
                    break;
                default: throw new Exception("Error! Restart Application");

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    MasterDetailOne_Click(sender, e);
                    break;
                case 1:
                    bookingsAndCustomersToolStripMenuItem_Click(sender, e);
                    break;
                case 2:
                    paymentsAndBookings_Click(sender, e);
                    break;
                default: throw new Exception("Error! Restart Application!");
            }
        }
    }
}
