using System;


namespace StringExercises
{

	public class StringPractice
	{
		public static void StringSplit()
		{
			string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
			Console.WriteLine("Orig:" + sentence);
			string[] sentenceArray = sentence.Split(' ');
			Console.WriteLine("split on space:" + string.Join(",", sentenceArray));
			string[] splitArray = sentence.Split('.');
			Console.WriteLine("split on . :" + string.Join(",", splitArray));
		}
	}
}
