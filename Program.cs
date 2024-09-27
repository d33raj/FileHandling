using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Used whenever we are dealing with the Files and File related operations

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fPath1 = @"C:\Users\pc\MonoDotnet\sample.txt"; ---->used to create new files bades on path we give to store it along with extension of file type
            //File.Create(fPath1);                                  ----> Create() method is used to create a new file if you doesnot have any existing one in the directory

            //string fPath2 = @"C:\Users\pc\MonoDotnet\sample.xml";
            //File.Create(fPath2);

            //string fPath3 = @"C:\Users\pc\MonoDotnet\sample.html";
            //File.Create(fPath3);

            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();

            string filePath = @"C:\Users\pc\MonoDotnet\usernames.txt";

            if (File.Exists(filePath) && File.ReadAllText(filePath).Contains(username)) // If condition first cjecks for file existance and later reads all the content in it and we are finding the input username in the content
                                                                                           // if it already exists then we need not create new one then code steps into else block
            {
                Console.WriteLine("Username already exists in the file.");
            }
            else
            {
                File.AppendAllText(filePath, username + Environment.NewLine);  // Here we use ApeendAllText() method which takes file path + content as parameters to the function.
                                                                               // We used Environment.NewLine to bring cursor to the new line after every execution
                Console.WriteLine("Username saved to file.");
            }



            CaseStudy_ReadTextFile();
            CaseStudy_ReadXMLFile();
            CaseStudy_ReadHTMLFile();


            CaseStudy_WriteTextFile();
            CaseStudy_WriteXMLFile();
            CaseStudy_WriteHTMLFile();

        }

        static void CaseStudy_ReadTextFile()
        {
            string filePath = @"C:\Users\pc\MonoDotnet\sample.txt";    // Giving path to the file to read content from it
            if (File.Exists(filePath))                                //Exists() Method will check for the file present at the desired location which we give as path to it
            {
                string content = File.ReadAllText(filePath);         //ReadAllText() method reads the content from the file given by user and to access or print info in it we store it in a string variable
                Console.WriteLine("\n=========================================");
                Console.WriteLine("Text file content:");
                Console.WriteLine(content);                         // printing the content present in the string variable or the file content
            }
            else
            {
                Console.WriteLine("Text file not found.");         // If file doesnot found as per Exists() method we print file not found
            }
        }

        static void CaseStudy_ReadXMLFile()
        {
            string xmlFilePath = @"C:\Users\pc\MonoDotnet\sample.xml";  // here we are using @ to avoid the confusion between escape sequencw characters and file path
            if (File.Exists(xmlFilePath))
            {
                string xmlContent = File.ReadAllText(xmlFilePath);
                Console.WriteLine("=========================================");
                Console.WriteLine("\nContents of XML file:\n" + xmlContent);
            }
            else
            {
                Console.WriteLine("XML file not found.");
            }
        }

        static void CaseStudy_ReadHTMLFile()
        {
            string filePath = @"C:\Users\pc\MonoDotnet\sample.html";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("=========================================");
                Console.WriteLine("\nHTML file content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("HTML file not found.");
            }
        }

        static void CaseStudy_WriteTextFile()
        {
            string textFilePath = @"C:\Users\pc\Desktop\FileOutputs\output.txt";                   // Specifies the location of the file to be created / existing file
            string[] textContent = { "This is text content.", "Another line of text content." };  // Here we used string array as we want to create multiple lines in the file or else we can also use
                                                                                                  // directlly WriteAllText() method for single line inputs to the file
            File.WriteAllLines(textFilePath, textContent);                                        // WriteAllLines() is used to write multiple lines into a file
            Console.WriteLine("Text content written to file.");
        }
        public static void CaseStudy_WriteXMLFile()
        {
            string xmlFilePath = @"C:\Users\pc\Desktop\FileOutputs\output.xml";
            string[] xmlContent = { "<data>This is XML content.</data>", "<data>Another line of XML content.</data>" };
            File.WriteAllLines(xmlFilePath, xmlContent);
            Console.WriteLine("XML content written to file.");
        }
        static void CaseStudy_WriteHTMLFile()
        {
            string htmlFilePath = @"C:\Users\pc\Desktop\FileOutputs\output.html";
            string[] htmlContent = { "<html><body><h1>This is HTML content.</h1></body></html>", "<p>Another line of HTML content.</p>" };
            File.WriteAllLines(htmlFilePath, htmlContent);
            Console.WriteLine("HTML content written to file.");
        }

    }
}
