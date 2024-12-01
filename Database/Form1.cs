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

namespace Database{
    public partial class Form1 : Form{

        public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.csv");
        public string variablesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "variables.txt");        
        public Form1(){
            InitializeComponent();           
        }

        private void btnSave_Click(object sender, EventArgs e){            
            int counter = 0;
            if (File.Exists(variablesPath)) {
                string content = File.ReadAllText(variablesPath);
                if (int.TryParse(content, out int parsedCounter)) {
                    counter = parsedCounter;
                }
            }
            
            counter++;            

            string name = tbName.Text;
            string surname = tbSurname.Text;
            string birthDate = tbDate.Text;
            string gender = tbGen.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname)){
                MessageBox.Show("Name and Surname are compulsory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gender != "man" && gender != "woman") {
                MessageBox.Show("wrong gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                DateTime.Parse(birthDate);
            }
            catch {
                MessageBox.Show("Wrong date format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = counter.ToString();
            string line = $"{id},{name},{surname},{birthDate},{gender}";

            try{
                using (StreamWriter writer = new StreamWriter(filePath, append: true)){
                    writer.WriteLine(line);
                    MessageBox.Show($"Record written in: {filePath}");
                    tbName.Text = "";
                    tbSurname.Text = "";
                    tbDate.Text = "";
                    tbGen.Text = "";
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error occured during saving: {ex.Message}");

            
            File.WriteAllText(variablesPath, counter.ToString());
            }     
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (!File.Exists(filePath)) {
                return;
            } 

            var lines = File.ReadAllLines(filePath);
            var lastLines = lines.Reverse().Take(10).Select(line => line.Split(','));

            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;

            foreach (var line in lastLines){
                tableLayoutPanel.RowCount ++;
                foreach (var word in line) {
                    tableLayoutPanel.Controls.Add(new Label { Text = word });
                }           
            }
        }

        private void btnDel_Click(object sender, EventArgs e) {
            string idToDelete = tbID.Text;

            if (string.IsNullOrWhiteSpace(idToDelete)) {
                MessageBox.Show("ID number is required for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(filePath)) {
                MessageBox.Show("File doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var updatedLines = lines.Where(line => !line.StartsWith(idToDelete + ",")).ToList();

            if (lines.Length == updatedLines.Count) {
                MessageBox.Show("No record with given ID found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.WriteAllLines(filePath, updatedLines);
            MessageBox.Show($"Removed record with ID: {idToDelete}");
            tbID.Text = "";
        }

        private void btnOpenF_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(filePath);
                
                openFileDialog.Title = "record file";
                openFileDialog.ShowDialog();
            }
        }
 
        private void TableRow_Click(object sender, EventArgs e) {

            if (sender is Label clickedLabel) {

                var row = tableLayoutPanel.GetRow(clickedLabel);

                var name = tableLayoutPanel.GetControlFromPosition(1, row);
                var surname = tableLayoutPanel.GetControlFromPosition(2, row);
                var birthDate = tableLayoutPanel.GetControlFromPosition(3, row);
                var gender = tableLayoutPanel.GetControlFromPosition(4, row);

                tbName.Text = name.ToString();
                tbSurname.Text = surname.ToString();
                tbDate.Text = birthDate.ToString();
                tbGen.Text = gender.ToString();
            }            
        }
    }
}
