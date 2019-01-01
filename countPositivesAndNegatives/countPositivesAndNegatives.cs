using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] results = new int[0];
        int pos = 0;
        int neg = 0;
        if (input != null && input.Length > 0)
        {
            results = new int[2];
            foreach (var i in input)
            {
                if (i > 0) { pos++; }
                else { neg += i; }
            }
            results[0] = pos;
            results[1] = neg;
        }
        return results; //return an array with count of positives and sum of negatives
    }
}