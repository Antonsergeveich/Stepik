using System;

public class Arthur_and_Friends_2
{
	public static void Friends()
	{
		int bappy = Convert.ToInt32(Console.ReadLine());
		bool seven = false;
		bool zero = false;
		int count = 1;
		while (bappy != 0)
		{
			if (bappy % 10 == 7) seven = true;
			else if (bappy % 10 == 0) zero = true;
			count++;
			bappy /= 10;
		}
		if (seven == true && zero == false && count >= 5)
		{
			Console.WriteLine("YES");
		}
		else
		{
			Console.WriteLine("NO");
		}
	}
}
