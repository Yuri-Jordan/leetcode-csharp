using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class GroupAnagramTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new GroupAnagram();
            var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            List<List<string>> listToCompare = new List<List<string>>()
            {
                new List<string> {"bat"},
                new List<string> {"nat","tan"},
                new List<string> {"ate","eat","tea"},
            };
            
            var result = model.GroupAnagramResult(input);

            var bat = result.Where(a => a.Count == 1);
            var natTan = result.Where(a => a.Count == 2);
            var ateEatTea = result.Where(a => a.Count == 3);
            
            bool batEqual = bat.SelectMany(a => a).All(item => listToCompare[0].Contains(item));
            bool natTanEqual = natTan.SelectMany(a => a).All(item => listToCompare[1].Contains(item));
            bool ateEatTeaEqual = ateEatTea.SelectMany(a => a).All(item => listToCompare[2].Contains(item));


            Assert.True(batEqual, "Primeiro Anagrama agrupado de acordo com o exemplo 1.");
            Assert.True(natTanEqual, "Segundo Anagrama agrupado de acordo com o exemplo 1.");
            Assert.True(ateEatTeaEqual, "Terceiro Anagrama agrupado de acordo com o exemplo 1.");
        }
    }
}