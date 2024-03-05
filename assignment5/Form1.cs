using System.Globalization;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            //first input
            string firstInput = txtbxNumber1.Text;
            double firstNumber = double.Parse(firstInput);
            //second input
            string secondInput = txtbxNumber2.Text;
            double secondNumber = double.Parse(secondInput);
            //third input
            string thirdInput = txtbxNumber3.Text;
            double thirdNumber = double.Parse(thirdInput);
            //calculations
            double average = (firstNumber + secondNumber + thirdNumber) / 3;
            txtAverageOutput.Text = average.ToString("0.000");
        }
    }
}