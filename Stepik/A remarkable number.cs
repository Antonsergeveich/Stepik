using System;

public class A_remarkable_number
{
	public static void Num()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int number = num;
		int sum = 0;
		while (number != 0)
		{
			int ost = number % 10;
			sum += ost;
			number /= 10;
		}
		if (num % sum == 0) Console.WriteLine("YES");
		else Console.WriteLine("NO");
	}
}
