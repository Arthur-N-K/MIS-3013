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
            string firstName = "Arthur";
            string lastname = "Kudhlande";


           Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your firstname");
           Console.WriteLine($"You have {lastname.Length.ToString("N0")} characters in your lastname");

            char firstinitial = firstName[0];
            char lastinitial = lastname[0];


          //  Console.WriteLine(firstName.ToUpper()[0]);
          //  Console.WriteLine(firstName.ToUpper()[1]);
          //  Console.WriteLine(firstName.ToUpper()[2]);
          //  Console.WriteLine(firstName.ToUpper()[3]);
          //  Console.WriteLine(firstName.ToUpper()[4]);
          //  Console.WriteLine(firstName.ToUpper()[5]);

            firstName = firstName.ToUpper();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                char currentLetter = firstName[i];
                Console.WriteLine(currentLetter);
            }

            string Lname = lastname.Substring(0, lastname.Length);

            for (int i = 0; i < firstName.Length; i++)
            {
                char currentLetter = firstName[i];
                Console.Write(currentLetter);
            }

            foreach (char currentLetter in firstName)
            {
                Console.WriteLine(currentLetter);
            }


                Console.WriteLine($"Your intials are {firstinitial}.{lastinitial}");

            Console.ReadKey();
        }
    }
}
