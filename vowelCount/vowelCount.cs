using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char letter in str) {
          if ( letter.ToLower() == "a" || letter.ToLower() == "e" || letter.ToLower() == "i" || letter.ToLower() == "o" || letter.ToLower() == "u" ) {
            vowelCount++;
          }
        }

        return vowelCount;
    }
}
