namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public void updateTable()
        {
            dgwProduct.DataSource = _productDal.GetAll();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProduct.DataSource = _productDal.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                ProductName = tbxAmount.Text,
                UnitPrice = Convert.ToDecimal(tbxAmount.Text),
                StockAmount = Convert.ToInt32(tbxAmount.Text)

            });

            MessageBox.Show("Added");
            updateTable();


        }

        private void tbxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUpPrice.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxUpAmount.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUPdate_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpName.Text.ToString(),
                StockAmount = Convert.ToInt32(tbxUpAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUpPrice.Text)

            };
            _productDal.Update(p);
            MessageBox.Show("Updated");
            updateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            MessageBox.Show("Deleted");
            updateTable();

        }
    }
}
