namespace MarketplaceManagement
{
    partial class formAddProduct
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
            returnButtonControl1 = new ReturnButtonControl();
            dataGridView1 = new DataGridView();
            textBoxName = new TextBox();
            label1 = new Label();
            comboBoxCategory = new ComboBox();
            label2 = new Label();
            textBoxAmount = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            columnId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnCategory = new DataGridViewTextBoxColumn();
            columnStock = new DataGridViewTextBoxColumn();
            columnStore = new DataGridViewTextBoxColumn();
            label4 = new Label();
            comboBoxStore = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnButtonControl1
            // 
            returnButtonControl1.Location = new Point(12, 12);
            returnButtonControl1.Name = "returnButtonControl1";
            returnButtonControl1.Size = new Size(51, 43);
            returnButtonControl1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnId, columnName, columnCategory, columnStock, columnStore });
            dataGridView1.Location = new Point(137, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 439);
            dataGridView1.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(109, 27);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Ürün Adı";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(12, 146);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(109, 28);
            comboBoxCategory.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Kategori";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(12, 214);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(109, 27);
            textBoxAmount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 191);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Eklenecek Adet";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 330);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(109, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // columnId
            // 
            columnId.HeaderText = "Ürün ID";
            columnId.MinimumWidth = 6;
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            columnId.Width = 125;
            // 
            // columnName
            // 
            columnName.HeaderText = "Ürün Adı";
            columnName.MinimumWidth = 6;
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            columnName.Width = 125;
            // 
            // columnCategory
            // 
            columnCategory.HeaderText = "Kategori";
            columnCategory.MinimumWidth = 6;
            columnCategory.Name = "columnCategory";
            columnCategory.ReadOnly = true;
            columnCategory.Resizable = DataGridViewTriState.True;
            columnCategory.Width = 125;
            // 
            // columnStock
            // 
            columnStock.HeaderText = "Stok";
            columnStock.MinimumWidth = 6;
            columnStock.Name = "columnStock";
            columnStock.ReadOnly = true;
            columnStock.Resizable = DataGridViewTriState.True;
            columnStock.Width = 125;
            // 
            // columnStore
            // 
            columnStore.HeaderText = "Şube";
            columnStore.MinimumWidth = 6;
            columnStore.Name = "columnStore";
            columnStore.ReadOnly = true;
            columnStore.Resizable = DataGridViewTriState.True;
            columnStore.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 255);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Şube";
            
            // 
            // comboBoxStore
            // 
            comboBoxStore.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxStore.FormattingEnabled = true;
            comboBoxStore.Location = new Point(12, 278);
            comboBoxStore.Name = "comboBoxStore";
            comboBoxStore.Size = new Size(109, 28);
            comboBoxStore.TabIndex = 4;
            // 
            // formProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxStore);
            Controls.Add(label4);
            Controls.Add(comboBoxCategory);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView1);
            Controls.Add(returnButtonControl1);
            Name = "formProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Yönetimi";
            Load += formProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReturnButtonControl returnButtonControl1;
        private DataGridView dataGridView1;
        private TextBox textBoxName;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label label2;
        private TextBox textBoxAmount;
        private Label label3;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnCategory;
        private DataGridViewTextBoxColumn columnStock;
        private DataGridViewTextBoxColumn columnStore;
        private Label label4;
        private ComboBox comboBoxStore;
    }
}