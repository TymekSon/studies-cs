using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Konwerter_csv_do_html
{
    class Converter
    {
        public void converterFunction(string csvFilePath, string htmlFilePath)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<title>CSV to HTML</title>");
            html.AppendLine("<style>");
            html.AppendLine("th, td { padding: 8px; text-align: left;}");
            html.AppendLine("tr:nth-child(even) { background-color: #d7d9f0; }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");
            html.AppendLine("<table>");

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                bool isHeader = true;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(';');
                    html.AppendLine("<tr>");

                    foreach (var column in columns)
                    {
                        if (isHeader)
                        {
                            html.AppendLine("<th>" + column + "</th>");
                        }
                        else
                        {
                            html.AppendLine("<td>" + column + "</td>");
                        }
                    }
                    html.AppendLine("</tr>");
                    isHeader = false;
                }
            }
            html.AppendLine("</table>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            File.WriteAllText(htmlFilePath, html.ToString());
            Console.WriteLine("CSV file successfully converted to a HTML file.");
            Console.WriteLine($"Path to HTML file: {htmlFilePath}.");
        }
    }
}
