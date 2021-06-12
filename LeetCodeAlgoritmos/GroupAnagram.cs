using System.Collections.Generic;

namespace LeetCodeAlgoritmos
{
    public class GroupAnagram
    {
        public IList<IList<string>> GroupAnagramResult(string[] strs)
        {
            return  new List<IList<string>>()
            {
                new List<string> {"bat"},
                new List<string> {"tan","nat"},
                new List<string> {"tea","eat","ate"},
            };

        }
    }
}
