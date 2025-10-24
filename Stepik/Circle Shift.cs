using System;

public class Circle_Shift
{
	public static void Circle()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		if (n == 1)
		{
			Console.WriteLine(str[0]);
			return;
		}

		string last = str[n - 1];

		for (int i = n - 1; i > 0; i--)
		{
			str[i] = str[i - 1];
		}

		str[0] = last;

		for (int i = 0; i < n; i++)
		{
			Console.Write(str[i] + " ");
		}
	}
}
