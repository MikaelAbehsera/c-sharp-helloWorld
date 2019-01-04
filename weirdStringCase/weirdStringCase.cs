using System;

public class Kata
{
    public static string ToWeirdCase(string s)
    {
        int counter = 0; 

        foreach ( char c in s )
        {

            if (counter % 2 == 0)
            {
                c = c.ToUpper();
            }

            counter++;
        }

        return s;
    }
}