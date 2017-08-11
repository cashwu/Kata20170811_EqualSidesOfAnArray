using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170811_EqualSidesOfAnArray
{
    [TestClass]
    public class ValidateWordTest
    {
        [TestMethod]
        public void input_1_2_1_should_return_1()
        {
            FindEvenIndexShouldBe(1, new[] { 1, 2, 1 });
        }

        [TestMethod]
        public void input_1_2_3_2_1_should_return_2()
        {
            FindEvenIndexShouldBe(2, new[] { 1, 2, 3, 2, 1 });
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
            for (var i = 0; i < arr.Length; i++)
            {
                var leftItemSum = arr.Select((a, idx) => idx < i ? a : 0).Sum();
                var rightItemSum = arr.Select((a, idx) => idx > i ? a : 0).Sum();

                if (leftItemSum == rightItemSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
