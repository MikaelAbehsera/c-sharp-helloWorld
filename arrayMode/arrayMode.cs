int arrayMode(int[] sequence)
{
	Dictionary<int, int> log = new Dictionary<int, int>();

	foreach(int n in sequence)
	{
		if(log.ContainsKey(n))
		{
			log[n]++;
		}
		else
		{
			log[n] = 1;
		}
	}

	int large = 0;

	foreach(KeyValuePair<int, int> entry in log)
	{
		if(entry.Value > large)
		{
			large = entry.Key;
		}
	}

	return large;
}
