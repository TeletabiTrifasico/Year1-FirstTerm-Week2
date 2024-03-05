using System.Globalization;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of seconds: ");
            string input = Console.ReadLine();
            int numberOfSeconds = int.Parse(input);

            int hours = numberOfSeconds / 3600;
            numberOfSeconds = numberOfSeconds - hours * 3600;

            int minutes = numberOfSeconds / 60;
            numberOfSeconds = numberOfSeconds - minutes * 60;

            Console.WriteLine($"{hours:00}:{minutes:00}:{numberOfSeconds:00}");
        }
    }
}