using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manupilation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s1 = ("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning ");
            Console.WriteLine(s1);

            Console.WriteLine("What word would you want to look for? ");
            string s2 = Console.ReadLine();
            bool message = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                s2, s1, message);

            if (s1.Contains(s2))
            {
                Console.WriteLine($"Your word is...{s2}");

                Console.WriteLine(" What word would you want to change? ");
                string wordchange = Console.ReadLine();

                Console.WriteLine(s1.Replace(wordchange, s2));

            }

            else {
                Console.WriteLine($"Sorry i could not find your word {s2}");
            }

            


            Console.ReadKey();
        }
    }
}
