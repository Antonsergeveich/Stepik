using System;

public class Changing_the_character_case
{
	public static void Case()
	{
		char c = Convert.ToChar(Console.ReadLine());
		if(c >= 'a' && c <= 'z') Console.WriteLine((char)(c - 32));
		else if(c >= 'A' && c <= 'Z') Console.WriteLine((char)(c + 32));
		else Console.WriteLine(c);
	}
}
