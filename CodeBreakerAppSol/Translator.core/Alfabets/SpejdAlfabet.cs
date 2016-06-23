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
            alfabet.Clear();
            defaultAlfabet = DefaultAlfabet(danish);

            string newAlfabet = "";

            int length = (defaultAlfabet.Length / 2);

            foreach (char c in password)
            {
                newAlfabet += c;
            }

            foreach (char c in defaultAlfabet)
            {
                if (!newAlfabet.Contains(c.ToString()))
                {
                    newAlfabet += c;
                }
            }

            string first = newAlfabet.Substring(0, length);
            string second = newAlfabet.Substring(length);

            for (int i = 0; i < length; i++)
            {
                alfabet.Add(first[i], second[i]);
            }

            alfabet = AddCapsToAlfabet(alfabet);

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

        private Dictionary<char, char> AddCapsToAlfabet(Dictionary<char, char> alfabet)
        {
            Dictionary<char, char> alfabetCaps = new Dictionary<char, char>();
            alfabetCaps.Clear();

            foreach(KeyValuePair<char, char> kv in alfabet)
            {
                alfabetCaps.Add(kv.Key, kv.Value);
            }

            foreach (KeyValuePair<char, char> kvx in alfabet)
            {
                string ks = kvx.Key.ToString();
                ks = ks.ToUpper();
                char k = ks[0];

                string vs = kvx.Value.ToString();
                vs = vs.ToUpper();
                char v = vs[0];

                alfabetCaps.Add(k, v);
            }

            return alfabetCaps;
        }
    }
}
