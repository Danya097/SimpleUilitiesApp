using System;

namespace SimpleUtilitiesApp
{
    public static class Utilities
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int RandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to Simple Utilities App!");
        }

        public static bool IsEven(int number) => number % 2 == 0;
    }
}