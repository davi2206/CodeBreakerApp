using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.core.Alfabets
{
    class AtoKAlfabet
    {
        string alfabet = "";
        string encodedAlfabet = "";
        Dictionary<char, char> alfabetTable;

        public AtoKAlfabet() { }

        public Dictionary<char, char> CreateAlfabet(bool danish, char seed)
        {
            alfabetTable = new Dictionary<char, char>();
            alfabet = DefaultAlfabet(danish);

            int seedIndex = alfabet.IndexOf(seed);

            string partOne;
            string partTwo;

            try
            {
                partOne = alfabet.Substring(0, seedIndex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                partTwo = alfabet.Substring(seedIndex, (alfabet.Length - seedIndex));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            encodedAlfabet = partTwo + partOne;

            alfabet += alfabet.ToUpper();
            encodedAlfabet += encodedAlfabet.ToUpper();

            for (int i = 0; i < alfabet.Length; i++)
            {
                alfabetTable.Add(alfabet[i], encodedAlfabet[i]);
            }

            return alfabetTable;
        }

        private string DefaultAlfabet(bool danish)
        {
            string alf = "abcdefghijklmnopqrstuvwxyz";

            if (danish)
            {
                alf += "æøå";
            }

            return alf;
        }
    }
}
