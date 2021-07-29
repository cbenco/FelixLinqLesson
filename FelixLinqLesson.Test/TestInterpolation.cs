using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class TestInterpolation
    {
        [TestMethod]
        public void TestInterpolateClassProperty()
        {
            var people = new List<PersonModel>
            {
                new PersonModel
                {
                    Id = "1",
                    Name = "Felix"
                },
                new PersonModel
                {
                    Id = "2",
                    Name = "Nez"
                },
                new PersonModel
                {
                    Id = "3",
                    Name = "Benco"
                },
                new PersonModel
                {
                    Id = "4",
                    Name = "JY"
                }
            };

            var classes = new List<PersonClass>
            {
                new PersonClass
                {
                    PersonId = "1",
                    Class = Class.Lower
                },
                new PersonClass
                {
                    PersonId = "3",
                    Class = Class.Middle
                },
                new PersonClass
                {
                    PersonId = "4",
                    Class = Class.Upper
                },
            };

            var result = LinqPracticeMethods.InterpolatePropertyFromAnotherList(people, classes);

            var felix = result.FirstOrDefault(x => x.Id == "1");
            Assert.IsNotNull(felix);
            Assert.AreEqual("Felix", felix.Name);
            Assert.AreEqual(Class.Lower, felix.Class);

            var nez = result.FirstOrDefault(x => x.Id == "2");
            Assert.IsNotNull(nez);
            Assert.AreEqual("Nez", nez.Name);
            Assert.AreEqual(Class.Lower, nez.Class);

            var benco = result.FirstOrDefault(x => x.Id == "3");
            Assert.IsNotNull(benco);
            Assert.AreEqual("Benco", benco.Name);
            Assert.AreEqual(Class.Middle, benco.Class);

            var jy = result.FirstOrDefault(x => x.Id == "4");
            Assert.IsNotNull(jy);
            Assert.AreEqual("JY", jy.Name);
            Assert.AreEqual(Class.Upper, jy.Class);
        }
    }
}
