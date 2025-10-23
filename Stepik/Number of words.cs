using System;

public class Number_of_words
{
	public static void Words()
	{
		string str = Console.ReadLine();
		int count = 1;
		for(int i = 0; i < str.Length; i++)
		{
			if (str[i] == ' ') count++;
		}
		Console.WriteLine(count);
	}
}
