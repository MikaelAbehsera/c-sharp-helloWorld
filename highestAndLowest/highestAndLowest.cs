using System;

public static class Kata
{
	public static string HighAndLow(string numbers)
	{
		// split string, store all high and low numbers, return as string
		string[] list = numbers.Split(" ");
		int high;
		int low;
		Int32.TryParse(list[0], out high);
		Int32.TryParse(list[0], out low);

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