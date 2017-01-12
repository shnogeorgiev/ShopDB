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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ControlFormButton(object sender, EventArgs e)
        {
            ControlForm cf = new ControlForm();
            cf.Show();
        }

        private void BrowseFormButton(object sender, EventArgs e)
        {
            BrowseForm bf = new BrowseForm();
            bf.Show();
        }

        private void TransactionFormButton(object sender, EventArgs e)
        {
            TransactionForm tf = new TransactionForm();
            tf.Show();
        }
    }
}
