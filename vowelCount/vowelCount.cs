using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char letter in str) {
          if ( Char.ToLower(letter).ToString() == "a" || Char.ToLower(letter).ToString() == "e" || Char.ToLower(letter).ToString() == "i" || Char.ToLower(letter).ToString() == "o" || Char.ToLower(letter).ToString() == "u" ) {
            vowelCount++;
          }
        }

        return vowelCount;
    }
}
