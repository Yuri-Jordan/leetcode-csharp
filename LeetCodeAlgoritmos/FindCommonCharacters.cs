using System.Collections.Generic;
using System;

namespace LeetCodeAlgoritmos
{
    public class FindCommonCharacters
    {
        public IList<string> CommonChars(string[] words)
        {
            List<string> charComuns = new List<string>();

            var QUANTIDADE_LETRAS_ALFABETO = 26;
            var frequenciaMinima = new int[QUANTIDADE_LETRAS_ALFABETO];
            Array.Fill(frequenciaMinima, int.MaxValue);

            foreach (var palavra in words)
            {
                var frequenciaLetra = new int[QUANTIDADE_LETRAS_ALFABETO];

                foreach (var letra in palavra.ToCharArray())
                {
                    frequenciaLetra[letra - 'a']++;
                }

                for (int i = 0; i < QUANTIDADE_LETRAS_ALFABETO; i++)
                {
                    frequenciaMinima[i] = Math.Min(frequenciaLetra[i], frequenciaMinima[i]);
                }
            }

            for (int i = 0; i < QUANTIDADE_LETRAS_ALFABETO; i++)
            {
                while (frequenciaMinima[i] > 0)
                {
                    charComuns.Add("" + (char)(i + 'a'));
                    frequenciaMinima[i]--;
                }
            }

            return charComuns;
        }
    }
}
