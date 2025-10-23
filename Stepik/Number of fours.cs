using System;

public class Number_of_fours
{
	public static void Num()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		while(num!=0)
		{
			int four = num % 10;
			if(four == 4) count++;
			num /= 10;
		}
		Console.WriteLine(count);
	}
}
