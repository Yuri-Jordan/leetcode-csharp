using Xunit;

namespace LeetCodeAlgoritmos.Tests
{
    public class SingleNumberIITest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new SingleNumberII();
            var input = new int[] { 2, 2, 3, 2 };
            var expected = 3;

            var result = model.SingleNumber(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new SingleNumberII();
            var input = new int[] { 20, 1, 0, 1, 0, 1, 99 };
            var expected = 99;

            var result = model.SingleNumber(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new SingleNumberII();
            var input = new int[] { 30000, 500, 100, 30000, 100, 30000, 100 };
            var expected = 500;

            var result = model.SingleNumber(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo4()
        {
            var model = new SingleNumberII();
            var input = new int[] { -2, -2, 1, 1, 4, 1, 4, 4, -4, -2 };
            var expected = -4;

            var result = model.SingleNumber(input);

            Assert.Equal(expected, result);
        }
    }
}