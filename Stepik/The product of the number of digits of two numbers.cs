using System;

public class The_product_of_the_number_of_digits_of_two_numbers
{
	public static void Numbers()
	{
		string num1 = Console.ReadLine();
		string num2 = Console.ReadLine();
		int res = ProductDigits(num1, num2);
		Console.WriteLine(res);
	}

	static int ProductDigits(string num1, string num2)
	{
		return num1.Length * num2.Length;
	}
}
