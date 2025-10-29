using System;

public class The_line
{
	public static void Line()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] height = Console.ReadLine().Split();
		int PetyaIsHeight = Convert.ToInt32(Console.ReadLine());
		int[] num = new int[n];
		int PetyaIsPlace = 1;
		for (int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(height[i]);
			if (num[i] >= PetyaIsHeight) PetyaIsPlace++;
			else break;
		}
		Console.WriteLine(PetyaIsPlace);
	}
}
