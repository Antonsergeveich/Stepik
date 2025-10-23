using System;

public class Analyzing_three_digit_numbers
{
	public static void Numbers()
	{
		
		int count = 0;
		
		for (int i = 100; i <= 999; i++)
		{
			int num = i;
			int sum = 0;
			while (num != 0)
			{
				sum += num % 10;
				num /= 10;
			}
			if(sum == 8) count++;
		}
		Console.WriteLine(count);
	}
}

