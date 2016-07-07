using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.core.Alfabets
{
    class AlfaNrAlfabet
    {
        string defaultAlfabet = "";
        Dictionary<string, string> alfabet;

        public AlfaNrAlfabet() { }

        public Dictionary<string, string> GenerateAlfabet(int seed, bool danish)
        {
            alfabet = new Dictionary<string, string>();
            defaultAlfabet = GenerateDefaultAlfabet(danish);

            int count = 0;

            for(int i = seed; i <= defaultAlfabet.Length; i++)
            {
                alfabet.Add(defaultAlfabet[count].ToString(), i.ToString());
                count++;
            }

            for(int i = 1; i<seed; i++)
            {
                alfabet.Add(defaultAlfabet[count].ToString(), i.ToString());
                count++;
            }

            return alfabet;
        }

        private string GenerateDefaultAlfabet(bool danish)
        {
            defaultAlfabet = "abcdefghijklmnopqrstuvwxyz";

            if (danish)
            {
                defaultAlfabet += "æøå";
            }

            return defaultAlfabet;
        }
    }
}
