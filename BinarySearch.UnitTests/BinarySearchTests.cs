using System;
using NUnit.Framework;

namespace BinarySearch.UnitTests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void Search_Given_NullArray_Throws_ArgumentNullException()
        {
            Action action = () => BinarySearch.Search(0, null);
            Assert.That(action, Throws.ArgumentNullException);
        }

        [TestCase(1, new [] { 0 }, -1)]
        [TestCase(1, new [] { 1 }, 0)]
        [TestCase(2, new [] { 1, 2 }, 1)]
        [TestCase(3, new [] { 1, 3, 5 }, 1)]
        [TestCase(3, new [] { 1, 3, 3, 7 }, 1)]
        public void Search_Given_ValidInputs_Returns_ExpectedOutputs(int searchValue, int[] arr, int expected)
        {
            var actual = BinarySearch.Search(searchValue, arr);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}