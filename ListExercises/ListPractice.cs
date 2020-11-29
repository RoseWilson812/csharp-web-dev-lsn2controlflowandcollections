using System;
using System.Collections.Generic;
namespace ListExercises
{

	public class ListPractice
	{
		public static double SumList(List<double> listNum)
		{
			double sum = 0;
			for (int i = 0; i < listNum.Count; i++)
            {
				if (listNum[i] % 2 == 0)
				sum += listNum[i];
            }
			return sum;
		}
		public static List<string> FindWord(List<string> wordList, int wordLength)
		{
			
			List<string> newWords = new List<string>();
			for (int i = 0; i < wordList.Count; i++)
			{
				if (wordList[i].Length == wordLength)
					newWords.Add(wordList[i]);
			}
			return newWords;
		}
	}
}
