using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CourseWork
{
    public static class Constants
    {
        public static string SQL_CON_STR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " +
                                           Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 10) + 
                                           "\\DatabaseFiles\\Brokers.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
