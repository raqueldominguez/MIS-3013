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
                Console.WriteLine("Please enter one of your exam grades.");
                string grade = Convert.ToDouble(Console.ReadLine());

                grades.Add(grade);

                Console.WriteLine("Do you have another exam grade to tell me?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            int min;
            int max;
            int average;

            foreach (var grade in grades)
            {
                if (min == grades[0])
                {

                }

                if (max)
                {

                }
            }
            

            int average =


        }   
    }
}
