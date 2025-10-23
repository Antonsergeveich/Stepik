using System;

public class Speed_control
{
	public static void Control()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int max = Convert.ToInt32(Console.ReadLine()), digit;
		bool more_30 = false;
		if(max < 30) more_30 = true;
		for (int i = 0; i < n - 1; i++)
		{
			digit = Convert.ToInt32(Console.ReadLine());
			if (digit > max) max = digit;
			if (digit < 30) more_30 = true;
		}
		Console.Write(max);
		Console.WriteLine(more_30 ? " YES" : " NO");
	}
}
