using System;

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
                str.add(letter);
            } else
            {
                str.add(letter);
            }

            counter++;
        }

        return s;
    }
}