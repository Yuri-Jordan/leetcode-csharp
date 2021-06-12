using Xunit;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class SetMismatchTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new SetMismatch();
            var input = new int[] { 1, 2, 2, 4 };
            var expected = new int[] { 2, 3 };

            var result = model.FindErrorNums(input);

            bool assertion = result.All(item => expected.Contains(item));

            Assert.True(assertion);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new SetMismatch();
            var input = new int[] { 1, 1 };
            var expected = new int[] { 1, 2 };

            var result = model.FindErrorNums(input);

            bool assertion = result.All(item => expected.Contains(item));

            Assert.True(assertion);
        }
    }
}