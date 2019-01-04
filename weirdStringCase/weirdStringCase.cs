using System;
using System.Collections.Generic;

public class Kata
{
    public static string ToWeirdCase(string s)
    {
        int counter = 0;
        List<string> str = new List<string>();


        foreach (char c in s)
        {

            if (counter % 2 == 0)
            {
               char letter = Char.ToUpper(c);
                str.Add(letter.ToString());
            } else
            {
                str.Add(c.ToString());
            }

            counter++;
        }

        return s;
    }
}