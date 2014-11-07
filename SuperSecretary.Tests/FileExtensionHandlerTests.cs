using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class FileExtensionHandlerTests
    {
        IHandler handler;

        [TestInitialize()]
        public void Initialize()
        {
            handler = new FileExtensionHandler();
        }

        [TestMethod]
        public void TestName()
        {
            Assert.IsFalse(String.IsNullOrEmpty(handler.Name));
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.html", "FileExtensionHandlerTests")]
        public void TestReturnValue()
        {
            var result = handler.Do("FileExtensionHandlerTests\\Test.html", new HandlerOptions());
            Assert.AreEqual("html", result.Value, "Wrong value was returned.");
        }
    }
}
