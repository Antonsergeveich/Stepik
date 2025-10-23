using System;

public class Palindrome
{
	public static void PalindromNumber()
	{
		//int num = Convert.ToInt32(Console.ReadLine());
		//int num2 = num;
		//int reversed = 0;
		//while (num2 > 0)
		//{
		//	int digit = num2 % 10;
		//	reversed = reversed * 10 + digit;
		//	num2 /= 10;
		//}
		//Console.WriteLine(num == reversed ? "YES" : "NO");

		int num = Convert.ToInt32(Console.ReadLine());
		int num2 = num;
		int reverse = 0;
		while (num2 > 0)
		{
			reverse = reverse * 10 + num2 % 10;
			num2 /= 10;
		}
		Console.WriteLine(reverse == num ? "YES" : "NO");
	}
}
