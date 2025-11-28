using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhanikyanDK.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                return string.Empty;

            string text = File.ReadAllText(path);

            // Разделяем текст на слова (разделители: пробелы, табы, переносы строк, знаки препинания)
            char[] separators = new char[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '"', '\'' };
            var words = text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

            // Фильтруем слова, содержащие букву 'E' (регистрозависимо)
            var filteredWords = words.Where(w => w.Contains('E'));

            return string.Join(" ", filteredWords);
        }
    }
}