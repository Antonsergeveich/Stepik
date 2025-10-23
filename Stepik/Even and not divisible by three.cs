using System;

public class Even_and_not_divisible_by_three
{
	public static void Even()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		while (num > 0)
		{
			if(num % 2 == 0 && num % 3 != 0) sum += num;
			num = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(sum);
	}
}
