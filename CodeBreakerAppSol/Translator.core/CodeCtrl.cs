using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.core.CodeTranslators;

namespace Translator.core
{
    public class CodeCtrl
    {
        private Morse morse;
        private AtoK atok;
        private Spejd spejd;

        public CodeCtrl()
        {
            morse = new Morse();
            atok = new AtoK();
            spejd = new Spejd();
        }

        //Morse code
        public string MorseTtoC(string inputText)
        {
            return morse.TextToCode(inputText);
        }

        public string MorseCtoT(string inputCode)
        {
            return morse.CodeToText(inputCode);
        }

        //A to K code
        public string AtoK(string inputText, bool danish, bool fromText, char seed)
        {
            return atok.Translate(inputText, danish, fromText, seed);
        }

        public string Spejd(string inputText, string password, bool danish)
        {
            return spejd.Translate(inputText, password, danish);
        }

        public Dictionary<char, char> GetAtoKAlfabet(bool danish, char seed)
        {
            return atok.GetAlfabet(danish, seed);
        }
    }
}
