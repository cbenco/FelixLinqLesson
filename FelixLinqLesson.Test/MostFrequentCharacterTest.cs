using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class MostFrequentCharacterTest
    {
        [TestMethod]
        public void TestMostFrequentCharacterDistinct()
        {
            var input = "panda";

            var result = LinqPracticeMethods.GetMostFrequentCharacter(input);

            Assert.AreEqual('a', result);
        }

        [TestMethod]
        public void TestMostFrequentCharacterMixedCase()
        {
            var input = "A Dude";

            var result = LinqPracticeMethods.GetMostFrequentCharacter(input);

            Assert.AreEqual('d', result);
        }

        [TestMethod]
        public void TestMostFrequentCharacterAlphabeticalPriority()
        {
            var input = "Aaaah duuuude";

            var result = LinqPracticeMethods.GetMostFrequentCharacter(input);

            Assert.AreEqual('a', result);
        }
    }
}
