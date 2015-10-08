using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program prompts for 2 numerical values
            //Next ask how you would like those numbers to be calculated
            //Then Calulates your values.

            //Get Values of the Calculator
            double value1 = GetValue("Enter Value1: ");
            double value2 = GetValue("Enter Value2: ");


            double result = 0;

            //I chose to use a while loop so the program
            //allows you to try again in case of a mistake

            while (true)
            {
                Console.WriteLine("(A)dd, (M)ultiply, (S)ubtract, (D)ivide");

                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper())
                {
                    case "A":
                        result = Add(value1, value2);
                        break;
                    case "M":
                        result = Multiply(value1, value2);
                        break;
                    case "S":
                        result = Subtract(value1, value2);
                        break;
                    case "D":
                        result = Divide(value1, value2);
                        break;
                    default:
                        Console.WriteLine("Choose find supported operation.");
                        continue;
                }
                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }
        }

        private static double GetValue(string label)
        {
            //the value to be returned
            double value;

            //loop until you get a valid entry.
            while (true)
            {
                Console.WriteLine(label);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Can't parse Value as a number");
                }
            }
        }

        private static double Add(double double1, double double2)
        {
            return double1 + double2;
        }
        private static double Subtract(double double1, double double2)
        {
            return double1 - double2;
        }
        private static double Multiply(double double1, double double2)
        {
            return double1 * double2;
        }
        //I used a little logic here to prevent a bug for when the user types 0.
        private static double Divide(double double1, double double2)
        {
            if (double1 == 0 || double2 == 0)
            {
                return 0;
            }
            else
            {
                return double1 / double2;
            }
        }

    }
}
