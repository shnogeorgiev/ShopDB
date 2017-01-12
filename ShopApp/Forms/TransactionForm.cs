using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Forms
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDBDataSet);

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            this.paymentsTableAdapter.Fill(this.shopDBDataSet.Payments);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
