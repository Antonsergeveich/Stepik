using System;

public class Arthur_and_a_trip_to_the_store
{
	public static void Store()
	{
		int d1 = Convert.ToInt32(Console.ReadLine());
		int d2 = Convert.ToInt32(Console.ReadLine());
		int d3 = Convert.ToInt32(Console.ReadLine());

		int way1 = d1 + d1 + d2 + d2;
		int way2 = d1 + d3 + d2;
		int way3 = d1 + d3 + d3 + d1;
		int way4 = d2 + d3 + d3 + d2;
		int res = Math.Min(Math.Min(way1, way2),Math.Min(way3,way4));
		Console.WriteLine(res);
	}
}
