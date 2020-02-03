using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number do you want to count to?>>");
            int threshold = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= threshold; i++)
            {
                Console.Write(i + " ");

            }

            double sum = 0;
            string answer;
            Console.WriteLine();

            do
            {
                Console.WriteLine("Please give a number to add>>");
                double number = Convert.ToInt32(Console.ReadLine());
                sum += number;

                Console.WriteLine("Another number? (y/n) >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() =="y");

            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}");
            Console.ReadKey();



        }
    }
}
