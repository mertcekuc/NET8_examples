namespace EntityFW
{
    public partial class Form1 : Form
    {
        ProductDal _prooductDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        void updateTable()
        {
            dgwProduct.DataSource = _prooductDal.GetAll();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _prooductDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                ProductName = lblName.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxAmount.Text)
            };

            _prooductDal.Add(p);
            MessageBox.Show("Added");
            updateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prooductDal.Delete(new Product
            {
                id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Deleted");
            updateTable();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUpPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUpAmount.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _prooductDal.Update(new Product
            {
                id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpName.Text.ToString(),
                UnitPrice= Convert.ToDecimal(tbxUpPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpAmount.Text)
            });

            MessageBox.Show("Updated");
            updateTable();

            
        }
    }
}
