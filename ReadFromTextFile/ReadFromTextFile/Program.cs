using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader txtReader = new StreamReader("Info.txt");
            string line = "";

            while (line != null)
            {
                line = txtReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            txtReader.Close();
            Console.ReadLine();
        }
    }
}
