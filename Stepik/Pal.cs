using System;
public class Pal
{
	public static void Yes()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();

		int[] num = new int[n];
		for (int i = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}
		bool palindrome = true;
		for (int i = 0; i < n / 2; i++)
		{
			if (num[i] != num[n - 1 - i])
			{
				palindrome = false;
				break;
			}
		}
		Console.WriteLine(palindrome ? "YES" : "NO");
	}
}

