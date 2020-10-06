using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\raxdo\OneDrive\Documents\sales_data_sample.csv";
            string filePath = @"sales_data_sample.csv";

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

            double monthsum = 0;
            double sumForJan = 0;
            double sumForFeb = 0;
            double sumForMar = 0;
            double sumForApr = 0;
            double sumForMay = 0;
            double sumForJun = 0;
            double sumForJul = 0;
            double sumForAug = 0;
            double sumForSep = 0;
            double sumForOct = 0;
            double sumForNov = 0;
            double sumForDec = 0;


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                double monthSales = Convert.ToDouble(pieces[4]);
                
                string year = pieces[9];
                string month = pieces[8];

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


                    if (month == "1")
                    {
                        sumForJan += monthSales;
                    }
                    else if (month == "2")
                    {
                        sumForFeb += monthSales;
                    }
                    else if (month == "3")
                    {
                        sumForMar += monthSales;
                    }
                    else if (month == "4")
                    {
                        sumForApr += monthSales;
                    }
                    else if (month == "5")
                    {
                        sumForMay += monthSales;
                    }
                    else if (month == "6")
                    {
                        sumForJun += monthSales;
                    }
                    else if (month == "7")
                    {
                        sumForJul += monthSales;
                    }
                    else if (month == "8")
                    {
                        sumForAug += monthSales;
                    }
                    else if (month == "9")
                    {
                        sumForSep += monthSales;
                    }
                    else if (month == "10")
                    {
                        sumForOct += monthSales;
                    }
                    else if (month == "11")
                    {
                        sumForNov += monthSales;
                    }
                    else if (month == "12")
                    {
                        sumForDec += monthSales;
                    }

                    sum += sale;
                    monthsum += monthSales;
                }
                
            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C2")}.");

            Console.WriteLine($"The total sales for shipped items in January is {sumForJan.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in February is {sumForFeb.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in March is {sumForMar.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in April is {sumForApr.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in May is {sumForMay.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in June is {sumForJun.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in July is {sumForJul.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in August is {sumForAug.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in September is {sumForSep.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in October is {sumForOct.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in November is {sumForNov.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped items in December is {sumForDec.ToString("C2")}.");

            //Console.WriteLine($"Total sales of shipped items is {sum.ToString("C2")}.");

            Console.ReadKey();
        }
    }
}
