namespace ShopApp.Forms
{
    partial class TransactionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.p_AddIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p_AddQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p_AddNameTextBox = new System.Windows.Forms.TextBox();
            this.shopDBDataSet = new ShopApp.ShopDBDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new ShopApp.ShopDBDataSetTableAdapters.PaymentsTableAdapter();
            this.tableAdapterManager = new ShopApp.ShopDBDataSetTableAdapters.TableAdapterManager();
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_AddIdTextBox
            // 
            this.p_AddIdTextBox.Location = new System.Drawing.Point(146, 24);
            this.p_AddIdTextBox.Name = "p_AddIdTextBox";
            this.p_AddIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_AddIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // p_AddQuantityTextBox
            // 
            this.p_AddQuantityTextBox.Location = new System.Drawing.Point(252, 24);
            this.p_AddQuantityTextBox.Name = "p_AddQuantityTextBox";
            this.p_AddQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_AddQuantityTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // p_AddNameTextBox
            // 
            this.p_AddNameTextBox.Location = new System.Drawing.Point(358, 24);
            this.p_AddNameTextBox.Name = "p_AddNameTextBox";
            this.p_AddNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_AddNameTextBox.TabIndex = 10;
            // 
            // shopDBDataSet
            // 
            this.shopDBDataSet.DataSetName = "ShopDBDataSet";
            this.shopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.shopDBDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ShopApp.ShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AutoGenerateColumns = false;
            this.paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.paymentsDataGridView.DataSource = this.paymentsBindingSource;
            this.paymentsDataGridView.Location = new System.Drawing.Point(12, 50);
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.Size = new System.Drawing.Size(645, 356);
            this.paymentsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn6.HeaderText = "Category";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.paymentsDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_AddNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_AddQuantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_AddIdTextBox);
            this.Controls.Add(this.button1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox p_AddIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_AddQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p_AddNameTextBox;
        private ShopDBDataSet shopDBDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private ShopDBDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private ShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}