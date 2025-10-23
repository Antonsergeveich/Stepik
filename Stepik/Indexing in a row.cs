using System;

public class Indexing_in_a_row
{
	public static void Row()
	{
		string str1 = Console.ReadLine();
		string str2 = Console.ReadLine();

		if (str1[0] == str2[str2.Length - 1])
		{
			Console.WriteLine("YES");
		}
		else
		{
			Console.WriteLine("NO");
		}
	}
}
