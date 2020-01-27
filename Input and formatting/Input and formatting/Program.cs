//Arhtur Kudhlande
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_formatting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter First name >>");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter Favourite Number");
            int favnumber = Convert.ToInt32(Console.ReadLine());

            int favnumbertimes10 = 10 * favnumber;

            string message = firstName + " you have favourite number of " + favnumber.ToString("N3") + " and if you multiply by 10 you get " + favnumbertimes10.ToString("C3");

            if (favnumber == 7|| favnumber == 5)
            {
                Console.WriteLine("How original are you");
            }

            else if (favnumber == 13)
            {
                Console.WriteLine("Thats unlucky");
            
            }
            else
            { Console.WriteLine(message);

            }

            Console.WriteLine(message);


            switch (favnumber)
            {
                case 3:
                case 7: Console.WriteLine("How original are you");
                    break;
                case 13: Console.WriteLine("Thats unlucky");
                    break;
                default:
                    Console.WriteLine(message);
                        break;

            }

            if (favnumber % 2 == 0)
            {

                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();



        }
    }
}
