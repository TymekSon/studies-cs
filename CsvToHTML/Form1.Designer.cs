
namespace CsvToHTML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCsv = new System.Windows.Forms.TextBox();
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSelectCsv = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbCsv = new System.Windows.Forms.GroupBox();
            this.gbHtml = new System.Windows.Forms.GroupBox();
            this.btnShowHtml = new System.Windows.Forms.Button();
            this.browseHtml = new System.Windows.Forms.FolderBrowserDialog();
            this.gbCsv.SuspendLayout();
            this.gbHtml.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCsv
            // 
            this.tbCsv.Location = new System.Drawing.Point(15, 20);
            this.tbCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCsv.Name = "tbCsv";
            this.tbCsv.Size = new System.Drawing.Size(412, 23);
            this.tbCsv.TabIndex = 0;
            // 
            // tbHtml
            // 
            this.tbHtml.Location = new System.Drawing.Point(15, 20);
            this.tbHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.Size = new System.Drawing.Size(412, 23);
            this.tbHtml.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(93, 119);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(167, 39);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSelectCsv
            // 
            this.btnSelectCsv.Location = new System.Drawing.Point(431, 20);
            this.btnSelectCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCsv.Name = "btnSelectCsv";
            this.btnSelectCsv.Size = new System.Drawing.Size(94, 22);
            this.btnSelectCsv.TabIndex = 5;
            this.btnSelectCsv.Text = "Select file";
            this.btnSelectCsv.UseVisualStyleBackColor = true;
            this.btnSelectCsv.Click += new System.EventHandler(this.btnSelectCsv_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(186, 172);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(175, 26);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "...";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(287, 119);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbCsv
            // 
            this.gbCsv.Controls.Add(this.tbCsv);
            this.gbCsv.Controls.Add(this.btnSelectCsv);
            this.gbCsv.Location = new System.Drawing.Point(10, 28);
            this.gbCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCsv.Name = "gbCsv";
            this.gbCsv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCsv.Size = new System.Drawing.Size(540, 50);
            this.gbCsv.TabIndex = 8;
            this.gbCsv.TabStop = false;
            this.gbCsv.Text = "CSV filepath:";
            // 
            // gbHtml
            // 
            this.gbHtml.Controls.Add(this.btnShowHtml);
            this.gbHtml.Controls.Add(this.tbHtml);
            this.gbHtml.Location = new System.Drawing.Point(10, 214);
            this.gbHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHtml.Name = "gbHtml";
            this.gbHtml.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHtml.Size = new System.Drawing.Size(540, 50);
            this.gbHtml.TabIndex = 9;
            this.gbHtml.TabStop = false;
            this.gbHtml.Text = "HTML filepath:";
            // 
            // btnShowHtml
            // 
            this.btnShowHtml.Enabled = false;
            this.btnShowHtml.Location = new System.Drawing.Point(431, 20);
            this.btnShowHtml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowHtml.Name = "btnShowHtml";
            this.btnShowHtml.Size = new System.Drawing.Size(94, 22);
            this.btnShowHtml.TabIndex = 2;
            this.btnShowHtml.Text = "Open folder";
            this.btnShowHtml.UseVisualStyleBackColor = true;
            this.btnShowHtml.Click += new System.EventHandler(this.btnShowHtml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.gbHtml);
            this.Controls.Add(this.gbCsv);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCsv.ResumeLayout(false);
            this.gbCsv.PerformLayout();
            this.gbHtml.ResumeLayout(false);
            this.gbHtml.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCsv;
        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSelectCsv;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbCsv;
        private System.Windows.Forms.GroupBox gbHtml;
        private System.Windows.Forms.Button btnShowHtml;
        private System.Windows.Forms.FolderBrowserDialog browseHtml;
    }
}

