namespace MarketplaceManagement
{
    partial class MainForm
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
            btnProductMngmnt = new Button();
            label1 = new Label();
            btnSaleMngmnt = new Button();
            btnStockMngmnt = new Button();
            btnReportMngmnt = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnProductMngmnt
            // 
            btnProductMngmnt.Location = new Point(268, 65);
            btnProductMngmnt.Name = "btnProductMngmnt";
            btnProductMngmnt.Size = new Size(187, 65);
            btnProductMngmnt.TabIndex = 0;
            btnProductMngmnt.Text = "Ürün Yönetimi";
            btnProductMngmnt.UseVisualStyleBackColor = true;
            btnProductMngmnt.Click += btnProductMngmnt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 35);
            label1.TabIndex = 1;
            label1.Text = "Mağaza Takip Sistemi";
            // 
            // btnSaleMngmnt
            // 
            btnSaleMngmnt.Location = new Point(268, 136);
            btnSaleMngmnt.Name = "btnSaleMngmnt";
            btnSaleMngmnt.Size = new Size(187, 65);
            btnSaleMngmnt.TabIndex = 0;
            btnSaleMngmnt.Text = "Satış Yönetimi";
            btnSaleMngmnt.UseVisualStyleBackColor = true;
            btnSaleMngmnt.Click += btnSaleMngmnt_Click;
            // 
            // btnStockMngmnt
            // 
            btnStockMngmnt.Location = new Point(268, 207);
            btnStockMngmnt.Name = "btnStockMngmnt";
            btnStockMngmnt.Size = new Size(187, 65);
            btnStockMngmnt.TabIndex = 0;
            btnStockMngmnt.Text = "Stok Yönetimi";
            btnStockMngmnt.UseVisualStyleBackColor = true;
            btnStockMngmnt.Click += btnStockMngmnt_Click;
            // 
            // btnReportMngmnt
            // 
            btnReportMngmnt.Location = new Point(268, 278);
            btnReportMngmnt.Name = "btnReportMngmnt";
            btnReportMngmnt.Size = new Size(187, 65);
            btnReportMngmnt.TabIndex = 0;
            btnReportMngmnt.Text = "Raporlama";
            btnReportMngmnt.UseVisualStyleBackColor = true;
            btnReportMngmnt.Click += btnReportMngmnt_Click;
            // 
            // button1
            // 
            button1.Location = new Point(612, 166);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnReportMngmnt);
            Controls.Add(btnStockMngmnt);
            Controls.Add(btnSaleMngmnt);
            Controls.Add(btnProductMngmnt);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mağaza Takip Sistemi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductMngmnt;
        private Label label1;
        private Button btnSaleMngmnt;
        private Button btnStockMngmnt;
        private Button btnReportMngmnt;
        private Button button1;
    }
}
