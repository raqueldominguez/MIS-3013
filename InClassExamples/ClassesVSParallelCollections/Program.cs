using System;
using System.Collections.Generic;

namespace ClassesVSParallelCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();
            List<string> dobs = new List<string>();
            List<string> favFoods = new List<string>();
            List<double> accountBalances = new List<double>();

            firstNames.Add("Raquel");
            lastNames.Add("Dominguez");
            dobs.Add("2/14/2000");
            favFoods.Add("Pasta");
            accountBalances.Add(500);

            firstNames.Add("Daniel");
            lastNames.Add("Norman");
            dobs.Add("5/30/2000");
            favFoods.Add("Sushi");
            accountBalances.Add(5000);

            for (int i = 0; i < firstNames.Count; i++)
            {
                Console.WriteLine($"{firstNames[i]} {lastNames[i]} {dobs[i]} likes {favFoods[i]} and has {accountBalances[i].ToString("C")}.");
            }

            //Same but use classes now!!
            Person raquel = new Person();
            raquel.firstName = "Raquel";
            raquel.lastName = "Dominguez";
            raquel.dob = "2/14/2000";
            raquel.favFood = "Pasta";
            raquel.accountBalance = 500;
            //raquel.SetaccountBalance(500);

            Person daniel = new Person("Raquel", "Dominguez", "5/30/2000", "Sushi", 5000);
            Console.WriteLine(raquel.ToString());
            Console.WriteLine(daniel);

            List<Person> peeps = new List<Person>();
            peeps.Add(raquel);
            peeps.Add(daniel);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
