using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class TestWriteToList
    {
        [TestMethod]
        public void TestWriteList()
        {
            var inputs = new List<object>
            {
                69,
                "this is a string",
                new Foo("a value")
            };

            var result = LinqPracticeMethods.WriteList(inputs);

            var expectedOutput = "1: 69\n2: this is a string\n3: Foo a value";

            Assert.AreEqual(expectedOutput, result);
        }
    }
}
