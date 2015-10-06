using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code below retrieves the local date and time.
            //There are lots of methods for retrieving the date and time in different formats.

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());

            Console.ReadLine();

            
        }
    }
}
