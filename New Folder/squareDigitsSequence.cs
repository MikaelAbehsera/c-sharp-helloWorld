int def = 0;

int squareDigitsSequence(int aN, int counter = 0)
{
	def = aN;
	// update the counter
	counter++;
	// split the number
	string[] intList = aN.ToString().Split("");
	// store sum
	int sum = 0;
	// loop, square, and store
	foreach(char i in intList) {
		int l = 0;
		Int32.TryParse(i.ToString(), out l);
		sum += l * l;
	}
	
	if(def == aN) {
		return counter;
	} else {
		return squareDigitsSequence(aN, counter);
	}
}
