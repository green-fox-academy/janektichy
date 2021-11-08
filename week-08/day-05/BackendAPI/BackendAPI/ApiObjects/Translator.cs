using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAPI.ApiObjects
{
    public class Translator
    {
        public string Text { get; set; }
        public string Lang { get; set; }
        public string Translated { get; set; }
        public char[] Souhlasky { get; set; }
        public Translator()
        {
            Souhlasky = new char[]{ 'a', 'e', 'i', 'o', 'u', 'y' };
        }
        public string TranslateFromHungarian(string text)
        {
            string[] lines = text.Split(". ");
            string[] translatedText = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');
                string[] translatedSentence = new string[words.Length];
                for (int j = 0; j < words.Length; j++)
                {
                    string translatedWord = "";
                    char[] original = words[j].ToCharArray();
                    StringBuilder builder = new StringBuilder();
                    for (int k = 0; k < original.Length; k++)
                    {
                        builder.Append(original[k]);
                        if (Souhlasky.Contains(Char.ToLower(original[k])))
                        {
                            builder.Append($"v{Char.ToLower(original[k])}");
                        }
                        translatedWord = builder.ToString();
                    }
                    translatedSentence[j] = translatedWord;
                }
                translatedText[i] = String.Join(' ', translatedSentence);
            }
            
            return String.Join(". ", translatedText);
        }
    }
}
