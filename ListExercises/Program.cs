using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numberList = new List<double> { 1, 2, 8, 2, 5, 3, 6, 3, 1, 7 };
            Console.WriteLine(ListPractice.SumList(numberList));
            List<string> words = new List<string> { "a", "at", "cab", "poop", "seven", "eight", "bedtime", "cabrides", "goladders", "10letters" };
            string input;
            
            Console.WriteLine("Enter a word length:");
            
            input = Console.ReadLine();
            int inputWordLength = int.Parse(input);
            List<string> selectedWords = ListPractice.FindWord(words, inputWordLength);
            for (int i = 0; i < selectedWords.Count; i++)
            {
                Console.WriteLine(selectedWords[i]);
            }
            // bonus convert string to List
            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> result = sentence.Split('.').ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
