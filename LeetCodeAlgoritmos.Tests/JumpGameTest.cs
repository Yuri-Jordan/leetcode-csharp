using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeAlgoritmos.Tests
{
    public class JumpGameTest
    {
        [Fact]
        public void Exemplo1()
        {
            var model = new JumpGame();
            var input = new int[] { 2, 3, 1, 1, 4 };
            bool expected = true;

            var result = model.CanJump(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Exemplo2()
        {
            var model = new JumpGame();
            var input = new int[] { 3, 2, 1, 0, 4 };
            bool expected = false;

            var result = model.CanJump(input);
            Assert.Equal(expected, result);
        }
    }
}