﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            int val1;
            int val2;
            string ans;

            List<int> values = new List<int>();
            


            do
            {
                Console.WriteLine("What type of calculation do you wat to perform (Addition, subtraction)>>");
                string answer = Console.ReadLine();

                int add;
                int subtract;
                int multi;
                int divide;

                if (answer.ToLower() == "addition")
                {
                    Console.WriteLine("What first numbers do you wanna add?");
                    val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What second numbers do you wanna add?");
                    val2 = Convert.ToInt32(Console.ReadLine());
                    add = Add(val1, val2);
                    Console.WriteLine($"Your answer is {add} ");
                }

                else if (answer.ToLower() == "subtraction")
                {
                    Console.WriteLine("What first numbers do you wanna subtract?");
                    val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What second numbers do you wanna subtract?");
                    val2 = Convert.ToInt32(Console.ReadLine());

                    subtract = Subtraction(val1, val2);
                    Console.WriteLine($"Your answer is {subtract} ");
                }

                else if (answer.ToLower() == "multiplication")
                {
                    Console.WriteLine("What first numbers do you wanna multiply?");
                    val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What second numbers do you wanna multiply?");
                    val2 = Convert.ToInt32(Console.ReadLine());

                    multi = Multiplication(val1, val2);
                    Console.WriteLine($"Your answer is {multi} ");
                }

                else if (answer.ToLower() == "division")
                {
                    
                    Console.WriteLine("What first numbers do you wanna divide?");
                    val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What second numbers do you wanna divide?");
                    val2 = Convert.ToInt32(Console.ReadLine());

                    divide = Division(val1, val2);
                    Console.WriteLine($"Your answer is {divide} ");
                }


                Console.WriteLine("Do another calculation?");
                ans = Console.ReadLine();

            } while (ans.ToLower() == "y");

            Console.WriteLine("Thank You for using my application");

            




            Console.ReadKey();
        }

        static int Division(int val1, int val2)
        {
            return val1 / val2;
        }

        static int Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }

        static int Subtraction(int val1, int val2)
        {
            return val1 - val2;
        }

        static int Add(int val1, int val2)
        {
            return val1 + val2;
        }
        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}");
        }
        private static void Main2(string[] args)
        {
            DeveloperInformation("Arthur K", "MIS-3013", "03/08/2020");
            Console.ReadKey();
        }
    



    }
}
