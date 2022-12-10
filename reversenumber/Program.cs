using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the word ");
            string input = Convert.ToString(Console.ReadLine());
            ReverseWord.reverseword(input);
            Console.ReadLine();

        }
    }
}