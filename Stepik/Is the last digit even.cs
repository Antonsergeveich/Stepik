using System;
using static System.Console;
public class Is_the_last_digit_even
{
	public static void Is_it_even()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		WriteLine(num % 10 % 2 == 0 ? "YES" : "NO");
	}
}
