using System;

public class The_words_are_too_long
{
	public static void Long_word()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i < n; i++)
		{
			string str = Console.ReadLine();

			if(str.Length > 10)
			{
				int len = str.Length - 2;
				str = $"{str[0]}{len}{str[str.Length - 1]}";
			}
			Console.WriteLine(str);
		}
	}
}
