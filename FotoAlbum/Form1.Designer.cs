
namespace FotoAlbum
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
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbStartPath = new System.Windows.Forms.TextBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnStart);
            this.gbInput.Controls.Add(this.tbStartPath);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(612, 69);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Start folder";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(470, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Choose a folder";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbStartPath
            // 
            this.tbStartPath.Location = new System.Drawing.Point(6, 26);
            this.tbStartPath.Name = "tbStartPath";
            this.tbStartPath.Size = new System.Drawing.Size(458, 27);
            this.tbStartPath.TabIndex = 0;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnOutput);
            this.gbOutput.Controls.Add(this.tbOutputPath);
            this.gbOutput.Location = new System.Drawing.Point(12, 87);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(612, 69);
            this.gbOutput.TabIndex = 2;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output folder";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(470, 25);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(136, 29);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Choose a folder";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(6, 26);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.Size = new System.Drawing.Size(458, 27);
            this.tbOutputPath.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(190, 177);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(232, 47);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create an album";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbStartPath;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
    }
}

