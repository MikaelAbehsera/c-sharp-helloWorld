public class Kata
{
  public static int FindShort(string s)
  {
    // split words by spaces
    // get word length
    // store 2 variables ==> 1 shortest word index, 2 shortest word length for refrence

    string spl = s.Split(" ");
    int shortestWordLength = 0;
    int shortestWordIndex = 0;
    
    for( int i = 0; i < spl.Length; i++ ) {
      if( spl[i].Length < shortestWordLength ) {
        shortestWordLength = spl[i].Length;
        shortestWordIndex = i;
      }  
    }

    return spl[shortestWordIndex];
  }
}