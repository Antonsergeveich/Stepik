using System;

public class The_digital_root
{
	public static void Digit()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		if(num < 10)
		{
			Console.WriteLine(num);
			return;
		}
		int sum = 0;
		while (num > 9)
		{
			sum = 0;
			while (num > 0)
			{
				int digit = num % 10;
				sum += digit;
				num /= 10;
			}
			num = sum;
		}
		Console.WriteLine(sum);
	}
}
