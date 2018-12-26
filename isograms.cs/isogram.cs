using System;

public class Kata
{
  public static bool IsIsogram(string str)
  {

    bool status = true;

    //TODO  fix error here ==> ```Solution.cs(11,23): error CS0029: Cannot implicitly convert type 'string' to 'char'```
    char lastLetter = "c";

    foreach (char letter in str)
    {
      if (letter == lastLetter)
      {
        status = false;
      }
      lastLetter = letter;
    }

    return status;
  }
}