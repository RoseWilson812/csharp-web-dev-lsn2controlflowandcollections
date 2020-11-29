using System;
namespace ArrayExercises
{
	public class ArrayPractice
	{
		public static void PrintArray()
		{
			int arrayMax = 6;
			double[] array = { 1, 1, 2, 3, 5, 8 };
			foreach (int item in array)
			{
				Console.WriteLine(item);
			}
			for (int i = 0; i < arrayMax; i++)
			{
				if (array[i] % 2 != 0)
				{
					Console.WriteLine(array[i]);
				}
			}

		}
	}
}
