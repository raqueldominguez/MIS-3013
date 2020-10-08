using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grade.");
                double grade = Convert.ToDouble(Console.ReadLine());

                grades.Add(grade);

                Console.WriteLine("Do you have another exam grade to tell me?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            double min = grades[0];
            double max = grades[0];

            foreach (var grade in grades)
            {
                while (grade < min)
                { 
                    if (grade < min)
                    {
                        min = grade;
                    }
                    Console.WriteLine($"Your minimum grade is {min}.");
                }
            }

            foreach (var grade in grades)
            {
                while (grade > max)
                {
                    if (grade > max)
                    {
                        max = grade;
                    }
                    Console.WriteLine($"Your maximum grade is {max}.");
                }
            }

            double average = grades.Sum() / grades.Count();
            Console.WriteLine($"The average is {average}.");


            Console.ReadKey();
            }
        }
    }

