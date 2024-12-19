namespace MarketplaceManagement
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;

        

        public MainForm()
        {
            InitializeComponent();
            Instance = this;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProductMngmnt_Click(object sender, EventArgs e)
        {
            formSearchAndAdd formSearchAndAdd = new formSearchAndAdd();
            formSearchAndAdd.Show();
            this.Hide();

        }
        private void btnSaleMngmnt_Click(object sender, EventArgs e)
        {
            formSaleManagement formSaleManagement = new formSaleManagement();
            formSaleManagement.Show();
            this.Hide();
        }
        private void btnStockMngmnt_Click(object sender, EventArgs e)
        {
            formStockManagement formStockManagement = new formStockManagement();
            formStockManagement.Show();
            this.Hide();
        }

        private void btnReportMngmnt_Click(object sender, EventArgs e)
        {
            formReportManagement formReportManagement = new formReportManagement();
            formReportManagement.Show();
            this.Hide();
        }

        

       
    }
}
