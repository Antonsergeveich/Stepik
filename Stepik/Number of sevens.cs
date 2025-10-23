using System;

public class Number_of_sevens
{
	public static void Seven()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		for (int i = 1; i <= n; i++)
		{
			int num = i;
			while(num != 0)
			{
				if(num % 10 == 7) count++;
				num /= 10;	
			}
		}
		Console.WriteLine(count);
	}
}
