using System;

public class Unique_elements
{
	public static void Unique()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] str = Console.ReadLine().Split();
		int[] num = new int[n];
		for(int i  = 0; i < n; i++)
		{
			num[i] = Convert.ToInt32(str[i]);
		}

		for(int i = 0; i < n; i++)
		{
			bool unique = true;
			for(int j = 0; j < n; j++)
			{
				if(i != j && num[i] == num[j])
				{
					unique = false;
					break;
				}
			}
			if (unique) Console.Write(str[i] + " ");
		}
	}
}
