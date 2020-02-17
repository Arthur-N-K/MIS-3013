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

            int[] studentID = new int[3];
            string[] studentnames = {"Bro", "Fire", "Derkin"};

            studentID[0] = 1;
            studentID[1] = 2;
            studentID[2] = 3;
            //studentID[3] = 4;

           
            for (int i = 0; i < studentID.Length; i++)
            {
                Console.WriteLine($"Student with ID {studentID[i]} has a name of {studentnames[i]}");
            }

            List<int> studID = new List<int>();
            studID.Add(4);
            studID.Add(5);
            studID.Add(6);
            List<string> studNames = new List<string>();
            studNames.Add("Dude");
            studNames.Add("Mate");
            studNames.Add("Friend");

            for (int i = 0; i < studID.Count; i++)
            {
                Console.WriteLine($"Student with ID {studID[i]} has a name of {studNames[i]}");
            }

            Dictionary<int, string> Students = new Dictionary<int, string>();

            for (int i = 0; i < studentID.Length; i++)
            {
                if (Students.ContainsKey(studentID[i]) == false)
                {
                    
                }

                if (Students.ContainsKey(studID[i]) == false)
                {
                    Students.Add(studID[i], studNames[i]);
                }
                
            }
            Console.WriteLine("Cooool");
            Console.WriteLine($" The dictionary has {Students.Count()} students");

            Console.ReadKey();
        }
    }
}
