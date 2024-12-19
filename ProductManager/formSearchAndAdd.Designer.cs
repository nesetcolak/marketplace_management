namespace MarketplaceManagement
{
    partial class formSearchAndAdd
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
            buttonAddProduct = new Button();
            buttonSearchProduct = new Button();
            returnButtonControl1 = new ReturnButtonControl();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(206, 87);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(327, 85);
            buttonAddProduct.TabIndex = 0;
            buttonAddProduct.Text = "Ürün Ekle";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(206, 200);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(327, 85);
            buttonSearchProduct.TabIndex = 0;
            buttonSearchProduct.Text = "Ürün Ara";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // returnButtonControl1
            // 
            returnButtonControl1.Location = new Point(12, 12);
            returnButtonControl1.Name = "returnButtonControl1";
            returnButtonControl1.Size = new Size(188, 188);
            returnButtonControl1.TabIndex = 1;
            returnButtonControl1.Load += returnButtonControl1_Load;
            // 
            // formSearchAndAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnButtonControl1);
            Controls.Add(buttonSearchProduct);
            Controls.Add(buttonAddProduct);
            Name = "formSearchAndAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSearchAndAdd";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddProduct;
        private Button buttonSearchProduct;
        private ReturnButtonControl returnButtonControl1;
    }
}