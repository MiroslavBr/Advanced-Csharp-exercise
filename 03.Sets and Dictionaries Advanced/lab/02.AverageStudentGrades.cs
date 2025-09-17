using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents= int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsRecord = new(); 
            //the best thing to do is to make class grade and there to calculate average.

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                double grade = double.Parse(data[1]);

                if (!studentsRecord.ContainsKey(name))
                {
                    studentsRecord.Add(name, new List<double>());
                }
                studentsRecord[name].Add(grade);
            }

            foreach ((string student, List<double> grade) in studentsRecord)
            {
                string grades = string.Empty;
                foreach (double g in grade)
                {
                    grades += $"{g:f2} ";
                }

                Console.WriteLine($"{student} -> {grades}(avg: {grade.Average():f2})");
            } 
        }
    }
}
