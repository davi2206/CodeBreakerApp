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
        private AlfaNr alfaNr;
        private Chinese chinese;

        public CodeCtrl()
        {
            morse = new Morse();
            atok = new AtoK();
            spejd = new Spejd();
            alfaNr = new AlfaNr();
            chinese = new Chinese();
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

        //SPEJD code
        public string Spejd(string inputText, string password, bool danish)
        {
            string pass = password.ToLower();
            return spejd.Translate(inputText, pass, danish);
        }

        //AlfaNr code
        public string AlfaNr(string input, int seed, bool danish)
        {
            return alfaNr.Translate(input, seed, danish);
        }

        //Chinese text
        public string Chinese(string inputText, bool removeSpaces, bool addSpaces)
        {
            return chinese.Translate(inputText, removeSpaces, addSpaces);
        }




        //Get alfabet, A - K
        public Dictionary<char, char> GetAtoKAlfabet(bool danish, char seed)
        {
            return atok.GetAlfabet(danish, seed);
        }

        //Get alfabet, SPEJD
        public Dictionary<char, char> GetSpejdAlfabet(string password, bool danish)
        {
            string pass = password.ToLower();
            return spejd.GetAlfabet(pass, danish);
        }
    }
}
