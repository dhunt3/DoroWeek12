using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTagsDoro
{
    class HTML
    {
        static void Main(string[] args)
        {
            string fileName = "..\\..\\Problem.txt";


            try
            {

                StreamReader reader = new StreamReader(fileName);
                StreamWriter writer = new StreamWriter("..\\..\\Answer.txt");
                StringBuilder newLine = new StringBuilder();

                using (reader)
                {
                    string line = reader.ReadLine();    // reads first line of the text file called Problem.txt
                    //string answer = "";
                    while (line != null)    // while loop will execute will there are lines in the problem text file
                    {
                        // code to remove tags from the string variable called line.
                        // as a string, I can look for < and > with indexof and then
                        // remove anything in < to > from my line...
                        while (line.Contains('>'))  // while loop will execute while there is a > character in the current line
                        {
                            Console.WriteLine(line);    // To show the current line I am on before chopping it up
                            int i = line.IndexOf('<');  // set i to equal location of <
                            int t = line.IndexOf('>');  // set t to equal location of >
                            Console.WriteLine(i);       // prints the index of <
                            Console.WriteLine(t);       // prints me the index of >
                            line = line.Remove(i, (t - i + 1)); // line will now equal line - <whatever>. 
                            Console.WriteLine(line);              // writes what is in the line now that it chopped off set of <>
                        }
                        if (line != "")     // if the line is not empty/null...
                        {
                            //answer += line;
                            line = line.Trim();     // trim any white space around the line
                            newLine.Append(line);   // convert string line to stringbuilder object newLine
                            newLine.AppendLine();   // add a new line to stringbuilder to move down a line in text
                            line = reader.ReadLine();   // reads the next line of the text file

                        }
                        else
                        {
                            line = reader.ReadLine();   // reads the next line of the text file if current line is empty/null
                        }
                    }
                }

                using (writer)
                {
                    writer.WriteLine(newLine);     // writes whatever is in stringbuilder into the text file called Answers
                }

                Console.ReadLine();
            }


            catch (FileNotFoundException)   // if file Questions.txt doesn't exist, this block will execute and display the 
            // following error
            {
                Console.WriteLine("Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)  // if the directory doesn't exist, this block will execute and display the 
            // following error
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException) // if file Questions.txt is corrupted or something, this block will execute and display the 
            // following error
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
            Console.ReadLine();
        }
    }
}
