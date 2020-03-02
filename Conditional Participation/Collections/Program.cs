using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string examinput;

            List<double> grades = new List<double>();

            do {
                Console.WriteLine("Input your exam score >>");
                double examS = Convert.ToDouble(Console.ReadLine());


               grades.Add(examS);

                //double max;
                

                Console.WriteLine("Do you have another exam to add? (yes/no)");
                examinput = Console.ReadLine();
            } while (examinput == "yes");
            ;

            double sum = 0;
            double min = grades[0];
            double max = grades[0];

            for (int i = 0; i < grades.Count ; i++)
            {
                double grade = grades[i];
                sum = sum + grade;

                if (grade < min)
                {
                    min = grade;
                }

                if (grade > max)
                {
                    max = grade;
                }
            }
            double average = sum / grades.Count;

            Console.WriteLine($"Your average for the {grades.Count} exam  grade is {average.ToString("N3")}");
            Console.WriteLine($"Your minimum exam  grade is {min.ToString("N3")}");
            Console.WriteLine($"Your maximum exam  grade is {max.ToString("N3")}");

            Console.ReadKey();
        }
    }
}
