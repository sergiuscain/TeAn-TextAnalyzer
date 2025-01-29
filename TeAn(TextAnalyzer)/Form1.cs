using TeAn.Processor;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TeAn_TextAnalyzer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var textProcessor = new TextProcessor();
            var text = inputTextBox.Text;
            var uniqueWords = textProcessor.GetUniqueWords(text);
            var resultString = string.Join(Environment.NewLine, uniqueWords.Select(w => $"{w.Original}"));
            outputTextBox.Text = resultString;
        }

        private void convertTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                inputTextBox.Text = File.ReadAllText(filePath);
            }
        }

        private void convertPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                StringBuilder text = new StringBuilder();
                using (PdfReader reader = new PdfReader(filePath))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                }
                inputTextBox.Text = text.ToString();
            }
            else
            {
                inputTextBox.Text = "Ошибка чтения";
            }
        }

        private async void convertAndTranslatebutton_Click(object sender, EventArgs e)
        {
            var textProcessor = new TextProcessor();
            var text = inputTextBox.Text;
            var uniqueWords = textProcessor.GetUniqueWords(text);
            var translateWords = await textProcessor.TranslateAsync(uniqueWords);
            var resultString = string.Join(Environment.NewLine, translateWords.Select(w => $"{w.Original} --> {w.TranslatedText}"));
            outputTextBox.Text = resultString;
        }
    }
}
