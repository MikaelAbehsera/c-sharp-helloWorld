using System;

public class Methods
{
  public static void Main()
  {

    int x = 2;
    int y = 2;
    int a = foo(x, y);
    Console.WriteLine(a);

  }

  //write method foo here

  public static int foo(int num1, int num2)
  {
    return (num1 / num2);
  }

}