using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class DateTakenHandlerTests
    {
        IHandler handler;

        [TestInitialize()]
        public void Initialize()
        {
            handler = new DateTakenHandler();
        }

        [TestMethod]
        public void TestName()
        {
            Assert.IsFalse(String.IsNullOrEmpty(handler.Name));
        }

        [TestMethod]
        [DeploymentItem("Files\\JPGWithEXIFData.jpg", "EXIFTests")]
        public void TestReturnValue()
        {
            var result = handler.Do("EXIFTests\\JPGWithEXIFData.jpg", new HandlerOptions()
            {
                DateFormatString = "MM/dd/yyyy"
            });
            Assert.AreEqual("01/01/2014", result.Value, "Wrong value was returned.");
        }
    }
}
