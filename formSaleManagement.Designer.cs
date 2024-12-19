namespace MarketplaceManagement
{
    partial class formSaleManagement
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
            SuspendLayout();
            // 
            // returnButtonControl1
            // 
            returnButtonControl1.Location = new Point(12, 12);
            returnButtonControl1.Name = "returnButtonControl1";
            returnButtonControl1.Size = new Size(188, 188);
            returnButtonControl1.TabIndex = 0;
            // 
            // formSaleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnButtonControl1);
            Name = "formSaleManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Yönetimi";
            Load += formSaleManagement_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReturnButtonControl returnButtonControl1;
    }
}