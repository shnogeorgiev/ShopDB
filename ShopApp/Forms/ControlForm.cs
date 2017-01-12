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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
            Constants.GridFill(this.dataGridView1);
            Constants.CurrentSessionRecordsCountDifference = 0;
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
           
        }

        private void i_AddButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    int id; int.TryParse(this.AddID_TextBox.Text, out id);
                    double price; double.TryParse(this.AddPrice_TextBox.Text, out price);
                    string name = this.AddName_TextBox.Text;
                    int inStock; int.TryParse(this.AddInStock_TextBox.Text, out inStock);
                    string category = this.AddCategory_TextBox.Text;

                    foreach (var item in Constants.DATASET.Items)
                        if (string.IsNullOrWhiteSpace(this.AddID_TextBox.Text) ||
                            string.IsNullOrWhiteSpace(this.AddPrice_TextBox.Text) ||
                            string.IsNullOrWhiteSpace(this.AddName_TextBox.Text) ||
                            string.IsNullOrWhiteSpace(this.AddInStock_TextBox.Text) ||
                            string.IsNullOrWhiteSpace(this.AddCategory_TextBox.Text))
                            throw new ArgumentException(string.Format("Arguments cannot be empty or whitespace!"));
                        else if (item.ID == id)
                            throw new IndexOutOfRangeException(string.Format("ID {0} is already in use by - #{1} : {2}", id, item.ID, item.Name));

                    SqlCommand cmd = new SqlCommand("INSERT INTO Items (Id, Price, Name, InStock, Category) VALUES (@Id, @Price, @Name, @InStock, @Category)");

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@InStock", inStock);
                    cmd.Parameters.AddWithValue("@Category", category);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Constants.DATASET.AcceptChanges();
                    con.Close();

                    Constants.CurrentSessionRecordsCountDifference++;
                    Constants.GridFill(this.dataGridView1);
                }
            }
        }

        private void i_DeleteButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Constants.DBConString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Items WHERE Id = @Id", con);

                    int id; int.TryParse(this.RemoveID_TextBox.Text, out id);
                    if (id <= 0) throw new ArgumentOutOfRangeException(string.Format("Invalid argument {0}! ID cannot be less than or equal to 0!", id));
                    if (id > Constants.CurrentSessionRecordsCountDifference + Constants.DATASET.Items.Last().ID)
                        throw new IndexOutOfRangeException(string.Format("ID {0} does not exist!", id));

                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Constants.DATASET.AcceptChanges();
                    con.Close();

                    Constants.CurrentSessionRecordsCountDifference--;
                    Constants.GridFill(this.dataGridView1);
                }
            }
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            Constants.GridFill(this.dataGridView1);
        }
    }
}
