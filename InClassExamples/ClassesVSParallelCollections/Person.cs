using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesVSParallelCollections
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dob { get; set; }
        public string favFood { get; set; }
        public double accountBalance { get; set; }

        //private double accountBalance;

        //public void SetaccountBalance (double val)
        //{
        //    accountBalance = val;
        //}

        //public Double GetaccountBalance();
        //{
        //    return accountBalance;
        //}

        public Person()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            dob = string.Empty;
            favFood = string.Empty;
            accountBalance = 0;
        }

        public Person(string fName, string lName, string birth, string food, double bal)
        {
            firstName = fName;
            lastName = lName;
            dob = birth;
            favFood = food;
            accountBalance = bal;
        }

        public override string ToString()
        {
            string output = $"{firstName} {lastName} {dob} likes {favFood} and has {accountBalance.ToString("C")}.";
                return output;
        }
    }
}
