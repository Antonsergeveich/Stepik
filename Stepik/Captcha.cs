using System;

public class Captcha
{
	public static void Cap()
	{
		int[,] num = new int[3, 3];
		for (int i = 0; i < 3; i++)
		{
			string[] str = Console.ReadLine().Split();
			for (int j = 0; j < 3; j++)
			{
				num[i, j] = int.Parse(str[j]);
			}
		}
		int element = Convert.ToInt32(Console.ReadLine());
		int attempts = Convert.ToInt32(Console.ReadLine());
		bool res = true;
		while (attempts > 0)
		{
			string[] arr = Console.ReadLine().Split();
			int n = Convert.ToInt32(arr[0]);
			int m = Convert.ToInt32(arr[1]);
			if (num[n, m] != element)
			{
				res = false;
				break;
			}
			attempts--;
		}
		Console.WriteLine(res ? "Captcha успешно пройдена" : "Вы не человек");
	}
}
