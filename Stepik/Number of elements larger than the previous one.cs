using System;

public class Number_of_elements_larger_than_the_previous_one
{
	public static void ElementCount()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split(' ');
		int count = 0;
		for (int i = 1; i < n; i++)
		{
			int buf = Convert.ToInt32(str[i-1]);
			int num = Convert.ToInt32(str[i]);
			if (num > buf) count++;
		}
		Console.WriteLine(count);
	}
}
