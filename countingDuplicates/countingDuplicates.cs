using System;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        // make a dictionary where we can store results
        Dictionary<string, int> book = new Dictionary<string, int>();

        // split str into a list
        string[] all = str.Split("");

        // loop over all and store results in the dictionary 
        for (int i = 0; i < all.Length; i++)
        {
            string current = all[i].ToLower();

            // check if we have a log of this letter
            if (book.ContainsKey(current))
            {
                Console.WriteLine("i ran");
                //  add 1 to that log
                book[current]++;
            }
            else
            {
                // if it can not be found in the dictonary then add it
                book.Add(current, 1);
            }
        }
        // set a count for how many dup logs we have
        int count = 0;
        // if there are 2 logs of a letter add it to the count
        foreach (var log in book)
        {
            // if there are more then 1 log of that letter, count it
            Console.WriteLine(log.Key);
            Console.WriteLine(log.Value);

            if (log.Value > 1)
            {
                count++;
            }
        }

        return count;
    }
}