using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class TestOnlyUpperCase
    {
        [TestMethod]
        public void TestGetOnlyUppercase()
        {
            var input = "DDD example CQRS Event Sourcing";

            var result = LinqPracticeMethods.GetOnlyUppercase(input);

            var expected = new[] { "DDD", "CQRS" };
            CollectionAssert.AreEqual(expected, result.ToList());
        }
    }
}
