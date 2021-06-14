using Xunit;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class LetterCombinationsOfAPhoneNumber
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new LetterCombinationsPhoneNumber();
            var input = "23";
            var expected = new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            var result = model.LetterCombinations(input);

            bool assertion = expected.All(item => result.Contains(item));
            bool assertionCount = result.All(item => item.Length == 2);

            Assert.Equal(expected.Length, result.Count);
            Assert.True(assertionCount, "Cada grupo contêm 2 dígitos.");
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new LetterCombinationsPhoneNumber();
            var input = "";
            var expected = new string[] { };

            var result = model.LetterCombinations(input);

            Assert.Equal(expected.Length, result.Count);
            Assert.True(!result.Any(), "O resultado deve ser uma lista vazia.");
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new LetterCombinationsPhoneNumber();
            var input = "2";
            var expected = new string[] { "a", "b", "c" };

            var result = model.LetterCombinations(input);

            bool assertion = expected.All(item => result.Contains(item));
            bool assertionCount = result.All(item => item.Length == 1);

            Assert.Equal(expected.Length, result.Count);
            Assert.True(assertionCount, "Cada grupo contêm 1 dígitos.");
            Assert.True(assertion, "O resultado deve ser 'a', 'b', 'c'");
        }
    }
}