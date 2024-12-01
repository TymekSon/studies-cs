
namespace Database
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGen = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbRecords = new System.Windows.Forms.GroupBox();
            this.btnOpenF = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(23, 114);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(48, 15);
            this.lblGen.TabIndex = 1;
            this.lblGen.Text = "Gender:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Birth date:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(23, 56);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(57, 15);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(90, 25);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "your name";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(90, 53);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PlaceholderText = "your surname";
            this.tbSurname.Size = new System.Drawing.Size(100, 23);
            this.tbSurname.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(21, 237);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 9;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(145, 28);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGen);
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblGen);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(61, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 189);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a new record";
            // 
            // tbGen
            // 
            this.tbGen.FormattingEnabled = true;
            this.tbGen.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.tbGen.Location = new System.Drawing.Point(90, 111);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(100, 23);
            this.tbGen.TabIndex = 14;
            // 
            // tbDate
            // 
            this.tbDate.ForeColor = System.Drawing.Color.Black;
            this.tbDate.Location = new System.Drawing.Point(90, 83);
            this.tbDate.Name = "tbDate";
            this.tbDate.PlaceholderText = "year/month/day";
            this.tbDate.Size = new System.Drawing.Size(100, 23);
            this.tbDate.TabIndex = 18;
            this.tbDate.Tag = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Location = new System.Drawing.Point(61, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete the record";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(90, 29);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(50, 23);
            this.tbID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Record ID:";
            // 
            // gbRecords
            // 
            this.gbRecords.Controls.Add(this.btnOpenF);
            this.gbRecords.Controls.Add(this.tableLayoutPanel);
            this.gbRecords.Controls.Add(this.btnRef);
            this.gbRecords.Location = new System.Drawing.Point(320, 32);
            this.gbRecords.Name = "gbRecords";
            this.gbRecords.Size = new System.Drawing.Size(432, 273);
            this.gbRecords.TabIndex = 13;
            this.gbRecords.TabStop = false;
            this.gbRecords.Text = "Latest records:";
            // 
            // btnOpenF
            // 
            this.btnOpenF.Location = new System.Drawing.Point(108, 237);
            this.btnOpenF.Name = "btnOpenF";
            this.btnOpenF.Size = new System.Drawing.Size(126, 23);
            this.btnOpenF.TabIndex = 11;
            this.btnOpenF.Text = "Open record file";
            this.btnOpenF.UseVisualStyleBackColor = true;
            this.btnOpenF.Click += new System.EventHandler(this.btnOpenF_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AllowDrop = true;
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.54745F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.45255F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tableLayoutPanel.Location = new System.Drawing.Point(21, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(391, 203);
            this.tableLayoutPanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.gbRecords);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbRecords;
        private System.Windows.Forms.Button btnOpenF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ComboBox tbGen;
    }
}

