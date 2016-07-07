using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.core.Alfabets;

namespace Translator.core.CodeTranslators
{
    class AlfaNr
    {
        AlfaNrAlfabet ana = new AlfaNrAlfabet();
        Dictionary<string, string> alfabet;

        public AlfaNr() { }

        public string Translate(string inputText, int seed, bool danish)
        {
            alfabet = new Dictionary<string, string>();
            string result = "";

            string[] input = inputText.Split(' ');

            alfabet = ana.GenerateAlfabet(seed, danish);

            foreach(string s in input)
            {
                if (alfabet.ContainsKey(s))
                {
                    result += alfabet[s];
                }
                else if (alfabet.ContainsValue(s))
                {
                    string key = alfabet.FirstOrDefault(x => x.Value.Equals(s)).Key;
                    result += key;
                }
                else
                {
                    foreach (char c in s)
                    {
                        string val = "-1";
                        try
                        {
                            val = c.ToString();
                        }
                        catch { }

                        if (alfabet.ContainsKey(c.ToString()))
                        {
                            result += alfabet[c.ToString()];
                        }
                        else if (alfabet.ContainsValue(val))
                        {
                            string key = alfabet.FirstOrDefault(x => x.Value.Equals(val)).Key;
                            result += key;
                        }
                        else
                        {
                            result += c;
                        }
                        result += " ";
                    }
                }
                result += " - ";
            }

            return result;
        }
    }
}
