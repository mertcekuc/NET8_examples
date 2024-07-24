namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProduct = new DataGridView();
            lblName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxAmount = new TextBox();
            label3 = new Label();
            tbxUnitPrice = new TextBox();
            btnAdd = new Button();
            gbxAdd = new GroupBox();
            tbxUpName = new TextBox();
            tbxUpAmount = new TextBox();
            tbxUpPrice = new TextBox();
            Laabel4 = new Label();
            Label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            gbxAdd.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(22, 62);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.Size = new Size(446, 215);
            dgwProduct.TabIndex = 0;
            dgwProduct.CellClick += dgwProduct_CellClick;
            dgwProduct.CellContentClick += dgwProduct_CellContentClick;
            // 
            // lblName
            // 
            lblName.Location = new Point(85, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 23);
            lblName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Amount";
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(85, 81);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(111, 23);
            tbxAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 131);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(85, 125);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(111, 23);
            tbxUnitPrice.TabIndex = 5;
            tbxUnitPrice.TextChanged += tbxUnitPrice_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(70, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxAmount);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(label3);
            gbxAdd.Controls.Add(label1);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(label2);
            gbxAdd.Location = new Point(22, 298);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(229, 215);
            gbxAdd.TabIndex = 8;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add Item";
            gbxAdd.Enter += groupBox1_Enter;
            // 
            // tbxUpName
            // 
            tbxUpName.Location = new Point(77, 29);
            tbxUpName.Name = "tbxUpName";
            tbxUpName.Size = new Size(100, 23);
            tbxUpName.TabIndex = 9;
            // 
            // tbxUpAmount
            // 
            tbxUpAmount.Location = new Point(77, 71);
            tbxUpAmount.Name = "tbxUpAmount";
            tbxUpAmount.Size = new Size(100, 23);
            tbxUpAmount.TabIndex = 10;
            // 
            // tbxUpPrice
            // 
            tbxUpPrice.Location = new Point(77, 113);
            tbxUpPrice.Name = "tbxUpPrice";
            tbxUpPrice.Size = new Size(100, 23);
            tbxUpPrice.TabIndex = 11;
            // 
            // Laabel4
            // 
            Laabel4.AutoSize = true;
            Laabel4.Location = new Point(18, 29);
            Laabel4.Name = "Laabel4";
            Laabel4.Size = new Size(39, 15);
            Laabel4.TabIndex = 12;
            Laabel4.Text = "Name";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(18, 77);
            Label5.Name = "Label5";
            Label5.Size = new Size(51, 15);
            Label5.TabIndex = 13;
            Label5.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 121);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(tbxUpName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbxUpAmount);
            groupBox1.Controls.Add(Label5);
            groupBox1.Controls.Add(tbxUpPrice);
            groupBox1.Controls.Add(Laabel4);
            groupBox1.Location = new Point(285, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 205);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "gbxUpdate";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(62, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUPdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(387, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 546);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProduct);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProduct;
        private TextBox lblName;    
        private Label label1;
        private Label label2;
        private TextBox tbxAmount;
        private Label label3;
        private TextBox tbxUnitPrice;
        private Button btnAdd;
        private GroupBox gbxAdd;
        private TextBox tbxUpName;
        private TextBox tbxUpAmount;
        private TextBox tbxUpPrice;
        private Label Laabel4;
        private Label Label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
