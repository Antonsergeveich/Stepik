using System;

public class The_perfect_number
{
	public static void Number()
	{
		int count = 0;
		for(int n = 2; count < 3; n++)
		{
			int sum = 0;
			for (int i = 1; i <= n / 2; i++)
				if (n % i == 0) sum += i;
			if(sum == n)
			{
				if (count++ > 0) Console.Write(",");
				Console.Write(n);
			} 
		}
	}
}
