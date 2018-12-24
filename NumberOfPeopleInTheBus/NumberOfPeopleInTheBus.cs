
using System;
using System.Collections.Generic;

public class Kata
{
  public static int Number(List<int[]> peopleListInOut)
  {
    // int peopleOnBus = 0;
    int peopleOnBus = peopleListInOut[0][1];

    for (int i = 0; i < peopleListInOut.Count; i++)
    {
      peopleOnBus += peopleListInOut[i][0];
      peopleOnBus -= peopleListInOut[i][1];
    }

    return peopleOnBus;

  }
}