using System;
using static System.Console;
public class The_next_one_is_even
{
	public static void Next()
	{
		int num = Convert.ToInt32(ReadLine());
		WriteLine((num+1)%2==0?(num+1):(num+2));
	}
}
