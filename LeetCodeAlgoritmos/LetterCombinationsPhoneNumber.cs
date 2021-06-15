using System.Collections.Generic;
using System;

namespace LeetCodeAlgoritmos
{
    public class LetterCombinationsPhoneNumber
    {
        private void recursao(
            List<string> combinacoes,
            List<string> teclado,
            int indice,
            string stringAtual,
            string digits)
        {
            if (stringAtual.Length == digits.Length)
            {
                combinacoes.Add(stringAtual);
                return;
            }

            string letrasDaTecla = teclado[digits[indice] - '0'];

            for (int i = 0; i < letrasDaTecla.Length; i++)
            {
                recursao(combinacoes, teclado, indice + 1, stringAtual + letrasDaTecla[i], digits);
            }
        }

        public IList<string> LetterCombinations(string digits)
        {
            List<string> combinacoes = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return combinacoes;
            }

            List<string> teclado = new List<string>();
            teclado.Add("0");
            teclado.Add("1");
            teclado.Add("abc");
            teclado.Add("def");
            teclado.Add("ghi");
            teclado.Add("jkl");
            teclado.Add("mno");
            teclado.Add("pqrs");
            teclado.Add("tuv");
            teclado.Add("wxyz");

            recursao(combinacoes, teclado, 0, "", digits);
            return combinacoes;
        }
    }
}
