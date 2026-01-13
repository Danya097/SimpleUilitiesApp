using System;

namespace SimpleUtilitiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Utilities App!");

            int sum = Utilities.Add(5, 7);
            Console.WriteLine($"5 + 7 = {sum}");

            int difference = Utilities.Subtract(10, 3);
            Console.WriteLine($"10 - 3 = {difference}");

            int random = Utilities.RandomNumber(1, 100);
            Console.WriteLine($"Random number between 1 and 100: {random}");

            Utilities.GreetUser("Daniil");

            int number = 8;
            bool even = Utilities.IsEven(number);
            Console.WriteLine($"{number} is even? {even}");

            Console.WriteLine("All methods tested successfully!");
        }
    }
}