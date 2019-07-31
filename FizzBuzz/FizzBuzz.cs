using System;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer fb = new FizzBuzzer();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fb.FizzBuzz(i));
            }
        }
    }

    public class FizzBuzzer
    {
        string result = string.Empty;

        public string FizzBuzz(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }
    }
}