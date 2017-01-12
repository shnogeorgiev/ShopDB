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
    public partial class BookingsAndCustomers : Form
    {
        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();

        public BookingsAndCustomers()
        {
            masterDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Dock = DockStyle.Fill;

            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            this.Controls.Add(splitContainer1);
            this.Load += new System.EventHandler(Form1_Load);
            this.Size = new System.Drawing.Size(555, 444);

            InitializeComponent();
        }

        private void GetData()
        {
            try
            {
                String connectionString = Constants.SQL_CON_STR;
                SqlConnection connection = new SqlConnection(connectionString);

                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                SqlDataAdapter masterDataAdapter = new
                    SqlDataAdapter("select * from Table_Customers", connection);
                masterDataAdapter.Fill(data, "Table_Customers");

                SqlDataAdapter detailsDataAdapter = new
                    SqlDataAdapter("select * from Table_Bookings", connection);
                detailsDataAdapter.Fill(data, "Table_Bookings");

                DataRelation relation = new DataRelation("CustomersBookings",
                    data.Tables["Table_Customers"].Columns["CustomerID"],
                    data.Tables["Table_Bookings"].Columns["CustomerID"]);
                data.Relations.Add(relation);

                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Table_Customers";

                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "CustomersBookings";
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            masterDataGridView.AutoResizeColumns();

            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
