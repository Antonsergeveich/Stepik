using System;

public class Number_of_zeros
{
	public static void Zeros()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		for(int i = 0; i < n; i++)
		{
			int num = Convert.ToInt32(Console.ReadLine());
			if(num == 0) count++;
		}
		Console.WriteLine(count);
	}
}
