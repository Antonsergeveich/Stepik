using System;

public class Rich_Arthur
{
	public static void Rich()
	{
		int sum = 0;
		for(int i = 0; i < 4; i++) 
		{
			sum += Convert.ToInt32(Console.ReadLine()) * Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(sum);
	}
}
