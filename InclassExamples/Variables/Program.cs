//Arthur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create integer name string firstname
            string firstName;


            //Assign value
            firstName = "Arthur";

            //Create int
            int favoriteNumber = 25;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Kudhlande";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber
               + "\n Which equates to a crazy number of " + crazyNumber);


            Console.ReadKey();

        }
    }
}
