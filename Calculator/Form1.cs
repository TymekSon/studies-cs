using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Calculator {
    public partial class Calculator : Form {
        public Calculator() {
            InitializeComponent();
        }

        // Numbers
        private void btnNumber_Click(object sender, EventArgs e) {
            Button button = sender as Button;

            if (button != null) {
                tbHeart.Text = tbHeart.Text + button.Text;
            }
        }

        // Operators
        private void btnOperator_Click(object sender, EventArgs e) {
            Button button = sender as Button;

            if (button != null) {
                tbHeart.Text = tbHeart.Text + button.Text;              
                btnDot.Enabled = true;
            }
        }


        // Dot button
        private void btnDot_Click(object sender, EventArgs e) {
            tbHeart.Text = tbHeart.Text + btnDot.Text;
            btnDot.Enabled = false;
        }


        // Brackets
        private void btnBracket_Click(object sender, EventArgs e) {
            Button button = sender as Button;

            if (button != null) {
                tbHeart.Text = tbHeart.Text + button.Text;
            }
        }

        // Delete button
        private void btnDel_Click(object sender, EventArgs e) {
            if(tbHeart.Text.Length >= 1) {
                tbHeart.Text = tbHeart.Text.Substring(0, tbHeart.Text.Length - 1);
            }           
        }

        // Result button
        private void btnResult_Click(object sender, EventArgs e) {
            if(tbHeart.Text.Length >= 1) {
                string userInput = tbHeart.Text.Replace(',', '.');
                try {
                    Expression expression = new Expression(userInput);
                    var result = expression.Evaluate();
                    tbHeart.Text = result.ToString().Replace(',', '.');
                }
                catch (Exception ex) {
                    MessageBox.Show($"Błąd w wyrażeniu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        //private void enter_KeyPress(object sender, KeyEventArgs e) {
            //if(e.KeyCode == Keys.Enter)
            //{
                
            //}
       // }
    }
}
