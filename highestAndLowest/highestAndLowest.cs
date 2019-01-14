using System;

public static class Kata
{
	public static string HighAndLow(string numbers)
	{
		// split string, store all high and low numbers, return as string
		int high = 0;
		int low = 0;
		string[] list = numbers.Split(" ");

		foreach (string l in list) {
			int n;
			Int32.TryParse(l.ToString(), out n);
			if (n > high) {
				high = n;
			} 
			if (n < low) {
				low = n;
			}
		}

		return high.ToString() + " " + low.ToString();

	}
}