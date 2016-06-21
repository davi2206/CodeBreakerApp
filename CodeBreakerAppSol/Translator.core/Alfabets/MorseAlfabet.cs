using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.core.Alfabets
{
    public class MorseAlfabet
    {
        public Dictionary<char, string> dicTtoC { get; set; }
        public Dictionary<string, char> dicCtoT { get; set; }

        public MorseAlfabet()
        {
            GenerateAlfabetTtoC();
            GenerateAlfabetCtoT();
        }

        private void GenerateAlfabetTtoC()
        {
            dicTtoC = new Dictionary<char, string>();
            dicTtoC.Add('e', "*");
            dicTtoC.Add('t', "-");
            dicTtoC.Add('i', "**");
            dicTtoC.Add('a', "*-");
            dicTtoC.Add('n', "-*");
            dicTtoC.Add('m', "--");
            dicTtoC.Add('s', "***");
            dicTtoC.Add('u', "**-");
            dicTtoC.Add('r', "*-*");
            dicTtoC.Add('w', "*--");
            dicTtoC.Add('d', "-**");
            dicTtoC.Add('k', "-*-");
            dicTtoC.Add('g', "--*");
            dicTtoC.Add('o', "---");
            dicTtoC.Add('h', "****");
            dicTtoC.Add('v', "***-");
            dicTtoC.Add('f', "**-*");
            dicTtoC.Add('l', "*-**");
            dicTtoC.Add('æ', "*-*-");
            dicTtoC.Add('p', "*--*");
            dicTtoC.Add('j', "*---");
            dicTtoC.Add('b', "-***");
            dicTtoC.Add('x', "-**-");
            dicTtoC.Add('c', "-*-*");
            dicTtoC.Add('y', "-*--");
            dicTtoC.Add('z', "--**");
            dicTtoC.Add('q', "--*-");
            dicTtoC.Add('ø', "---*");

            dicTtoC.Add('0', "-----");
            dicTtoC.Add('1', "*----");
            dicTtoC.Add('2', "**---");
            dicTtoC.Add('3', "***--");
            dicTtoC.Add('4', "****-");
            dicTtoC.Add('5', "*****");
            dicTtoC.Add('6', "-****");
            dicTtoC.Add('7', "--***");
            dicTtoC.Add('8', "---**");
            dicTtoC.Add('9', "----*");
            dicTtoC.Add('å', "*--*-");

            dicTtoC.Add(' ', "");
            dicTtoC.Add('\n', "\n");
        }

        private void GenerateAlfabetCtoT()
        {
            dicCtoT = new Dictionary<string, char>();
            dicCtoT.Add("*", 'e');
            dicCtoT.Add("-", 't');
            dicCtoT.Add("**", 'i');
            dicCtoT.Add("*-", 'a');
            dicCtoT.Add("-*", 'n');
            dicCtoT.Add("--", 'm');
            dicCtoT.Add("***", 's');
            dicCtoT.Add("**-", 'u');
            dicCtoT.Add("*-*", 'r');
            dicCtoT.Add("*--", 'w');
            dicCtoT.Add("-**", 'd');
            dicCtoT.Add("-*-", 'k');
            dicCtoT.Add("--*", 'g');
            dicCtoT.Add("---", 'o');
            dicCtoT.Add("****", 'h');
            dicCtoT.Add("***-", 'v');
            dicCtoT.Add("**-*", 'f');
            dicCtoT.Add("*-**", 'l');
            dicCtoT.Add("*-*-", 'æ');
            dicCtoT.Add("*--*", 'p');
            dicCtoT.Add("*---", 'j');
            dicCtoT.Add("-***", 'b');
            dicCtoT.Add("-**-", 'x');
            dicCtoT.Add("-*-*", 'c');
            dicCtoT.Add("-*--", 'y');
            dicCtoT.Add("--**", 'z');
            dicCtoT.Add("--*-", 'q');
            dicCtoT.Add("---*", 'ø');

            dicCtoT.Add("-----", '0');
            dicCtoT.Add("*----", '1');
            dicCtoT.Add("**---", '2');
            dicCtoT.Add("***--", '3');
            dicCtoT.Add("****-", '4');
            dicCtoT.Add("*****", '5');
            dicCtoT.Add("-****", '6');
            dicCtoT.Add("--***", '7');
            dicCtoT.Add("---**", '8');
            dicCtoT.Add("----*", '9');
        }
    }
}
