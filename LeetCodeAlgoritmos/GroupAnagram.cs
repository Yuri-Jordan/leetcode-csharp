using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAlgoritmos
{
    public class GroupAnagram
    {
        public IList<IList<string>> GroupAnagramResult(string[] strs)
        {

            if (strs == null || strs.Length == 0)
            {
                return null;
            }

            Dictionary<string, List<string>> grupoAnagramas = new Dictionary<string, List<string>>();

            foreach (string palavra in strs)
            {
                string palavraAtual = System.String.Concat(palavra.OrderBy(c => c));

                if (!grupoAnagramas.ContainsKey(palavraAtual)) {
                    grupoAnagramas.Add(palavraAtual, new List<string>());
                }
                grupoAnagramas[palavraAtual].Add(palavra);
            }

            return new List<IList<string>>(grupoAnagramas.Values);
        }
    }
}
