using System;

public class Initials
{
	public static void Init()
	{
		string str1 = Console.ReadLine();
		string str2 = Console.ReadLine();
		string str3 = Console.ReadLine();

		Console.WriteLine($"{str1} {str2[0]}.{str3[0]}.");
	}
}
