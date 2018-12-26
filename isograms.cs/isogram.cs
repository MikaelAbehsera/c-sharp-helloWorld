using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    char[] spl = str.Split("");

    bool status = true;

    for( int i = 0; i < spl.Length; i++ ) {
      if( spl[i] == spl[--i] ) {
        status = false;
      }
    }

    return status;
  }
}