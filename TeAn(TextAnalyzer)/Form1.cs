using TeAn.Processor;

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
            var translateWords = textProcessor.Translate(uniqueWords);
            var resultString = string.Join(Environment.NewLine, translateWords.Select(w => $"{w.English} --> {w.Russian}"));
            outputTextBox.Text = resultString;
        }
    }
}
