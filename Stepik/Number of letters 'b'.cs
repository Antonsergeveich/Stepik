using System;

public class Number_of_letters__b_
{
	public static void Letters()
	{
		string str1 = Console.ReadLine();
		string str2 = Console.ReadLine();

		Console.WriteLine(Letter(str1, 'b') + Letter(str2, 'b'));
	}

	static int Letter(string str, char b)
	{
		int coutn = 0;
		for(int i = 0; i <= str.Length - 1; i++)
		{
			if (str[i] == b)coutn++;
		}
		return coutn;
	}
}
