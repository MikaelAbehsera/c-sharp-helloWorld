using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    List<string> output = new List<string>();

    for (int i = 0; i < names.Length; i++ ) {
      if (names[i].Length <= 4) {
        output.Add(names[i]);
      }
    }

    return output;
  }
}