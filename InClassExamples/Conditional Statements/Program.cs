using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            string hazardousResponse = "";
            bool containsHazardous = false;

            Console.WriteLine("What is the weight of your shipment, in pounds? >>");
            string response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is the distance of you shipment, in miles? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain hazardous material, yes or no? >>");
            response = Console.ReadLine();

            if (response == "yes")
            {
                containsHazardous = true;
            }
            else if (response == "no")
            {
                containsHazardous = false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT. GOODBYE!");
                return;
            }

            double quote = (0.55 * distance) + (.73 * weight);
            double hazardousCost = 0;

            if (containsHazardous == true)
            {
                hazardousCost = 0.15 * weight;
            }
            else
            {
                hazardousCost = 0;
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;
            if (distance < 150 && weight > 500)
            {
                discount = netTotal * .10;
            }

            double total = netTotal - discount;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quote: " + quote.ToString("c"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hazardous Cost: " + hazardousCost.ToString("c"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Net Total: " + netTotal.ToString("c"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Discount: " + discount.ToString("c"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Total: {total}");

        }
    }
}
