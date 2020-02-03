using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_coin_toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Pick Heads or Tails >>");
            string CointossAs = Console.ReadLine();
            int cointoss = Convert.ToInt32(CointossAs);
            int cointoss;

            Random rand = new Random();
            int randomNumber = 0;
            while (CointossAs != randomNumber)
            {
                int randomNumber = rand.Next(0, 2);
                string outcome = " ";

                if (randomNumber == 0)
                {
                    outcome = "Heads";
                }
                else if (randomNumber == 1)
                {
                    outcome = "Tails";
                }

                if (CointossAs == outcome)
                {
                    Console.WriteLine("Righhtt");
                }
                else if (CointossAs != outcome)
                {
                    Console.WriteLine("Wrong!!");

                }
                else
                {
                    Console.WriteLine("Invalid statement");
                    Console.ReadKey();
                    return;

                }

            }





            const string Name = "Arthur";
            Console.WriteLine(Name);
            Console.ReadKey();
        }






    }
    }
}
