﻿using System;
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

namespace DB_CourseWork.ProgramForms.SubForms
{
    
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Customers (CustomerID, FirstName, LastName, RoomNumber) values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been added successfully!", "Message");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_Customers set FirstName= '" + textBox2.Text + "', LastName= '" + textBox3.Text + "', RoomNumber = '" + textBox4.Text + "' where (CustomerID = '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been updated successfully!", "Message");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Table_Customers  where (CustomerID = '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The data has been deleted successfully!", "Message");
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.SQL_CON_STR);
            SqlCommand cmdDataBase = new SqlCommand(" select * from Table_Customers", con);

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("FirstName LIKE '%{0}%'", textBox5.Text);
            dataGridView1.DataSource = DV;
        }
    }
}
