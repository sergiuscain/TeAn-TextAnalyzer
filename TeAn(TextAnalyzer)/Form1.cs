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
            outputTextBox.Text = string.Join(", ", uniqueWords);
        }
    }
}
