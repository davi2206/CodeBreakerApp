using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.core.Alfabets
{
    class SpejdAlfabet
    {
        Dictionary<char, char> alfabet;
        string defaultAlfabet;

        public Dictionary<char, char> GenerateAlfabet(string password, bool danish)
        {
            alfabet = new Dictionary<char, char>();
            defaultAlfabet = DefaultAlfabet(danish);

            string newAlfabet = "";

            int length = 13;
            if (danish)
            {
                length++;
            }
            
            foreach(char c in password)
            {
                newAlfabet += c;
            }

            foreach(char c in defaultAlfabet)
            {
                if(!newAlfabet.Contains(c.ToString()))
                {
                    newAlfabet += c;
                }
            }

            string first = newAlfabet.Substring(0, length);
            string second = newAlfabet.Substring(length + 1);

            for(int i = 0; i < length; i++)
            {
                alfabet.Add(first[i], second[i]);
            }

            return alfabet;
        }

        private string DefaultAlfabet(bool danish)
        {
            string dan = "abcdefghijklmnopqrstuvxyzæøå";
            string notDan = "abcdefghijklmnopqrstuvwxyz";

            if (danish)
            {
                return dan;
            }
            else
            {
                return notDan;
            }
        }
    }
}
