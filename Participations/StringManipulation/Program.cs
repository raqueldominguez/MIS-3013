using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            const string s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(s1);
            
            Console.WriteLine(">>What word do you want to look for in the above sentence?");
            string word = Console.ReadLine();

            Console.WriteLine($"What word do you want to change {word} to?");
            string word2 = Console.ReadLine();

            bool containWord = s1.Contains(word);

            if (containWord == true)
            {
                string s2 = s1.Replace(word, word2);
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {word2}");

                for (int i = word.Length -1; i >= 0; i--)
                {
                    Console.WriteLine(word[i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
