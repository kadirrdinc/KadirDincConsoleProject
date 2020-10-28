using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SequenceAnalysis
{
    public class ExampleSA
    {
        public string Example(string word)
        {
            try
            {
                string result = string.Concat(Regex
               .Matches(word, "[A-Z]")
               .OfType<Match>()
               .Select(match => match.Value)).Trim();

                string result2 = null;
                int wordLength = result.Length;
                char[] dizi = new char[wordLength];
                for (int i = 0; i < wordLength; i++)
                {
                    dizi[i] = result[i];
                }
                Array.Sort(dizi);

                for (int j = 0; j < wordLength; j++)
                {
                    result2 += dizi[j].ToString();
                }
                return result2;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
    }
}
