using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class LastWordWithETest
    {
        [TestMethod]
        public void TestHappyPath()
        {
            var sentence = "Here is words and as you can see there are many lower case Es. Zephyr zebra zucc.";

            var result = LinqPracticeMethods.GetLastWordContainingLowerCaseE(sentence);

            Assert.AreEqual("The last word is zephyr", result);
        }

        [TestMethod]
        public void TestNullWhenUpperCaseEShouldBeIgnored()
        {
            var sentence = "THERE IS NO LOWER CASE E ALLOWED. DO NOT ATTEMPT.";

            var result = LinqPracticeMethods.GetLastWordContainingLowerCaseE(sentence);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestNullWhenNoLowerCaseEFound()
        {
            var sentence = "This man actually thought of a long string of words that contain't any of that guy whom go afta D";

            var result = LinqPracticeMethods.GetLastWordContainingLowerCaseE(sentence);

            Assert.IsNull(result);
        }
    }
}
