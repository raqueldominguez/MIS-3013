using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grades.");
                double grade = Convert.ToDouble(Console.ReadLine());

                grades.Add(grade);

                Console.WriteLine("Do you have another exam grade to tell me?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            int min = 0;
            int max;

            //grades[0]
            foreach (var grade in grades)
            {
                if (grade == grades[0])
                {

                }

                if (grade == grades[0])
                {

                }
            }


            double average = List.Average();
            Console.WriteLine($"The average is {average}.");

        }   
    }
}
