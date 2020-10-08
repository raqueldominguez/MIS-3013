using System;
using System.Collections.Generic;

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

            double min = 0;
            double max;

            foreach (var grade in grades)
            {
                while (grade > min)
                {
                    if (grade < grades[0])
                    {
                        min = grade;
                    }
                }              
            }

            Console.WriteLine($"Your minimum grade is {min}.");


            //    if (grade > grades[0])
            //    {
            //        max = grade;
            //    }
            //    else
            //    {
            //        max = grade;
            //    }
            //Console.WriteLine($"Your maximum grade is {max}.");

            //double average = List.Count();
            //Console.WriteLine($"The average is {average}.");

            // max >= grade);


            Console.ReadKey();
            }
        }
    }

