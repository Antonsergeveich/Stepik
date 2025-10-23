using System;
using static System.Console;

public class Homework
{
    public static void Work()
    {
        int days = Convert.ToInt32(Console.ReadLine());
        int tasks_per_day = Convert.ToInt32(Console.ReadLine());

        int res = (int)Math.Ceiling((double) days / tasks_per_day);
        WriteLine(res);
    }
}
