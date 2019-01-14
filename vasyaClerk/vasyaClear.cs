using System;

public class Line
{
	public static string Tickets(int[] peopleInLine)
	{
		int bank = 0;
		Dictionary<int, int> register = new Dictionary<int, int>();
		register.Add(100, 0);
		register.Add(50, 0);
		register.Add(25, 0);
		register.Add(10, 0);
		register.Add(5, 0);

		foreach(int payment in peopleInLine) {
			// loop on dicionary and see if we have bills to return cash
			int change = payment;
			foreach(KeyValuePair<int, int> bill in register) {
				// do we need to return change?
				if(payment - 25 > 0) {
					if(bill.value > 0) {
						// check if we can pay with this bill 
						int times = (change % bill.key);
						if(times > 0) {
							change - (bill.value * times);
						}
					}
				}
			}
			if(change > 0) {
				return "NO";
			}
		}
		return "YES";
	}
}

