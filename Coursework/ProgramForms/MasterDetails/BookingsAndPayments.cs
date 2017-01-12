using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CourseWork.ProgramForms.MasterDetails
{
    public partial class BookingsAndPayments : Form
    {
        public BookingsAndPayments()
        {
            InitializeComponent();
            DataTable dbtable;

            SqlCommand cmd = new SqlCommand(" select * from Table_Customers", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                dbtable = new DataTable();
                sda.Fill(dbtable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbtable;
                dataGridView1.DataSource = bSource;
                sda.Update(dbtable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dbtableTwo;
            cmd = new SqlCommand(" select * from Table_Bookings", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                BindingSource bSource = new BindingSource();
                dbtableTwo = new DataTable();
                sda.SelectCommand = cmd;
                sda.Fill(dbtableTwo);
                bSource.DataSource = dbtableTwo;
                dataGridView2.DataSource = bSource;
                sda.Update(dbtableTwo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd = new SqlCommand(" select * from Table_Payments", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                BindingSource bSource = new BindingSource();
                dbtableTwo = new DataTable();
                sda.SelectCommand = cmd;
                sda.Fill(dbtableTwo);
                bSource.DataSource = dbtableTwo;
                dataGridView3.DataSource = bSource;
                sda.Update(dbtableTwo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dbtable = new DataTable();
            SqlCommand cmd = new SqlCommand(" select CustomerID from Table_Customers", new SqlConnection(Constants.SQL_CON_STR));
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            BindingSource bindingSource = new BindingSource();
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dbtable);
            bindingSource.DataSource = dbtable;
            sqlDataAdapter.Update(dbtable);

            int chosenCustomerID = 0;
            int.TryParse(textBox1.Text, out chosenCustomerID);


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand cmdDataBaseThree = new SqlCommand(" select * from Table_Customers", new SqlConnection(Constants.SQL_CON_STR));
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBaseThree;
                    dbtable = new DataTable();
                    sda.Fill(dbtable);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbtable;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbtable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dbtableTwo;
                SqlCommand cmdDataBaseFour = new SqlCommand(" select * from Table_Bookings", new SqlConnection(Constants.SQL_CON_STR));
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    BindingSource bSource = new BindingSource();
                    dbtableTwo = new DataTable();
                    sda.SelectCommand = cmdDataBaseFour;
                    sda.Fill(dbtableTwo);
                    bSource.DataSource = dbtableTwo;
                    dataGridView2.DataSource = bSource;
                    sda.Update(dbtableTwo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                SqlCommand cmdDataBaseFive = new SqlCommand(" select * from Table_Payments", new SqlConnection(Constants.SQL_CON_STR));
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    BindingSource bSource = new BindingSource();
                    dbtableTwo = new DataTable();
                    sda.SelectCommand = cmdDataBaseFive;
                    sda.Fill(dbtableTwo);
                    bSource.DataSource = dbtableTwo;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbtableTwo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (chosenCustomerID > dbtable.Rows.Count)
            {
                MessageBox.Show("Error! Chosen CustomerID " + chosenCustomerID.ToString() + " is not existent!");
            }
            else
            {
                cmd = new SqlCommand(" select * from Table_Customers where Table_Customers.CustomerID = " + chosenCustomerID, new SqlConnection(Constants.SQL_CON_STR));

                try
                {
                    dbtable = new DataTable();
                    BindingSource bSource = new BindingSource();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.SelectCommand = cmd;
                    sda.Fill(dbtable);
                    bSource.DataSource = dbtable;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbtable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmd = new SqlCommand(" select * from Table_Bookings where Table_Bookings.CustomerID = " + chosenCustomerID, new SqlConnection(Constants.SQL_CON_STR));

                try
                {
                    dbtable = new DataTable();
                    BindingSource bSource = new BindingSource();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.SelectCommand = cmd;
                    sda.Fill(dbtable);

                    bSource.DataSource = dbtable;
                    dataGridView2.DataSource = bSource;
                    sda.Update(dbtable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmd = new SqlCommand(" select * from Table_Payments where Table_Payments.CustomerID = " + chosenCustomerID, new SqlConnection(Constants.SQL_CON_STR));

                try
                {
                    dbtable = new DataTable();
                    BindingSource bSource = new BindingSource();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.SelectCommand = cmd;
                    sda.Fill(dbtable);

                    bSource.DataSource = dbtable;
                    dataGridView3.DataSource = bSource;
                    sda.Update(dbtable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dbtable;
            SqlCommand cmdDataBaseThree = new SqlCommand(" select * from Table_Customers", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBaseThree;
                dbtable = new DataTable();
                sda.Fill(dbtable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbtable;
                dataGridView1.DataSource = bSource;
                sda.Update(dbtable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dbtableTwo;
            SqlCommand cmdDataBaseFour = new SqlCommand(" select * from Table_Bookings", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                BindingSource bSource = new BindingSource();
                dbtableTwo = new DataTable();
                sda.SelectCommand = cmdDataBaseFour;
                sda.Fill(dbtableTwo);
                bSource.DataSource = dbtableTwo;
                dataGridView2.DataSource = bSource;
                sda.Update(dbtableTwo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlCommand cmdDataBaseFive = new SqlCommand(" select * from Table_Payments", new SqlConnection(Constants.SQL_CON_STR));
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                BindingSource bSource = new BindingSource();
                dbtableTwo = new DataTable();
                sda.SelectCommand = cmdDataBaseFive;
                sda.Fill(dbtableTwo);
                bSource.DataSource = dbtableTwo;
                dataGridView3.DataSource = bSource;
                sda.Update(dbtableTwo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
