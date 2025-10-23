using System;

public class The_sum_of_the_inverse_numbers
{
	public static void InverseSum()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int res = ReverseNumber(a) + ReverseNumber(b);
		Console.WriteLine(res);
	}
	static int ReverseNumber(int a)
	{
		int num = 0;
		while (a > 0)
		{
			int digit = a % 10;
			num = num * 10 + digit;
			a /= 10;
		}
		return num;
	}
}
