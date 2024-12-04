using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFrequency
{
    public partial class WordFrequency : Form
    {
        // Change: Declare the wordFrequencies dictionary at the class level
        private Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        public WordFrequency()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select a text file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a Text File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBox_FileName.Text = openFileDialog.FileName;
                ProcessFile(openFileDialog.FileName);
            }
        }

        private void ProcessFile(string filePath)
        {
            try
            {
                // Read the file contents
                string text = File.ReadAllText(filePath);

                // Split text into words using common delimiters
                var words = text.Split(new[] { ' ', '\r', '\n', ',', '.', '!', '?', ';', ':', '-', '_', '"' },
                                        StringSplitOptions.RemoveEmptyEntries);

                // Clear the existing dictionary
                wordFrequencies.Clear();

                // Count the frequency of each word
                foreach (var word in words)
                {
                    string lowerWord = word.ToLower();
                    if (wordFrequencies.ContainsKey(lowerWord))
                    {
                        wordFrequencies[lowerWord]++;
                    }
                    else
                    {
                        wordFrequencies[lowerWord] = 1;
                    }
                }

                MessageBox.Show("File processed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            // Display word frequencies in the ListBox
            lstBox_Frequencies.Items.Clear();
            foreach (var entry in wordFrequencies.OrderByDescending(entry => entry.Value))
            {
                lstBox_Frequencies.Items.Add($"{entry.Key}: {entry.Value}");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to select the output file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save Word Frequencies"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var entry in wordFrequencies.OrderByDescending(entry => entry.Value))
                        {
                            writer.WriteLine($"{entry.Key}: {entry.Value}");
                        }
                    }
                    MessageBox.Show("Word frequencies saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}");
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
