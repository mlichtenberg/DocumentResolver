using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MWL.DocumentResolver;

namespace DocumentResolverGUI
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> _dictionary = new Dictionary<string,string>();
        Dictionary<int, string> _input = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoAnalysis_Click(object sender, EventArgs e)
        {
            lstMatch.Items.Clear();

            // Load the dictionary data
            LoadDictionaryData(chkDictTitle.Checked, chkDictAuthor.Checked, chkDictYear.Checked);

            if (rdoDocument.Checked)
            {
                ResolveDocument();
            }
            else
            {
                ResolveList();
                MessageBox.Show("Done");
            }
        }

        private void ResolveDocument()
        {
            try
            {
                List<ResolutionResult> results = new List<ResolutionResult>();

                // Evaluate the string against all of the data entries
                DocumentResolver resolver = new DocumentResolver(_dictionary);
                SetEngine(resolver);
                results = resolver.Resolve(txtCompareText.Text, chkUseWordStemmer.Checked);

                // Output the results
                double minScore = 0.01;
                if (rdoLevenshtein.Checked) minScore = 0;
                var filteredResults = (from result in results where result.Score >= minScore select result);

                // Display the results
                foreach (ResolutionResult result in filteredResults)
                {
                    string output = string.Format("{0} - ID {1} - {2}", result.Score.ToString(),
                            result.Key.ToString(),
                            result.Document);

                    lstMatch.Items.Add(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
            }
        }

        private void ResolveList()
        {
            try
            {
                // Get the data from the input file
                LoadInputData(chkListTitle.Checked, chkListAuthor.Checked, chkListYear.Checked);

                // Determine how many input rows to process
                int maxToProcess = (Convert.ToInt32(txtNumberOfRows.Text) > _input.Count) ? _input.Count : Convert.ToInt32(txtNumberOfRows.Text);

                // Prepare the output file
                System.IO.File.Delete(txtOutputFile.Text);
                System.IO.File.AppendAllText(txtOutputFile.Text, string.Format("Starting Resolution of {0} documents at {1}\r\n\r\n",
                    txtNumberOfRows.Text,
                    DateTime.Now.ToString()));
                System.IO.File.AppendAllText(txtOutputFile.Text, string.Empty);
                System.IO.File.AppendAllText(txtOutputFile.Text, string.Empty);

                // Initialize an instance of the resolver
                DocumentResolver resolver = new DocumentResolver(_dictionary);
                SetEngine(resolver);

                int i = 1;
                foreach (KeyValuePair<int, string> kvp in _input)
                {
                    // Done if we've processed the specified number of rows
                    if (i > maxToProcess) break;

                    // Evaluate each input string against the dictionary
                    List<ResolutionResult> results = resolver.Resolve(kvp.Value, chkUseWordStemmer.Checked);

                    // Output the results
                    IEnumerable<ResolutionResult> filteredResults;
                    if (rdoTFIDF.Checked)
                        filteredResults = (from result in results where result.Score >= double.Parse(txtLimitScores.Text) select result);
                    else
                        filteredResults = (from result in results where result.Score <= double.Parse(txtLimitScores.Text) select result);

                    // Display the results
                    List<string> output = new List<string>();
                    output.Add(string.Format("Document - {0}: {1}", kvp.Key.ToString(), kvp.Value));
                    output.Add(string.Empty);

                    foreach (ResolutionResult result in filteredResults)
                    {
                        string resultDetail = string.Format("Score {0} - ID {1}: {2}",
                            result.Score.ToString(),
                            result.Key.ToString(),
                            result.Document);

                        output.Add(resultDetail);
                    }

                    output.Add(string.Empty);
                    output.Add(string.Empty);

                    System.IO.File.AppendAllLines(txtOutputFile.Text, output);

                    i++;
                }

                // Write final entry to output file
                System.IO.File.AppendAllText(txtOutputFile.Text, string.Format("Completed Resolution of {0} documents at {1}",
                    txtNumberOfRows.Text,
                    DateTime.Now.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
            }
        }

        private void SetEngine(DocumentResolver resolver)
        {
            if (rdoTFIDF.Checked) resolver.SetEngine(DocumentResolver.EngineType.BayesTFIDF);
            if (rdoLevenshtein.Checked) resolver.SetEngine(DocumentResolver.EngineType.BayesLevenshtein);
        }

        private void LoadInputData(bool includeTitle, bool includeAuthor, bool includeYear)
        {
            _input.Clear();
            string[] documents = System.IO.File.ReadAllLines(txtDataFile.Text);
            for (int i = 1; i < documents.Length; i++)
            {
                string[] docInfo = documents[i].Split('\t');
                string content = string.Empty;

                if (includeTitle && includeAuthor && includeYear)
                    content = string.Format("{0} {1} {2}", docInfo[1], docInfo[2], docInfo[3].Replace(" | ", " "));
                if (includeTitle && includeAuthor && !includeYear)
                    content = string.Format("{0} {1}", docInfo[1], docInfo[3].Replace(" | ", " "));
                if (includeTitle && !includeAuthor && includeYear)
                    content = string.Format("{0} {1}", docInfo[1], docInfo[2]);
                if (includeTitle && !includeAuthor && !includeYear)
                    content = docInfo[1];

                _input.Add(Convert.ToInt32(docInfo[0]), content);
            }
        }

        private void LoadDictionaryData(bool includeTitle, bool includeAuthor, bool includeYear)
        {
            _dictionary.Clear();
            string[] documents = System.IO.File.ReadAllLines(@"DictionaryData5000.txt");
            for (int i = 1; i < documents.Length; i++)
                {
                string[] docInfo = documents[i].Split('\t');
                string content = string.Empty;

                if (includeTitle && includeAuthor && includeYear)
                    content = string.Format("{0} {1} {2}", docInfo[1], docInfo[2], docInfo[3].Replace(" | ", " "));
                if (includeTitle && includeAuthor && !includeYear)
                    content = string.Format("{0} {1}", docInfo[1], docInfo[3].Replace(" | ", " "));
                if (includeTitle && !includeAuthor && includeYear)
                    content = string.Format("{0} {1}", docInfo[1], docInfo[2]);
                if (includeTitle && !includeAuthor && !includeYear)
                    content = docInfo[1];

                _dictionary.Add(docInfo[0], content);
            }
        }

        private void rdoDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDocument.Checked)
            {
                txtCompareText.Enabled = true;
                chkListAuthor.Enabled = false;
                chkListYear.Enabled = false;
                txtDataFile.Enabled = false;
                btnSelectDataFile.Enabled = false;
                txtNumberOfRows.Enabled = false;
                txtOutputFile.Enabled = false;
                btnSelectOutputFile.Enabled = false;
                txtLimitScores.Enabled = false;
            }
        }

        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoList.Checked)
            {
                txtCompareText.Enabled = false;
                chkListAuthor.Enabled = true;
                chkListYear.Enabled = true;
                txtDataFile.Enabled = true;
                btnSelectDataFile.Enabled = true;
                txtNumberOfRows.Enabled = true;
                txtOutputFile.Enabled = true;
                btnSelectOutputFile.Enabled = true;
                txtLimitScores.Enabled = true;
            }
        }

        private void btnSelectDataFile_Click(object sender, EventArgs e)
        {
            SelectFile(txtDataFile);
        }

        private void btnSelectOutputFile_Click(object sender, EventArgs e)
        {
            SelectFile(txtOutputFile);
        }

        private void SelectFile(TextBox textBox)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog().ToString() == "OK")
            {
                textBox.Text = openFileDialog1.FileName;
            }
        }

        private void rdoTFIDF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTFIDF.Checked)
            {
                lblLimit.Text = "Limit to Scores of At Least (min: 0, max: 1)";
                txtLimitScores.Text = "0.01";
            }
            else
            {
                lblLimit.Text = "Limit to Scores of At Most (minimum: 0)";
                txtLimitScores.Text = "50";
            }
        }
    }
}
