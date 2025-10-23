using System;

public class Digit
{
	public static void Num()
	{
		char c = Convert.ToChar(Console.ReadLine());
		Console.WriteLine(c >= '0' && c <= '9' ? "YES" : "NO");
	}
}
