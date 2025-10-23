using System;

public class Two_identical_letters
{
	public static void Letters()
	{
		string s = Console.ReadLine();

		for (int i = 0; i <= s.Length - 1; i++)
		{
			for (int j = i + 1; j < s.Length; j++)
			{
				if (s[i] == s[j])
				{
					Console.WriteLine(s[i]);
					return;
				}
			}
		}
	}
}
