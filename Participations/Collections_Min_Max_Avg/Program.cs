using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int answer;

            do
            {
                Console.WriteLine("Please enter one of your exam grades.");
                string grade = Convert.ToInt32(Console.ReadLine());

                grades.Add(grade);

                Console.WriteLine("Do you have another exam grade to tell me?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            int min;
            int max;
            int average;

            if (min)
            {

            }

            if (max)
            {

            }

            int average = sum

            Console.ReadKey();
        }
    }
}
