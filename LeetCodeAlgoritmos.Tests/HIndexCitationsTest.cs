using Xunit;

namespace LeetCodeAlgoritmos.Tests
{
    public class HIndexCitationsTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new HIndexCitations();
            var input = new int[] { 3, 0, 6, 1, 5 };

            var result = model.HIndex(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new HIndexCitations();
            var input = new int[] { 1,3,1 };

            var result = model.HIndex(input);

            Assert.Equal(1, result);
        }
    }
}