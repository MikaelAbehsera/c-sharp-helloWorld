using System;

namespace VariableScope
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            if (result > 10)
            {
                return result;
            }
            return 0;
        }
    }
}