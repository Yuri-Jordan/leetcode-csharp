using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAlgoritmos
{
    public class RepeatedDNASequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> nucleotideosVistos = new HashSet<string>();
            var sequenciaRepetidaDezNucleotideos = new List<string>();

            if (s.Length <= 10) return sequenciaRepetidaDezNucleotideos;

            for (int i = 0; i + 9 < s.Length; i++)
            {
                string sequenciaDna = s.Substring(i, 10);

                if (nucleotideosVistos.Contains(sequenciaDna) && !sequenciaRepetidaDezNucleotideos.Contains(sequenciaDna))
                {
                    sequenciaRepetidaDezNucleotideos.Add(sequenciaDna);
                }
                else
                {
                    nucleotideosVistos.Add(sequenciaDna);
                }
            }
            return sequenciaRepetidaDezNucleotideos;
        }
    }
}
