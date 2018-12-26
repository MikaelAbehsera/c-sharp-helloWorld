using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    string[] spl = str.Split("");

    bool status = true;

    for( int i = 0; i < spl.Length; i++) {
      if( str[i] == str[i-1] ) {
        status = false;
      }
    }

    return status;
  }
}