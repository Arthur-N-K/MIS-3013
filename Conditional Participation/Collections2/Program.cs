using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Coursenumbers = new string[3];
            string[] Coursenames = new string [3];
           

           

            for (int i = 0; i < Coursenames.Length; i++)
            {
                Console.WriteLine("Input your subject name");
                Coursenames[i] = Console.ReadLine();
            }



            for (int i = 0; i < Coursenumbers.Length; i++)
            {
                Console.WriteLine(" Input your course number");
                Coursenumbers[i] = Console.ReadLine();
                
            }

            for (int i = 0; i < Coursenumbers.Length; i++)
            {
                Console.WriteLine($" Your course is {Coursenames[i].ToUpper()} {Coursenumbers[i].ToUpper()}");
            }


            //Problem 2
            List<double> grades = new List<double>();

            string examinput;

            do
            {
                Console.WriteLine("Input your exam score >>");
                double examS = Convert.ToDouble(Console.ReadLine());


                grades.Add(examS);

                //double max;


                Console.WriteLine("Do you have another exam to add? (yes/no)");
                examinput = Console.ReadLine();
            } while (examinput == "yes");
            

            double sum = 0;
           

            for (int i = 0; i < grades.Count; i++)
            {
                double grade = grades[i];
                sum = sum + grade;
               
                }
            
            double average = sum / grades.Count;

            Console.WriteLine($"Your average for the {grades.Count} exam  grade is {average.ToString("N3")}");




            Console.ReadKey();
        }
    }
}
