using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[4];
            //numbers[0] = 2;
            //numbers[1] = 6;
            //numbers[2] = 3;
            //numbers[3] = 4;

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i].ToString());
            //}

            string[] names = { "Kyle", "Chris", "Nathan", "Karin" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
