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
                positive += input[i];
            }
        }

        if(positive > 0 && negative < 0)
        {
            return new List<int>[positive, negative];
        }

        return new List<int>[];
    }
}
