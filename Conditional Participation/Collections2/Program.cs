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

            //string together;
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


            //Problem 3
            Dictionary<string, List<double>> values = new Dictionary<string, List<double>>();
            List<double> MIS3013Grades = new List<double>();
            MIS3013Grades.Add(0.85);
            MIS3013Grades.Add(0.65);
            MIS3013Grades.Add(0.95);

            List<double> MIS2113grades = new List<double>();
            MIS2113grades.Add(0.75);
            MIS2113grades.Add(0.85);
            MIS2113grades.Add(0.25);


            List<double> MIS3033grades = new List<double>();
            MIS3033grades.Add(0.45);
            MIS3033grades.Add(0.95);
            MIS3033grades.Add(0.85);


            values.Add(" MIS3013", MIS3013Grades);
            values.Add("MIS2113", MIS2113grades);
            values.Add("MIS3033", MIS3033grades);
            
            Console.ReadKey();
        }
    }
}
