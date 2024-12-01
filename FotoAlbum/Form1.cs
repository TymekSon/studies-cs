using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoAlbum
{
    public partial class Form1 : Form
    {
        public static void ProcessDirectory(string sourceDir, string targetDir)
        {
            foreach (string filePath in Directory.GetFiles(sourceDir, "*.jpg"))
            {
                string fileName = Path.GetFileName(filePath);
                DateTime creationDate = File.GetCreationTime(filePath);
                string formattedDate = creationDate.ToString("yyyyMMddHHmmss");
                string folderName = new DirectoryInfo(sourceDir).Name;
                string newFileName = $"{formattedDate}_{folderName}_{fileName}";
                string destinationPath = Path.Combine(targetDir, newFileName);

                File.Copy(filePath, destinationPath);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                ProcessDirectory(subDir, targetDir);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                { 
                    tbStartPath.Text = dialog.SelectedPath;
                    if (tbStartPath.Text != "" && tbOutputPath.Text != "")
                    {
                        btnCreate.Enabled = true;
                    }
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tbOutputPath.Text = dialog.SelectedPath;
                    if (tbStartPath.Text != "" && tbOutputPath.Text != "")
                    {
                        btnCreate.Enabled = true;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            string sourceDir = tbStartPath.Text;
            string targetDir = tbOutputPath.Text;

            string newOutputFolder = Path.Combine(targetDir, "Photo_Album_"+DateTime.Now.ToString("yyyyMMddHHmmss"));
            Directory.CreateDirectory(newOutputFolder);

            ProcessDirectory(sourceDir, newOutputFolder);
            label1.Text = "Succesfully created a photo album!";
        }
    }
}
