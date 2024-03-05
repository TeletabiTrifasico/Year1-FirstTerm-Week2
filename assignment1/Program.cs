using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Culture of the program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const double vat = 21;

            Console.WriteLine("Enter a price: ");
            string input = Console.ReadLine();
            double price = double.Parse(input);
                
            double vatPrice = (price * vat) * 0.01 ;
            double finalPrice = price + vatPrice;

            Console.WriteLine($"price: {price:0.00}, " + $"VAT: {vatPrice:0.00}, " + $"total: {finalPrice:0.00}");
        }
    }
}