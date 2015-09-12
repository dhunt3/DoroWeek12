using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriterDoro
{
    class FileWriter
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("..\\..\\Answers.txt"); // creates a file called Answers.txt in 2 folders
                                                                           // up from the location (root) of the .exe file
            using (writer)
            {
                writer.WriteLine("Hello World");    // write Hello World in the file
            }

            StreamWriter writer2 = new StreamWriter("..\\..\\Numbers.txt");

            using (writer2)
            {
                for(int i = 1; i <= 20; i++)
                {
                    writer2.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
