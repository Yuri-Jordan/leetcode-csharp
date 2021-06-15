using Xunit;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class PascalsTriangleIITest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new PascalsTriangleII();
            var input = 3;
            var expected = new int[] { 1, 3, 3, 1 };

            var result = model.GetRow(input);
            var assertion = result.ToList().SequenceEqual(expected);

            Assert.True(result.Count == expected.Length, "Resultado deve conter o mesmo número de elementos do esperado.");
            Assert.True(assertion, "A linha do triângulo de Pascal do índice deve corresponder ao esperado.");
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new PascalsTriangleII();
            var input = 0;
            var expected = new int[] { 1 };

            var result = model.GetRow(input);
            var assertion = result.ToList().SequenceEqual(expected);

            Assert.True(result.Count == expected.Length, "Resultado deve conter o mesmo número de elementos do esperado.");
            Assert.True(assertion, "A linha do triângulo de Pascal do índice deve corresponder ao esperado.");
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new PascalsTriangleII();
            var input = 1;
            var expected = new int[] { 1, 1 };

            var result = model.GetRow(input);
            var assertion = result.ToList().SequenceEqual(expected);

            Assert.True(result.Count == expected.Length, "Resultado deve conter o mesmo número de elementos do esperado.");
            Assert.True(assertion, "A linha do triângulo de Pascal do índice deve corresponder ao esperado.");
        }
    }
}