using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int negative = 0;
        int positive = 0;

        for ( int i = 0; i < input.Length; i++)
        {
            if( input[i] < 0 )
            {
                // negative number 
                negative -= input[i];
            } else
            {
                // positive number
                positive += input[i];
            }
        }

        if(input.Length > 0)
        {
            Console.WriteLine("im maybe here");
            var arr = Array.Empty<int>();

            Console.WriteLine(arr);
            return arr;
        }

        Console.WriteLine("im here");
        int[] list = new int[2] { positive, negative };
        return list;
    }
}
