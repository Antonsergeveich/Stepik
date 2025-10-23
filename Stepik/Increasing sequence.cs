using System;
using static System.Console;

public class Increasing_sequence
{
	public static void Increasing()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int a = num % 10;
		int b = num % 100 / 10;
		int c = num / 100;
		WriteLine(a > b && b > c ? "YES" : "NO");
	}
}
