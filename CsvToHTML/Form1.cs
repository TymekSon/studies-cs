using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CsvToHTML
{
    public partial class Form1 : Form
    {
        public string converterFunction(string csvFilePath, string htmlFilePath)
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
            return htmlFilePath;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Open a File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbCsv.Text = openFileDialog.FileName;
                    btnConvert.Enabled = true;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select Output Folder";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {                    
                    string folderPath = folderBrowserDialog1.SelectedPath;
                    string htmlFilePath = Path.Combine(folderPath, "output.html");

                    converterFunction(tbCsv.Text, htmlFilePath);
                    tbHtml.Text = htmlFilePath;
                    lblOutput.Text = "Converted succesfully!";
                    btnShowHtml.Enabled = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            tbCsv.Text = "";
            tbHtml.Text = "";
            btnConvert.Enabled = false;
            btnShowHtml.Enabled = false;
        }

        private void btnShowHtml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(tbHtml.Text);               
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "html folder";
                openFileDialog.ShowDialog();
            }
        }   
    }
}