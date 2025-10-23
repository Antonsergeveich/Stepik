using System;

public class Line_number
{
	public static void Number()
	{
		string s = Console.ReadLine();
		int count = 0;
		while (true)
		{
			string x = Console.ReadLine();
			count++;
			if(x == s) break;
		}
		Console.WriteLine(count);
	}
}
