using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPathsDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader file = new StreamReader("..\\..\\test.txt");
            string fileName = "..\\..\\test.txt";
            StreamReader reader = new StreamReader(fileName);

            string myLine = reader.ReadLine();

            Console.WriteLine(myLine);

            reader.Close();
            Console.ReadLine();
        }
    }
}
