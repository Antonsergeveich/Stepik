using System;

public class Maximum_sum_of_digits
{
	public static void Digit()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int maxSum = 0;
		int number = 0;
		for (int i = 1;  i <= n; i++)
		{
			int currentSum = 0;
			int temp = i;
			while (temp != 0)
			{
				currentSum += temp % 10;
				temp /= 10;
			}
			if (currentSum > maxSum)
			{
				maxSum = currentSum;
				number = i;
			}
			else if (currentSum == maxSum && i < number)
			{
				number = i;
			}
		}
		Console.WriteLine($"{number} {maxSum}");
	}
}
