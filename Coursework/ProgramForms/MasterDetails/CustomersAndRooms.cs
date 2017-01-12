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
using Excel = Microsoft.Office.Interop.Excel;

namespace DB_CourseWork.ProgramForms.MasterDetails
{
    public partial class CustomersAndRooms : Form
    {
        public CustomersAndRooms()
        {
            InitializeComponent();
        }

        private void MasterDetail1_Load(object sender, EventArgs e)
        {
            DataTable dbdataset = new DataTable();
            BindingSource bSource = new BindingSource();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Table_Customers", new SqlConnection(Constants.SQL_CON_STR));
            sda.Fill(dbdataset);
            bSource.DataSource = dbdataset;
            dataGridView1.DataSource = bSource;
            sda.Update(dbdataset);

            DataTable dbdataset2 = new DataTable();
            BindingSource bSource2 = new BindingSource();
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT RoomNumber FROM Table_Rooms", new SqlConnection(Constants.SQL_CON_STR));
            sda2.Fill(dbdataset2);
            bSource2.DataSource = dbdataset2;
            this.comboBox1.DataSource = bSource2;
            sda2.Update(dbdataset2);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dbdataset = new DataTable();
                BindingSource bSource = new BindingSource();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Table_Customers WHERE RoomNumber LIKE " + comboBox1.SelectedValue, new SqlConnection(Constants.SQL_CON_STR));
                sda.Fill(dbdataset);
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
