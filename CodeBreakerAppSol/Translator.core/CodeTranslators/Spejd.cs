using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.core.Alfabets;

namespace Translator.core.CodeTranslators
{
    class Spejd
    {
        SpejdAlfabet spejd = new SpejdAlfabet();

        Dictionary<char, char> alfabet;
        string result;

        public Spejd() { }

        public string Translate(string inputText, string password, bool danish)
        {
            result = "";

            alfabet = new Dictionary<char, char>();
            alfabet = spejd.GenerateAlfabet(password, danish);

            foreach (char c in inputText)
            {
                if (alfabet.ContainsKey(c))
                {
                    result += alfabet[c];
                }
                else if (alfabet.ContainsValue(c))
                {
                    try
                    {
                        char key = alfabet.FirstOrDefault(x => x.Value == c).Key;
                        result += key;
                    }
                    catch { }
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        public Dictionary<char, char> GetAlfabet(string password, bool danish)
        {
            alfabet = new Dictionary<char, char>();
            alfabet = spejd.GenerateAlfabet(password, danish);
            
            return alfabet;
        }
    }
}
