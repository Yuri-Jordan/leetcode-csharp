using Xunit;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class RepeatedDNASequencesTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new RepeatedDNASequences();
            var input = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            var expected = new string[] { "AAAAACCCCC", "CCCCCAAAAA" };

            var result = model.FindRepeatedDnaSequences(input);
            bool assertion = expected.All(item => result.Contains(item));
            bool assertionCount = result.All(item => item.Length == 10);

            Assert.Equal(expected.Length, result.Count);
            Assert.True(assertionCount);
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new RepeatedDNASequences();
            var input = "AAAAAAAAAAAAA";
            var expected = new string[] { "AAAAAAAAAA" };

            var result = model.FindRepeatedDnaSequences(input);
            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(expected.Length, result.Count);
            Assert.Equal(expected[0].Length, result[0].Length);
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new RepeatedDNASequences();
            var input = "AAAAAAAAAAA";
            var expected = new string[] { "AAAAAAAAAA" };

            var result = model.FindRepeatedDnaSequences(input);
            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(expected.Length, result.Count);
            Assert.Equal(expected[0].Length, result[0].Length);
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo4()
        {
            var model = new RepeatedDNASequences();
            var input = "CAAAAAAAAAC";
            var expected = new string[] { };

            var result = model.FindRepeatedDnaSequences(input);
            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(expected.Length, result.Count);
            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo5()
        {
            var model = new RepeatedDNASequences();
            var input = "GAGAGAGAGAGA";
            var expected = new string[] { "GAGAGAGAGA" };

            var result = model.FindRepeatedDnaSequences(input);
            bool assertion = expected.All(item => result.Contains(item));

            Assert.Equal(expected.Length, result.Count);
            Assert.True(assertion);
        }
    }
}