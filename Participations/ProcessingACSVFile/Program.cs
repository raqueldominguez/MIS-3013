﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\raxdo\OneDrive\Documents\sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);


            //
            /*
             * Sales = 4
             * Status = 6
             * Month = 8
             * Year = 9
             */

            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year =="2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }

                    sum += sale;
                }
                
            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C2")}.");

            Console.WriteLine($"Total sales if {sum.ToString("C2")}.");

            Console.ReadKey();
        }
    }
}
