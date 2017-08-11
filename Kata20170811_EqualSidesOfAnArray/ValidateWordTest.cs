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

        [TestMethod]
        public void input_1_2_3_4_3_2_1_should_return_3()
        {
            FindEvenIndexShouldBe(3, new[] { 1, 2, 3, 4, 3, 2, 1 });
        }

        [TestMethod]
        public void input_1_100_50_n51_1_1_should_return_3()
        {
            FindEvenIndexShouldBe(1, new[] { 1, 100, 50, -51, 1, 1 });
        }

        [TestMethod]
        public void input_1_2_3_4_5_6_should_return_n1()
        {
            FindEvenIndexShouldBe(-1, new[] { 1, 2, 3, 4, 5, 6 });
        }

        [TestMethod]
        public void input_20_10_30_10_10_15_35_should_return_3()
        {
            FindEvenIndexShouldBe(3, new[] { 20, 10, 30, 10, 10, 15, 35 });
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
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum())
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
