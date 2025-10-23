using System;

public class Have_a_good_walk
{
	public static void Sale()
	{
		int age1 = Convert.ToInt32(Console.ReadLine());
		int age2 = Convert.ToInt32(Console.ReadLine());
		int sum = age1 + age2;
		
		if (sum < 90)
		{
			Console.WriteLine(sum);
		}
		else
		{
			Console.WriteLine(90);
		}
		Console.WriteLine(age1 > age2 ? 1 : 2);
	}
}
