using System;

public class Zeros
{
	public static void Number_zero()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			if(Convert.ToInt32(Console.ReadLine()) == 0)
			{
				Console.WriteLine("YES"); return;
			}
		}
		Console.WriteLine("NO");
	}
}
