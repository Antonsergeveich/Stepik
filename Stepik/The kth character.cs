using System;

public class The_kth_character
{
	public static void Character()
	{
		string str = Console.ReadLine();
		int k = Convert.ToInt32(Console.ReadLine());
		if (k > str.Length)
		{
			Console.WriteLine("NO");
		}
        else
        {
			Console.WriteLine(str[k - 1]);
        }
    }
}
