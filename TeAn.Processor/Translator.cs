using Newtonsoft.Json.Linq;
using TeAn.Processor.Models;

namespace TeAn.Processor
{
    public class Translator
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<Word> TranslateAsync(Word word, string targetLang = "ru")
        {
            try
            {
                // Формируем URL для запроса к MyMemory API
                string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(word.Original)}&langpair=en|ru";

                // Выполняем GET-запрос
                var response = await client.GetStringAsync(url);

                // Парсим JSON-ответ
                var json = JObject.Parse(response);
                word.TranslatedText = json["responseData"]["translatedText"].ToString();
            }
            catch (Exception ex)
            {
                word.TranslatedText = $"Ошибка перевода: {ex.Message}";
            }

            return word;
        }
    }
}
