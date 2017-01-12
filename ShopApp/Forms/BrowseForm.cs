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

using ShopApp.Program_Files;

namespace ShopApp.Forms
{
    public partial class BrowseForm : Form
    {
        public BrowseForm()
        {
            InitializeComponent();
        }
        private void SortByCategory(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    DataTable dbdataset = new DataTable();
                    SqlCommand cmd = new SqlCommand("select Items.Id, Items.Name, Items.Price, Items.InStock from Items where Items.Category like @category order by Items.Price",
                         sqlCon);
                    cmd.Parameters.AddWithValue("@category", this.CategorySortComboBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SortByID(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    DataTable dbdataset = new DataTable();
                    SqlCommand cmd = new SqlCommand("select Items.Id, Items.Name, Items.Price, Items.InStock from Items where Items.Id like @id",
                        sqlCon);
                    cmd.Parameters.AddWithValue("@id", this.IdTextBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SortByPrice(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    DataTable dbdataset = new DataTable();
                    SqlCommand cmd = new SqlCommand("select Items.Id, Items.Name, Items.Price, Items.InStock from Items where CHARINDEX(@price, Items.Price) > 0  order by Items.Price",
                        sqlCon);
                    cmd.Parameters.AddWithValue("@price", this.PriceTextBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ShowAllButton(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    DataTable dbdataset = new DataTable();
                    SqlCommand cmd = new SqlCommand("select * from Items order by Items.Id",
                        sqlCon);
                    cmd.Parameters.AddWithValue("@price", this.PriceTextBox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDBDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.shopDBDataSet.Items);

        }
    }
}
