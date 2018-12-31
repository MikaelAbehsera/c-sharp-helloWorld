using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        int i = -1;
        
        foreach (var n in haystack)
        {
            i++;
            if (n.ToString() == "needle")
            {
                return "found the needle at position " + (i);
            }
        }

        return "N/A";
    }
}