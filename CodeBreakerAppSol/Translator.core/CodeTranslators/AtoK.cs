using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.core.Alfabets;

namespace Translator.core.CodeTranslators
{
    class AtoK
    {
        Dictionary<char, char> alfabet;
        Dictionary<char, char> invAlfabet;
        AtoKAlfabet ak = new AtoKAlfabet();
        string result;

        public AtoK() { }

        public string Translate(string input, bool danish, bool fromText, char seed)
        {
            alfabet = new Dictionary<char, char>();
            invAlfabet = new Dictionary<char, char>();

            result = "";
            alfabet = ak.CreateAlfabet(danish, seed);
            invAlfabet = CreateInvAlfabet(alfabet);

            if(fromText)
            {
                foreach (char c in input)
                {
                    if (alfabet.ContainsKey(c))
                    {
                        result += alfabet[c];
                    }
                    else
                    {
                        result += c;
                    }
                }
            }
            else
            {
                foreach (char c in input)
                {
                    if (alfabet.ContainsKey(c))
                    {
                        result += invAlfabet[c];
                    }
                    else
                    {
                        result += c;
                    }
                }
            }
            
            return result;
        }

        private Dictionary<char, char> CreateInvAlfabet(Dictionary<char, char> alf)
        {
            Dictionary<char, char> workingAlfabet = new Dictionary<char, char>();

            foreach(KeyValuePair<char, char> pair in alf)
            {
                workingAlfabet.Add(pair.Value, pair.Key);
            }

            return workingAlfabet;
        }
    }
}
