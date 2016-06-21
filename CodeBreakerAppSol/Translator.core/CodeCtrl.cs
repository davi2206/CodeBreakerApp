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

        public CodeCtrl()
        {
            morse = new Morse();
            atok = new AtoK();
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
    }
}
