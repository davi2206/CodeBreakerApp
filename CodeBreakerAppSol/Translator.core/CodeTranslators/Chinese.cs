using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.core.CodeTranslators
{
    class Chinese
    {
        public int Rand { get; set; }

        public string Translate(string inputText, bool removeSpaces, bool addSpaces)
        {
            string result = inputText;

            if(removeSpaces)
            {
                result = result.Replace(" ", "");
            }

            result = Flip(result);

            string newResult = result;

            if(addSpaces)
            {
                newResult = "";

                Random random = new Random();

                int i = 0;
                foreach(char c in result)
                {
                    Rand = random.Next(5);

                    if (Rand == 0)
                    {
                        newResult += " ";
                    }

                    newResult += result[i];
                    i++;
                }
            }

            return newResult;
        }

        private string Flip(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
