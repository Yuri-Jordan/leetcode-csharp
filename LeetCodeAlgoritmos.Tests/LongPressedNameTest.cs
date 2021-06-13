using Xunit;

namespace LeetCodeAlgoritmos.Tests
{
    public class LongPressedNameTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new LongPressedName();
            var inputName = "alex";
            var inputTyped = "aaleex";
            var expected = true;

            var result = model.IsLongPressedName(inputName, inputTyped);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new LongPressedName();
            var inputName = "saeed";
            var inputTyped = "ssaaedd";
            var expected = false;

            var result = model.IsLongPressedName(inputName, inputTyped);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo3()
        {
            var model = new LongPressedName();
            var inputName = "leelee";
            var inputTyped = "lleeelee";
            var expected = true;

            var result = model.IsLongPressedName(inputName, inputTyped);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo4()
        {
            var model = new LongPressedName();
            var inputName = "laiden";
            var inputTyped = "laiden";
            var expected = true;

            var result = model.IsLongPressedName(inputName, inputTyped);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo5()
        {
            var model = new LongPressedName();
            var inputName = "a";
            var inputTyped = "b";
            var expected = false;

            var result = model.IsLongPressedName(inputName, inputTyped);
            Assert.Equal(expected, result);
        }
    }
}