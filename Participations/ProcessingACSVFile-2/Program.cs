using System;
using System.IO;

namespace ProcessingACSVFile_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            /*
             * date = 0
             * name = 4
             * payment = 3
             * place = 7
             */

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string name = pieces[4];
                string date = pieces[0];

                string payment = pieces[3];
                string place = pieces[7];

                if (pieces[3].Trim().ToLower() == "visa" && pieces[7].Trim().ToLower() == "united states")
                {
                    Console.WriteLine($"{name} {date}");
                }
            }

            Console.ReadKey();
        }
    }
}
