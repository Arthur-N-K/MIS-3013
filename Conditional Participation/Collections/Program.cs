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
            string exam;

            do
            {
                Console.WriteLine("Input your exam score >>");
                double examS = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Do you have another exam to add? (yes/no)");
                exam = Console.ReadLine();
            } while (exam == "yes");



            Console.ReadKey();
        }
    }
}
