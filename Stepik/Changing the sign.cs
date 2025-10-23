using System;

public class Changing_the_sign
{
	public static void Sing()
	{
		int prev = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		int num;
		while ((num = Convert.ToInt32(Console.ReadLine())) != 0)
		{
			if(prev * num < 0)count++;
			prev = num;	
		}
		Console.WriteLine(count);
	}
}
