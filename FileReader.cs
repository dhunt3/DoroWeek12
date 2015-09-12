using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDoro
{
    class FileReader
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Sample.txt"); // add file to the StreamReader object called reader

            using (reader)
            {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line); //Console.WriteLine("Line " + lineNumber + ": " + line)";
                    line = reader.ReadLine();
                }
                // reader.Close(); - the using statement using(reader) automatically closes the stream so no need for Close();
            }
                Console.ReadLine();
        }
    }
}
