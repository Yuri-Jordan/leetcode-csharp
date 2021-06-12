using Xunit;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class FindCommonCharactersTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new FindCommonCharacters();
            var input = new string[] { "bella", "label", "roller" };
            var expected = new string[] { "e", "l", "l" };

            var result = model.CommonChars(input);

            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(3, result.Count);
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new FindCommonCharacters();
            var input = new string[] { "cool", "lock", "cook" };
            var expected = new string[] { "c", "o" };

            var result = model.CommonChars(input);

            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(2, result.Count);
            Assert.True(assertion);
        }
    }
}