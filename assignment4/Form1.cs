using System.Diagnostics;
using System.Globalization;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateVat_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //Value for vat
            const double vat = 21;

            //Store users input
            string input = txtbxUsersInput.Text;

            //display the price
            double price = double.Parse(input);
            txtPriceOutput.Text = price.ToString("0.00");

            //Calculates the total
            double vatPrice = (price * vat) * 0.01;
            double finalPrice = price + vatPrice;

            //display the total
            txtTotalOutput.Text = finalPrice.ToString("0.00");

            //display the VAT
            txtVatOutput.Text = vatPrice.ToString("0.00");
        }

        private void lblStaticPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblStaticEnterPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblStaticTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblStaticVat_Click(object sender, EventArgs e)
        {

        }

        private void txtbxUsersInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}