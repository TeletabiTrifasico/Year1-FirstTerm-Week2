using System.Diagnostics;
using System.Globalization;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //Value for vat
            const double vat = 21;

            //set the values for all variables
            string inputStartKm = txtbxStartKm.Text;
            double StartKm = double.Parse(inputStartKm);
            string inputEndKm = txtbxEndKm.Text;
            double EndKm = double.Parse(inputEndKm);
            string inputPriceKm = txtbxPriceKm.Text;
            double PriceKm = double.Parse(inputPriceKm);

            //Set the prices
            double kmLeft = EndKm - StartKm;
            double price = kmLeft * PriceKm;
            txtPriceExcl.Text = price.ToString("0.00");   //Display the price without VAT

            //Do the VAt calculations
            double vatPrice = (price * vat) * 0.01;
            txtVat.Text = vatPrice.ToString("0.00");   //Display the VAT
            double finalPrice = price + vatPrice;
            txtPriceIncl.Text = finalPrice.ToString("0.00");   //Display the price with VAT

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            //Clears textboxes
            txtbxStartKm.Text = "";
            txtbxEndKm.Text = "";
            txtbxPriceKm.Text = "";

            //Clears output labels
            txtPriceExcl.Text = "";
            txtVat.Text = "";
            txtPriceIncl.Text = "";
        }
    }
}