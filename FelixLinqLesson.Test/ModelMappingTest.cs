using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FelixLinqLesson.Test
{
    [TestClass]
    public class ModelMappingTest
    {
        [TestMethod]
        public void TestModelMapping()
        {
            var errorReports = new List<ErrorReport>
            {
                new ErrorReport
                {
                    Id = "1234",
                    ErrorCode = 200,
                    ErrorMessage = string.Empty,
                    ExternalProviderId = 5
                },
                new ErrorReport
                {
                    Id = "2345",
                    ErrorCode = 404,
                    ErrorMessage = "Resource not found",
                    ExternalProviderId = 3
                },
                new ErrorReport
                {
                    Id = "3456",
                    ErrorCode = 200,
                    ErrorMessage = string.Empty,
                    ExternalProviderId = null
                }
            };

            var result = LinqPracticeMethods.MapDbModelToExternalModel(errorReports);

            var okResult = result.FirstOrDefault(x => x.ErrorTraceId == "1234");
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.ErrorCode);
            Assert.IsTrue(string.IsNullOrEmpty(okResult.ErrorMessage));
            Assert.AreEqual(5, okResult.ExternalProviderId);
            Assert.IsTrue(okResult.IsSuccess);

            var notFoundResult = result.FirstOrDefault(x => x.ErrorTraceId == "2345");
            Assert.IsNotNull(notFoundResult);
            Assert.AreEqual(404, notFoundResult.ErrorCode);
            Assert.AreEqual("Resource not found", notFoundResult.ErrorMessage);
            Assert.AreEqual(3, notFoundResult.ExternalProviderId);
            Assert.IsFalse(notFoundResult.IsSuccess);

            var defaultProviderResult = result.FirstOrDefault(x => x.ErrorTraceId == "3456");
            Assert.IsNotNull(defaultProviderResult);
            Assert.AreEqual(200, defaultProviderResult.ErrorCode);
            Assert.IsTrue(defaultProviderResult.IsSuccess);
            Assert.IsTrue(string.IsNullOrEmpty(defaultProviderResult.ErrorMessage));
            Assert.AreEqual(-255, defaultProviderResult.ExternalProviderId);
        }
    }
}
