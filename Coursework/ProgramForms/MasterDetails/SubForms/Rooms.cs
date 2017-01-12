using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace DB_CourseWork.ProgramForms.SubForms
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        private void FillButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            SqlCommand cmdDataBase = new SqlCommand(" select * from Table_Rooms", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Rooms (RoomNumber, RoomType, RoomPrice, Vacancy) values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been added successfully!", "Message");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_Rooms set RoomType= '" + textBox2.Text + "', RoomPrice= '" + textBox3.Text + "', Vacancy = '" + textBox4.Text + "' where (RoomNumber = '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been updated successfully!", "Message");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Table_Rooms  where (RoomNumber = '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been deleted successfully!", "Message");
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = "Convert(RoomNumber, 'System.String') LIKE '" + textBox5.Text + "%'";
            dataGridView1.DataSource = DV;
        }
    }
}
