using System;

public class Line
{
	public static string Tickets(int[] peopleInLine)
	{
		int bank = 0;
		foreach(int payment in peopleInLine) {
			
			int change = payment;
			change -= 25;
			bank += 25;
			if (bank - payment < 0) {
				return "NO";
			}
		}
		return "YES";
	}
}

// get money
// subract 25 and add 25 to bank
// check for change
