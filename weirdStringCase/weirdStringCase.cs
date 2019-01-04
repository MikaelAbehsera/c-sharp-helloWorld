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
                string letter = (Char.ToUpper(c)).ToString();
                str.Add(letter);
            }
            else if (counter == 0)
            {
                string letter = (Char.ToUpper(c)).ToString();
                str.Add(letter);
            }
            else
            {
                string letter = (Char.ToLower(c)).ToString();
                str.Add(letter);
            }

            string empty = c.ToString();

            if (empty != " ")
            {
                counter++;
            }
        }

        return string.Join("", str.ToArray());
    }
}