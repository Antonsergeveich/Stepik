using System;

public class PhotosOfTimur
{
	public static void Photos()
	{
		string[] str = Console.ReadLine().Split();
		int rows = Convert.ToInt32(str[0]);
		int cols = Convert.ToInt32(str[1]);

		bool color = false;
		for (int i = 0; i < rows; i++)
		{
			string[] rowPixel = Console.ReadLine().Split();
			for (int j = 0; j < cols; j++)
			{
				char pixel = rowPixel[j][0];
				if(pixel == 'C' || pixel == 'M' || pixel == 'Y')
				{
					color = true;
					break;
				}
			}
			if (color) break;
		}
		Console.WriteLine(color ? "#Color" : "#Black&White");
	}
}
