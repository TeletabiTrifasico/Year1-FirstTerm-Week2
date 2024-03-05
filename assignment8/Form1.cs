namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double vat = 21;
            const double shirtsPrice = 30;
            const double jeansPrice = 100;

            string inputShirts = txtbxNumberShirts.Text;
            double totalPriceShirts = double.Parse(inputShirts) * shirtsPrice;

            string inputJeans = txtbxNumberJeans.Text;
            double totalPriceJeans = double.Parse(inputJeans) * jeansPrice;

            double price = totalPriceJeans + totalPriceShirts;
            txtPrice.Text = ("€ " + price.ToString("0.00"));

            double vatPrice = (price * vat) * 0.01;
            txtVat.Text = ("€ " + vatPrice.ToString("0.00"));
            double finalPrice = price + vatPrice;
            txtTotalPrice.Text = ("€ " + finalPrice.ToString("0.00"));

            txtTimer.Text = DateTime.Now.ToString();
        }

        private void txtTimer_Click(object sender, EventArgs e)
        {

        }
    }
}