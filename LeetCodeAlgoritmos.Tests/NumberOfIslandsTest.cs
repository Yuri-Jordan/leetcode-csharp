using Xunit;

namespace LeetCodeAlgoritmos.Tests
{
    public class NumberOfIslandsTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new NumberofIslands();
            var input = new char[][] {
                new char [] {'1','1','1','1','0'},
                new char [] {'1','1','0','1','0'},
                new char [] {'1','1','0','0','0'},
                new char [] {'0','0','0','0','0'}
            };
            var expected = 1;

            var result = model.NumberOfIslands(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new NumberofIslands();
            var input = new char[][] {
                new char [] {'1','1','0','0','0'},
                new char [] {'1','1','0','0','0'},
                new char [] {'0','0','1','0','0'},
                new char [] {'0','0','0','1','1'}
            };
            var expected = 3;

            var result = model.NumberOfIslands(input);

            Assert.Equal(expected, result);
        }
    }
}