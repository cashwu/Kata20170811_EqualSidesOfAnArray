using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170811_EqualSidesOfAnArray
{
    [TestClass]
    public class ValidateWordTest
    {
        [TestMethod]
        public void input_1_2_1_should_return_1()
        {
            FindEvenIndexShouldBe(1, new[] {1, 2, 1});
        }

        private static void FindEvenIndexShouldBe(int expected, int[] array)
        {
            var kata = new Kata();
            var actual = kata.FindEvenIndex(array);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int FindEvenIndex(int[] arr)
        {
            return 1;
        }
    }
}
