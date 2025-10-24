using System;

public class The_agony_of_choice
{
	public static void Choice()
	{
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(MaxSum(num1,num2));
	}

	static int MaxSum(int num1, int num2)
	{
		int sum1 = 0;
		int sum2 = 0;
		
		while (num1 > 0)
		{
			sum1 += num1 % 10;
			num1 /= 10;
		}
		while (num2 > 0)
		{
			sum2 += num2 % 10;
			num2 /= 10;
		}
		if (sum1 > sum2) return 1;
		else if (sum1 < sum2) return -1;
		else return 0;
	}
}
