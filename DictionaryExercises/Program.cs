using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            
            Dictionary<int, string> studentMaster = new Dictionary<int, string>();
            string newStudent;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    students.Add(newStudent);
                }

            } while (!Equals(newStudent, ""));

            // Get student id
            foreach (string student in students)
            {
                Console.WriteLine("Id for " + student + ": ");
                input = Console.ReadLine();
                int id = int.Parse(input);
                studentMaster.Add(id, student);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<int, string> student in studentMaster)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");

                
            }

           
        }
    }
}
