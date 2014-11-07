using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;
using System.IO;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class DateCreatedHandlerTests
    {
        IHandler handler;

        [TestInitialize()]
        public void Initialize()
        {
            handler = new DateCreatedHandler();
        }

        [TestMethod]
        public void TestName()
        {
            Assert.IsFalse(String.IsNullOrEmpty(handler.Name));
        }

        [TestMethod]
        public void TestReturnValue()
        {
            const string FILE_NAME = "DateCreatedHandlerTestFile.txt";
            const string DATE_FORMAT_STRING = "MM/dd/yyyy";

            File.Create(FILE_NAME);
            var result = handler.Do(FILE_NAME, new HandlerOptions()
            {
                DateFormatString = DATE_FORMAT_STRING
            });
            Assert.AreEqual(DateTime.Now.ToString(DATE_FORMAT_STRING), result.Value, "Wrong value was returned.");
        }
    }
}
