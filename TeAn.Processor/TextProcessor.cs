using System.Text.RegularExpressions;
using PorterStemmer;
using PorterStemmer.Stemmers;
using TeAn.Processor.Models;

namespace TeAn.Processor
{
    public class TextProcessor
    {
        // Метод для разбиения текста на уникальные слова корневой формы.
        public List<Word> GetUniqueWords(string text)
        {
            // Удаляем знаки препинания и приводим текст к нижнему регистру
            //  [^\w\s  --  регулярное выражение, которое определяет, что именно нужно заменить.
            string cleanedText = Regex.Replace(text, @"[^\w\s]", "").ToLower();

            // Разбиваем текст на слова
            string[] words = cleanedText.Split(new char[] {' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Используем HashSet для хранения уникальных корневых слов
            HashSet<string> uniqueBaseWords = new HashSet<string>();
            // Создаем экземпляр стеммера, который приводит слова к корневой форме
            var stemmer = new EnglishStemmer();
            foreach (string word in words)
            {
                string rootWord = stemmer.GetStem(word);
                uniqueBaseWords.Add(rootWord);
            }
            //Возвращаем список уникальных английских слов в виде листа Word
            List<Word> result = uniqueBaseWords.Select(word => new Word { Original = word}).ToList();
            return result;
        }
        public async Task<IEnumerable<Word>> TranslateAsync(IEnumerable<Word> words)
        {
            var tranlater = new Translator();
            var translatedWords = new List<Word>();
            foreach (Word word in words)
            {
                translatedWords.Add(await tranlater.TranslateAsync(word));
            }
            return translatedWords;
        }
    }
} 
