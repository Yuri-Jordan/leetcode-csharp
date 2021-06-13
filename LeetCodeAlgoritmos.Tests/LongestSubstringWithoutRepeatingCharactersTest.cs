using Xunit;

namespace LeetCodeAlgoritmos.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new LongestSubstringWithoutRepeatingCharacters();
            var input = "abcabcbb";
            var expected = 3;

            var result = model.LengthOfLongestSubstring(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new LongestSubstringWithoutRepeatingCharacters();
            var input = "bbbbb";
            var expected = 1;

            var result = model.LengthOfLongestSubstring(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new LongestSubstringWithoutRepeatingCharacters();
            var input = "pwwkew";
            var expected = 3;

            var result = model.LengthOfLongestSubstring(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo4()
        {
            var model = new LongestSubstringWithoutRepeatingCharacters();
            var input = "";
            var expected = 0;

            var result = model.LengthOfLongestSubstring(input);

            Assert.Equal(expected, result);
        }
    }
}