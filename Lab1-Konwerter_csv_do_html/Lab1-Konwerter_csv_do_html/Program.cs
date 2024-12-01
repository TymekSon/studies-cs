using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Konwerter_csv_do_html
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = @"I:\Programming\files\csvfile.csv";
            string htmlFilePath = @"I:\Programming\files\htmlfile.html";

            try
            {
                Converter convertToHTML = new Converter();
                convertToHTML.converterFunction(csvFilePath, htmlFilePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: The file '{csvFilePath}' was not found.");
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: You do not have permission to access one or more of the files.");
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: There was a problem accessing the file.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: The format of the CSV file is incorrect.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
