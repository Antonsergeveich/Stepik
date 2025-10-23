using System;

public class reverse_number
{
	public static void Revers()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		while (num != 0)
		{
			int ost = num % 10;
			Console.Write(ost);
			num /= 10;
		}
	}
}
