using ShopApp.Database;
namespace ShopApp.Forms
{
    partial class ControlForm
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
            this.AddID_TextBox = new System.Windows.Forms.TextBox();
            this.AddPrice_TextBox = new System.Windows.Forms.TextBox();
            this.AddName_TextBox = new System.Windows.Forms.TextBox();
            this.AddInStock_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCategory_TextBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveID_TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // AddID_TextBox
            // 
            this.AddID_TextBox.Location = new System.Drawing.Point(565, 46);
            this.AddID_TextBox.Name = "AddID_TextBox";
            this.AddID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddID_TextBox.TabIndex = 2;
            // 
            // AddPrice_TextBox
            // 
            this.AddPrice_TextBox.Location = new System.Drawing.Point(566, 85);
            this.AddPrice_TextBox.Name = "AddPrice_TextBox";
            this.AddPrice_TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddPrice_TextBox.TabIndex = 3;
            // 
            // AddName_TextBox
            // 
            this.AddName_TextBox.Location = new System.Drawing.Point(672, 85);
            this.AddName_TextBox.Name = "AddName_TextBox";
            this.AddName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddName_TextBox.TabIndex = 4;
            // 
            // AddInStock_TextBox
            // 
            this.AddInStock_TextBox.Location = new System.Drawing.Point(566, 129);
            this.AddInStock_TextBox.Name = "AddInStock_TextBox";
            this.AddInStock_TextBox.Size = new System.Drawing.Size(100, 20);
            this.AddInStock_TextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.i_AddButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "InStock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category";
            // 
            // AddCategory_TextBox
            // 
            this.AddCategory_TextBox.FormattingEnabled = true;
            this.AddCategory_TextBox.Items.AddRange(new object[] {
            "Drinks",
            "Foods",
            "Others",
            "Clothes"});
            this.AddCategory_TextBox.Location = new System.Drawing.Point(673, 128);
            this.AddCategory_TextBox.Name = "AddCategory_TextBox";
            this.AddCategory_TextBox.Size = new System.Drawing.Size(121, 21);
            this.AddCategory_TextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // RemoveID_TextBox
            // 
            this.RemoveID_TextBox.Location = new System.Drawing.Point(565, 204);
            this.RemoveID_TextBox.Name = "RemoveID_TextBox";
            this.RemoveID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoveID_TextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.i_DeleteButtonClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 374);
            this.dataGridView1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(780, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Drinks",
            "Foods",
            "Others",
            "Clothes"});
            this.comboBox1.Location = new System.Drawing.Point(564, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "InStock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(774, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(674, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Add Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(670, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(564, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(776, 318);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(565, 279);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(565, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "---Update-----------------------------------------------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(565, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(339, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "---Delete-------------------------------------------------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.Location = new System.Drawing.Point(565, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(335, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "---Create------------------------------------------------------";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 398);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemoveID_TextBox);
            this.Controls.Add(this.AddCategory_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddInStock_TextBox);
            this.Controls.Add(this.AddName_TextBox);
            this.Controls.Add(this.AddPrice_TextBox);
            this.Controls.Add(this.AddID_TextBox);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.TextBox AddID_TextBox;
        private System.Windows.Forms.TextBox AddPrice_TextBox;
        private System.Windows.Forms.TextBox AddName_TextBox;
        private System.Windows.Forms.TextBox AddInStock_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddCategory_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RemoveID_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}