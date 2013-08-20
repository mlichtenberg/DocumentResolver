namespace DocumentResolverGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoAnalysis = new System.Windows.Forms.Button();
            this.txtCompareText = new System.Windows.Forms.TextBox();
            this.lstMatch = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDictYear = new System.Windows.Forms.CheckBox();
            this.chkDictAuthor = new System.Windows.Forms.CheckBox();
            this.chkDictTitle = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLimitScores = new System.Windows.Forms.TextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectOutputFile = new System.Windows.Forms.Button();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.txtDataFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkListYear = new System.Windows.Forms.CheckBox();
            this.chkListAuthor = new System.Windows.Forms.CheckBox();
            this.chkListTitle = new System.Windows.Forms.CheckBox();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoDocument = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkUseWordStemmer = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoTFIDF = new System.Windows.Forms.RadioButton();
            this.rdoLevenshtein = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoAnalysis
            // 
            this.btnDoAnalysis.Location = new System.Drawing.Point(138, 537);
            this.btnDoAnalysis.Name = "btnDoAnalysis";
            this.btnDoAnalysis.Size = new System.Drawing.Size(157, 33);
            this.btnDoAnalysis.TabIndex = 0;
            this.btnDoAnalysis.Text = "Resolve";
            this.btnDoAnalysis.UseVisualStyleBackColor = true;
            this.btnDoAnalysis.Click += new System.EventHandler(this.btnDoAnalysis_Click);
            // 
            // txtCompareText
            // 
            this.txtCompareText.Location = new System.Drawing.Point(36, 51);
            this.txtCompareText.Name = "txtCompareText";
            this.txtCompareText.Size = new System.Drawing.Size(312, 20);
            this.txtCompareText.TabIndex = 1;
            this.txtCompareText.Text = "New American Sitarine Beetle 1911";
            // 
            // lstMatch
            // 
            this.lstMatch.FormattingEnabled = true;
            this.lstMatch.HorizontalScrollbar = true;
            this.lstMatch.Location = new System.Drawing.Point(27, 25);
            this.lstMatch.Name = "lstMatch";
            this.lstMatch.Size = new System.Drawing.Size(360, 498);
            this.lstMatch.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDictYear);
            this.groupBox1.Controls.Add(this.chkDictAuthor);
            this.groupBox1.Controls.Add(this.chkDictTitle);
            this.groupBox1.Location = new System.Drawing.Point(26, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 51);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dictionary Contents";
            // 
            // chkDictYear
            // 
            this.chkDictYear.AutoSize = true;
            this.chkDictYear.Checked = true;
            this.chkDictYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDictYear.Location = new System.Drawing.Point(155, 22);
            this.chkDictYear.Name = "chkDictYear";
            this.chkDictYear.Size = new System.Drawing.Size(48, 17);
            this.chkDictYear.TabIndex = 5;
            this.chkDictYear.Text = "Year";
            this.chkDictYear.UseVisualStyleBackColor = true;
            // 
            // chkDictAuthor
            // 
            this.chkDictAuthor.AutoSize = true;
            this.chkDictAuthor.Checked = true;
            this.chkDictAuthor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDictAuthor.Location = new System.Drawing.Point(257, 22);
            this.chkDictAuthor.Name = "chkDictAuthor";
            this.chkDictAuthor.Size = new System.Drawing.Size(57, 17);
            this.chkDictAuthor.TabIndex = 4;
            this.chkDictAuthor.Text = "Author";
            this.chkDictAuthor.UseVisualStyleBackColor = true;
            // 
            // chkDictTitle
            // 
            this.chkDictTitle.AutoSize = true;
            this.chkDictTitle.Checked = true;
            this.chkDictTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDictTitle.Enabled = false;
            this.chkDictTitle.Location = new System.Drawing.Point(43, 22);
            this.chkDictTitle.Name = "chkDictTitle";
            this.chkDictTitle.Size = new System.Drawing.Size(46, 17);
            this.chkDictTitle.TabIndex = 3;
            this.chkDictTitle.Text = "Title";
            this.chkDictTitle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMatch);
            this.groupBox2.Location = new System.Drawing.Point(416, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 548);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLimitScores);
            this.groupBox3.Controls.Add(this.lblLimit);
            this.groupBox3.Controls.Add(this.txtNumberOfRows);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnSelectOutputFile);
            this.groupBox3.Controls.Add(this.btnSelectDataFile);
            this.groupBox3.Controls.Add(this.txtDataFile);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtOutputFile);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.rdoList);
            this.groupBox3.Controls.Add(this.rdoDocument);
            this.groupBox3.Controls.Add(this.txtCompareText);
            this.groupBox3.Location = new System.Drawing.Point(24, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 327);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resolve";
            // 
            // txtLimitScores
            // 
            this.txtLimitScores.Enabled = false;
            this.txtLimitScores.Location = new System.Drawing.Point(243, 290);
            this.txtLimitScores.Name = "txtLimitScores";
            this.txtLimitScores.Size = new System.Drawing.Size(37, 20);
            this.txtLimitScores.TabIndex = 13;
            this.txtLimitScores.Text = "0.01";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(33, 293);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(204, 13);
            this.lblLimit.TabIndex = 12;
            this.lblLimit.Text = "Limit to Scores of At Least (min: 0, max: 1)";
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Enabled = false;
            this.txtNumberOfRows.Location = new System.Drawing.Point(205, 209);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.Size = new System.Drawing.Size(50, 20);
            this.txtNumberOfRows.TabIndex = 11;
            this.txtNumberOfRows.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of Data Rows to Resolve";
            // 
            // btnSelectOutputFile
            // 
            this.btnSelectOutputFile.Enabled = false;
            this.btnSelectOutputFile.Location = new System.Drawing.Point(295, 267);
            this.btnSelectOutputFile.Name = "btnSelectOutputFile";
            this.btnSelectOutputFile.Size = new System.Drawing.Size(53, 20);
            this.btnSelectOutputFile.TabIndex = 9;
            this.btnSelectOutputFile.Text = "Select";
            this.btnSelectOutputFile.UseVisualStyleBackColor = true;
            this.btnSelectOutputFile.Click += new System.EventHandler(this.btnSelectOutputFile_Click);
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Enabled = false;
            this.btnSelectDataFile.Location = new System.Drawing.Point(295, 186);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(53, 20);
            this.btnSelectDataFile.TabIndex = 8;
            this.btnSelectDataFile.Text = "Select";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // txtDataFile
            // 
            this.txtDataFile.Enabled = false;
            this.txtDataFile.Location = new System.Drawing.Point(36, 186);
            this.txtDataFile.Name = "txtDataFile";
            this.txtDataFile.Size = new System.Drawing.Size(250, 20);
            this.txtDataFile.TabIndex = 7;
            this.txtDataFile.Text = "DocumentData.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Read Data From";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Enabled = false;
            this.txtOutputFile.Location = new System.Drawing.Point(36, 267);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(250, 20);
            this.txtOutputFile.TabIndex = 5;
            this.txtOutputFile.Text = "ResolutionOutput.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Send Output To";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkListYear);
            this.groupBox4.Controls.Add(this.chkListAuthor);
            this.groupBox4.Controls.Add(this.chkListTitle);
            this.groupBox4.Location = new System.Drawing.Point(36, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contents";
            // 
            // chkListYear
            // 
            this.chkListYear.AutoSize = true;
            this.chkListYear.Checked = true;
            this.chkListYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListYear.Enabled = false;
            this.chkListYear.Location = new System.Drawing.Point(137, 21);
            this.chkListYear.Name = "chkListYear";
            this.chkListYear.Size = new System.Drawing.Size(48, 17);
            this.chkListYear.TabIndex = 2;
            this.chkListYear.Text = "Year";
            this.chkListYear.UseVisualStyleBackColor = true;
            // 
            // chkListAuthor
            // 
            this.chkListAuthor.AutoSize = true;
            this.chkListAuthor.Checked = true;
            this.chkListAuthor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListAuthor.Enabled = false;
            this.chkListAuthor.Location = new System.Drawing.Point(219, 21);
            this.chkListAuthor.Name = "chkListAuthor";
            this.chkListAuthor.Size = new System.Drawing.Size(57, 17);
            this.chkListAuthor.TabIndex = 1;
            this.chkListAuthor.Text = "Author";
            this.chkListAuthor.UseVisualStyleBackColor = true;
            // 
            // chkListTitle
            // 
            this.chkListTitle.AutoSize = true;
            this.chkListTitle.Checked = true;
            this.chkListTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkListTitle.Enabled = false;
            this.chkListTitle.Location = new System.Drawing.Point(44, 21);
            this.chkListTitle.Name = "chkListTitle";
            this.chkListTitle.Size = new System.Drawing.Size(46, 17);
            this.chkListTitle.TabIndex = 0;
            this.chkListTitle.Text = "Title";
            this.chkListTitle.UseVisualStyleBackColor = true;
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(17, 83);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(41, 17);
            this.rdoList.TabIndex = 2;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoDocument
            // 
            this.rdoDocument.AutoSize = true;
            this.rdoDocument.Checked = true;
            this.rdoDocument.Location = new System.Drawing.Point(17, 28);
            this.rdoDocument.Name = "rdoDocument";
            this.rdoDocument.Size = new System.Drawing.Size(74, 17);
            this.rdoDocument.TabIndex = 0;
            this.rdoDocument.TabStop = true;
            this.rdoDocument.Text = "Document";
            this.rdoDocument.UseVisualStyleBackColor = true;
            this.rdoDocument.CheckedChanged += new System.EventHandler(this.rdoDocument_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkUseWordStemmer
            // 
            this.chkUseWordStemmer.AutoSize = true;
            this.chkUseWordStemmer.Checked = true;
            this.chkUseWordStemmer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWordStemmer.Location = new System.Drawing.Point(43, 503);
            this.chkUseWordStemmer.Name = "chkUseWordStemmer";
            this.chkUseWordStemmer.Size = new System.Drawing.Size(205, 17);
            this.chkUseWordStemmer.TabIndex = 19;
            this.chkUseWordStemmer.Text = "Use Word Stemmer During Resolution";
            this.chkUseWordStemmer.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoLevenshtein);
            this.groupBox5.Controls.Add(this.rdoTFIDF);
            this.groupBox5.Location = new System.Drawing.Point(26, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 58);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Engine";
            // 
            // rdoTFIDF
            // 
            this.rdoTFIDF.AutoSize = true;
            this.rdoTFIDF.Checked = true;
            this.rdoTFIDF.Location = new System.Drawing.Point(70, 22);
            this.rdoTFIDF.Name = "rdoTFIDF";
            this.rdoTFIDF.Size = new System.Drawing.Size(93, 17);
            this.rdoTFIDF.TabIndex = 0;
            this.rdoTFIDF.TabStop = true;
            this.rdoTFIDF.Text = "Bayes - TFIDF";
            this.rdoTFIDF.UseVisualStyleBackColor = true;
            this.rdoTFIDF.CheckedChanged += new System.EventHandler(this.rdoTFIDF_CheckedChanged);
            // 
            // rdoLevenshtein
            // 
            this.rdoLevenshtein.AutoSize = true;
            this.rdoLevenshtein.Location = new System.Drawing.Point(185, 22);
            this.rdoLevenshtein.Name = "rdoLevenshtein";
            this.rdoLevenshtein.Size = new System.Drawing.Size(121, 17);
            this.rdoLevenshtein.TabIndex = 1;
            this.rdoLevenshtein.Text = "Bayes - Levenshtein";
            this.rdoLevenshtein.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 586);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chkUseWordStemmer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDoAnalysis);
            this.Name = "Form1";
            this.Text = "Document Resolver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoAnalysis;
        private System.Windows.Forms.TextBox txtCompareText;
        private System.Windows.Forms.ListBox lstMatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDictYear;
        private System.Windows.Forms.CheckBox chkDictAuthor;
        private System.Windows.Forms.CheckBox chkDictTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkListYear;
        private System.Windows.Forms.CheckBox chkListAuthor;
        private System.Windows.Forms.CheckBox chkListTitle;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoDocument;
        private System.Windows.Forms.TextBox txtDataFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectOutputFile;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkUseWordStemmer;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimitScores;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoLevenshtein;
        private System.Windows.Forms.RadioButton rdoTFIDF;
    }
}

