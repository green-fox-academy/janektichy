using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAPI.ApiObjects
{
    public class SithTextGenerator
    {
        public string Text { get; set; }
        public string Sith_text { get; set; }
        public List<string> RandomSentences { get; set; }
        public string Error { get; set; }
        public SithTextGenerator()
        {
            RandomSentences = new List<string>() { "Arrgh", "Uhmm", "Err..err.err", "Kuřecí péro" };
        }
        public string GenerateSithText(string originalText)
        {
            string[] sentences = originalText.Split(". ");
            string[] sentencesWithSwitchedWords = new string[sentences.Length];
            for (int i = 0; i < sentences.Length; i++)
            {
                string[] original = sentences[i].Split(' ');
                string[] sithSentence = new string[original.Length];
                int limit;
                if (original.Length%2 == 0)
                {
                    limit = original.Length;
                }
                else
                {
                    limit = original.Length - 1;
                    sithSentence[original.Length - 1] = original[original.Length - 1];
                }
                for (int j = 0; j < limit; j+=2)
                {
                    sithSentence[j] = original[j + 1];
                    sithSentence[j + 1] = original[j];
                }
                sentencesWithSwitchedWords[i] = String.Join(' ', sithSentence);
                sentencesWithSwitchedWords[i] = ChangeUpperLetters(sentencesWithSwitchedWords[i]);
            }
            string result = String.Join(". ", sentencesWithSwitchedWords);
            result = AppendRandom(result);
            return result;
        }
        public string ChangeUpperLetters(string input)
        {
            char[] toLetters = input.ToCharArray();
            toLetters[0] = Char.ToUpper(toLetters[0]);
            for (int i = 1; i < toLetters.Length; i++)
            {
                toLetters[i] = Char.ToLower(toLetters[i]);
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < toLetters.Length; i++)
            {
                builder.Append(toLetters[i]);
            }
            return builder.ToString();
        }
        public string AppendRandom(string text)
        {
            List<string> textToList = text.Split(". ").ToList();
            Random random = new Random();
            for (int i = 1; i < textToList.Count+1; i++)
            {
                int index = random.Next(1, 3);
                for (int j = 0; j < index; j++)
                {
                    textToList.Insert(i, RandomSentences[random.Next(0, RandomSentences.Count)]);
                    i++;
                }
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < textToList.Count; i++)
            {
                builder.Append(textToList[i] + ". ");
            }
            return builder.ToString();
        }
    }
}
