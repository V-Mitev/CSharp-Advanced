using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInformation = Console.ReadLine().Split();

                string studentName = studentInformation[0];
                decimal studentGrade = decimal.Parse(studentInformation[1]);

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<decimal>();
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var name in students)
            {
                Console.Write($"{name.Key} -> ");

                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {name.Value.Average():F2})");
            }
        }
    }
}