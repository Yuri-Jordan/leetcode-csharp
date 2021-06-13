using System.Collections.Generic;
using System;

namespace LeetCodeAlgoritmos
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int indiceInicialDaJanela = 0;
            int indiceFinalDaJanela = 0;
            int tamanhoMaximoSubst = 0;
            HashSet<char> letrasNaoRepetidas = new HashSet<char>();

            while (indiceFinalDaJanela < s.Length)
            {
                if (letrasNaoRepetidas.Add(s[indiceFinalDaJanela]))
                {
                    indiceFinalDaJanela++;
                    tamanhoMaximoSubst = Math.Max(tamanhoMaximoSubst, letrasNaoRepetidas.Count);
                }
                else
                {
                    letrasNaoRepetidas.Remove(s[indiceInicialDaJanela]);
                    indiceInicialDaJanela++;
                }
            }
            return tamanhoMaximoSubst;
        }
    }
}
