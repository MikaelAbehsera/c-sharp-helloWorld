using System;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            AddFive(number);
            Console.WriteLine(number);
            Console.ReadKey();
        }

        static void AddFive(int number)
        {
            number = number + 5;
        }
    }