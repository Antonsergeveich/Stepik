using System;

public class _5_and_7
{
	public static void Excep()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int mul = 1;
		int res = 0;
		while (num > 0)
		{
			int digit = num % 10;
			if(digit != 5 && digit != 7)
			{
				res = digit * mul + res;
				mul *= 10;	
			}
			num /= 10;
		}
		Console.WriteLine(res);
	}
}
