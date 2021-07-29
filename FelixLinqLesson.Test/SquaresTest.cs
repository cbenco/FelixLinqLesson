using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class SquaresTest
    {
        [TestMethod]
        public void TestHappyPath()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var squares = new[] { 1, 4, 9, 16, 25 };

            var result = LinqPracticeMethods.TestForSquares(numbers, squares);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSadPathIncorrectSquares()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var squares = new[] { 1, 4, 12, 16, 25 };

            var result = LinqPracticeMethods.TestForSquares(numbers, squares);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestSadPathWrongNumberOfSquares()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var squares = new[] { 1, 4, 12, 16 };

            var result = LinqPracticeMethods.TestForSquares(numbers, squares);

            Assert.IsFalse(result);
        }
    }
}
