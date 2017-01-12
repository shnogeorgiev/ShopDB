using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Program_Files
{
    public static class Constants
    {
        public static ShopApp.ShopDBDataSet DATASET = new ShopDBDataSet();
        public static string DBConString
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " +
                                           Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 10) + 
                                           "\\Database\\ShopDB.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
        public static void GridFill(DataGridView dataGridView)
        {
            DataTable dbdataset = new DataTable();
            BindingSource bSource = new BindingSource();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Items", new SqlConnection(Constants.DBConString));
            sda.Fill(dbdataset);
            bSource.DataSource = dbdataset;
            dataGridView.DataSource = bSource;
            sda.Update(dbdataset);
        }
        public static int CurrentSessionRecordsCountDifference
        {
            get; set;
        }
    }
}
