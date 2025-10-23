using System;

public class Arthur_and_the_numbers
{
	public static void Numbers()
	{
		int k2 = Convert.ToInt32(Console.ReadLine());
		int k3 = Convert.ToInt32(Console.ReadLine());
		int k5 = Convert.ToInt32(Console.ReadLine());
		int k6 = Convert.ToInt32(Console.ReadLine());

		int k256 =  Math.Min(k2, Math.Min(k5,k6));
		k2 -= k256;
		int k32 = Math.Min(k3, k2);
		Console.WriteLine(k256 * 256 + k32 * 32);
	}
}
