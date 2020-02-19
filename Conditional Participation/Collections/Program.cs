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
                for (int i = 0; i < examS; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Do you have another exam to add? (yes/no)");
                examinput = Console.ReadLine();
            } while (examinput == "yes");
            ;


           
            Console.ReadKey();
        }
    }
}
