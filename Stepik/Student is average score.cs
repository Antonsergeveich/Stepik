using System;

public class Student_is_average_score
{
	public static void Score()
	{
		int number_of_exams = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		for(int i = 0; i < number_of_exams; i++)
		{
			sum+= Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine((double)sum/number_of_exams);
	}
}
