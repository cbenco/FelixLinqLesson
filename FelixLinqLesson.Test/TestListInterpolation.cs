using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class TestListInterpolation
    {
        [TestMethod]
        public void TestInterpolateListPropertyWithFilter()
        {
            var tables = new List<TableModel>
            {
                new TableModel
                {
                    Id = "1234",
                    Name = "Table 1"
                },
                new TableModel
                {
                    Id = "2345",
                    Name = "Table 2"
                },
            };

            var fields = new List<FieldModel>
            {
                new FieldModel
                {
                    Id = "9876",
                    TableId = "1234",
                    Name = "f1",
                    Type = 1
                },
                new FieldModel
                {
                    Id = "8765",
                    TableId = "1234",
                    Name = "f2",
                    Type = 2
                }
            };

            var result = LinqPracticeMethods.InterpolateListPropertyWithFilter(tables, fields, f => f.Type != 2);

            var tableWithFields = result.FirstOrDefault(x => x.Id == "1234");
            Assert.IsNotNull(tableWithFields);
            Assert.AreEqual("Table 1", tableWithFields.Name);
            Assert.IsNotNull(tableWithFields.Fields);
            Assert.AreEqual(1, tableWithFields.Fields.Count());

            var field = tableWithFields.Fields.First();
            Assert.AreEqual("f1", field.Name);
            Assert.AreEqual("9876", field.Id);
            Assert.AreEqual(1, field.Type);

            var tableWithoutFields = result.FirstOrDefault(x => x.Id == "2345");
            Assert.IsNotNull(tableWithoutFields);
            Assert.AreEqual("Table 2", tableWithoutFields.Name);
            Assert.IsNotNull(tableWithoutFields.Fields);
            Assert.IsFalse(tableWithoutFields.Fields.Any());
        }
    }
}
