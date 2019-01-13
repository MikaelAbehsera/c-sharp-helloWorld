using System;

public static class Kata
{
	/// <summary>
	/// Function will take in an array containing names and return a relevant message
	/// </summary>
	/// <param name="name"></param>
	/// <returns></returns>
	public static string Likes(string[] name)
	{
		if(name.Length == 1) return name[1] + " likes this";
		else if(name.Length == 2) return name[0] + " and " + name[1] + " like this";
		else if(name.Length == 3) return name[0] + ", " + name[1] + " and " + name[2] + " like this";
		else if(name.Length > 3) return name[0] + ", " + name[1] + " and " + name.Length + " others like this";
		else return "no one likes this";
	}
}
