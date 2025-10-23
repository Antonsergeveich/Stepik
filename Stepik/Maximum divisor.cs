using System;

public class Maximum_divisor
{
	public static void Divisor()
	{
		//int n = Convert.ToInt32(Console.ReadLine());
		//int max_dev = 0;
		//for (int i = 1; i < n; i++)
		//{
		//	if(n % i == 0 && i > max_dev) max_dev = i;
		//}
		//Console.WriteLine(max_dev);

		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = n - 1; i >= 1; i--)
		{
			if (n % i == 0)
			{
				Console.WriteLine(i);
				break;
			}
		}
	}
}
