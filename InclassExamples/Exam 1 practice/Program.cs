using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Input your word or your phrase");
            string userword = Console.ReadLine();
            int index = userword.Length;

            for (int i = userword.Length -1; i >= 0; i--)
            {
                string newword = userword[i];
                Console.WriteLine(newword);

                do
                {
                    Console.WriteLine("Your phrase is a palindrome!!");
                } while (userword[0] == newword[0]);
            }


            Console.ReadKey();
        }
    }
}
