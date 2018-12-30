using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int xCounter = 0;
    int oCounter = 0;

    foreach (char c in input ) {
        if(c.ToString().ToLower() == "x") {
            xCounter++;
        } else if(c.ToString().ToLower() == "o") {
            oCounter++;
        }
    }

    return xCounter == oCounter;
  }
}