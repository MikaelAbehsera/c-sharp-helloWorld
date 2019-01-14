string capitalizeVowelsRegExp(string input)
{
	string str = "";	

	foreach(char c in input) {
	if(c.ToString() == "a" || c.ToString() == "e" || c.ToString() == "i" || c.ToString() == "o" || c.ToString() == "u" || c.ToString() == "y" ) {
			str += Char.ToUpper(c).ToString();
		} else {
			str += c.ToString();
		}
	}
	return str;
}
