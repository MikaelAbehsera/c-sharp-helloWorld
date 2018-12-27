public class Kata
{
  public static string DoubleChar(string s)
  {
    string[] str = s.Split("");
    List<string> output = new List<string>();
    foreach (string letter in str) {
      output.Add(letter);
      output.Add(letter);
    }
    output.Join("");

    return output;
  }
}