using System;

namespace VariableScope
{
    class Program
    {
        // set var to private and static so new class instance does not need to be made
        private static string helloClass = "Hello, class!";
        // set up static func to return nothing
        static void Main(string[] args)
        {

            string helloLocal = "Hello, local!";
            Console.WriteLine(helloLocal);
            Console.WriteLine(Program.helloClass);
            DoStuff();
        }

        static void DoStuff()
        {
            Console.WriteLine("A message from DoStuff: " + Program.helloClass);
        }
    }
}