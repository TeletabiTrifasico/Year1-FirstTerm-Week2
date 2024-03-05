namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first input
            Console.Write("Enter 1st number: ");
            string firstInput = Console.ReadLine();
            double firstNumber = double.Parse(firstInput);
            //second input
            Console.Write("Enter 2nd number: ");
            string secondInput = Console.ReadLine();
            double secondNumber = double.Parse(secondInput);
            //third input
            Console.Write("Enter 3rd number: ");
            string thirdInput = Console.ReadLine();
            double thirdNumber = double.Parse(thirdInput);
            //calculations
            double average = (firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine($"The average is: {average}");

        }
    }
}