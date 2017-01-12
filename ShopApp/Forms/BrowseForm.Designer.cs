namespace ShopApp.Forms
{
    partial class BrowseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CategorySortComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shopDBDataSet = new ShopApp.ShopDBDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new ShopApp.ShopDBDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new ShopApp.ShopDBDataSetTableAdapters.TableAdapterManager();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search Items by Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 364);
            this.dataGridView1.TabIndex = 7;
            // 
            // CategorySortComboBox
            // 
            this.CategorySortComboBox.FormattingEnabled = true;
            this.CategorySortComboBox.Items.AddRange(new object[] {
            "Drinks",
            "Foods",
            "Others",
            "Clothes"});
            this.CategorySortComboBox.Location = new System.Drawing.Point(12, 35);
            this.CategorySortComboBox.Name = "CategorySortComboBox";
            this.CategorySortComboBox.Size = new System.Drawing.Size(202, 21);
            this.CategorySortComboBox.TabIndex = 6;
            this.CategorySortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByCategory);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Items by Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(248, 36);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 12;
            this.IdTextBox.TextChanged += new System.EventHandler(this.SortByID);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(367, 36);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 14;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.SortByPrice);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search Items by Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowAllButton);
            // 
            // shopDBDataSet
            // 
            this.shopDBDataSet.DataSetName = "ShopDBDataSet";
            this.shopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.shopDBDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopApp.ShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CategorySortComboBox);
            this.Name = "BrowseForm";
            this.Text = "BrowseForm";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CategorySortComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private ShopDBDataSet shopDBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ShopDBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private ShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}