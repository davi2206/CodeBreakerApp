using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.core.Alfabets;

namespace Translator.core.CodeTranslators
{
    class Morse
    {
        string inputText;
        string outputText;
        StringBuilder inProgress;
        Dictionary<char, string> dicTtoC = new Dictionary<char, string>();
        Dictionary<string, char> dicCtoT = new Dictionary<string, char>();

        MorseAlfabet ma = new MorseAlfabet();

        public Morse()
        {
            CreateAlfabets();
            inputText = "";
            outputText = "";
        }

        public string TextToCode(string input)
        {
            string currentChar = "";
            inputText = input.ToLower().Trim();

            inProgress = new StringBuilder("//");

            foreach (char c in inputText)
            {
                currentChar = GetMorseOfChar(c);
                currentChar += "/";
                inProgress.Append(currentChar);
            }

            inProgress.Append("/");
            outputText = inProgress.ToString();
            return outputText;
        }

        public string CodeToText(string input)
        {
            inProgress = new StringBuilder();

            inputText = input.Trim('/');

            string[] delimiterOne = { "//" };
            string[] words = inputText.Split(delimiterOne, StringSplitOptions.None);

            foreach (string word in words)
            {
                string[] delimiterTwo = { "/" };
                string[] letters = word.Split(delimiterTwo, StringSplitOptions.None);

                foreach(string letter in letters)
                {
                    inProgress.Append(GetCharOfMorse(letter));
                }
                inProgress.Append(' ');
            }

            outputText = inProgress.ToString();

            return outputText;
        }

        private string GetMorseOfChar(char c)
        {
            string letter = "?";

            try
            {
                letter = dicTtoC[c];
            }
            catch { }

            return letter;
        }

        private char GetCharOfMorse(string letter)
        {
            char res = '?';

            try
            {
                res = dicCtoT[letter];
            }
            catch { }

            return res;
        }

        private void CreateAlfabets()
        {
            dicTtoC = ma.dicTtoC;
            dicCtoT = ma.dicCtoT;
        }
    }
}
