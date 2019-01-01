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
                negative += input[i];
            } else
            {
                // positive number

            }
        }
        return null; //return an array with count of positives and sum of negatives
    }
}
