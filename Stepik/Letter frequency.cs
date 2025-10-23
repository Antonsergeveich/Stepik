using System;

public class Letter_frequency
{
	public static void Letter()
	{
		string s = Console.ReadLine();
		for (char i = 'a'; i <= 'z'; i++)
		{
			int count = 0;
			for (int j = 0; j < s.Length; j++)
			{
				if (s[j] == i) count++;
			}
			if (count > 0) Console.WriteLine($"{i} {count}");
		}
	}
}
