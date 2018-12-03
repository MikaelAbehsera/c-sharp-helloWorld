using System;

namespace VariableScope
{
    class Program
    {
        //TODO: this is a todo comment
        static void Main(string[] args)
        {
            GreetPersons(0);
            GreetPersons(25, "John", "Jane", "Tarzan");
            Console.ReadKey();
        }
       //HACK: this is a hack comment
        static void GreetPersons(int someUnusedParameter, params string[] names)
        {
            foreach (string name in names)
                Console.WriteLine("Hello, " + name);
        }
    }
} 