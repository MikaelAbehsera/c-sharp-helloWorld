 bool isIncreasingDigitsSequence(int n)
{
	string num = n.ToString();
	char[] numbers = num.ToCharArray();

	for(int i = 1; i < numbers.Length; i++)
	{
		int num1;
		int num2;

		Int32.TryParse(numbers[i - 1].ToString(), out num1);
		Int32.TryParse(numbers[i].ToString(), out num2);


		if(num1 >= num2)
		{
			return false;
		}
	}

	return true;
}