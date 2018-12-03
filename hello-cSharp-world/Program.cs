

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!, What is 20 + 20?");
            int userInput1 = int.Parse(Console.ReadLine());

            if(QuestionAdd( 20, 20, userInput1))
            {
                Console.WriteLine("Good Jerb");
            }
            else
            {
                Console.WriteLine("Bad Jerb");
            }
        }

        static bool QuestionAdd(int first, int second, int answer)
        {
            // if answer is good 
            if ((first + second) == answer)
            {
                return true;
            }
            // if answer is bad
            return false;
        }
    }
}