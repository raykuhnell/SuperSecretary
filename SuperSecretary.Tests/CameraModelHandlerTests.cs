using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class CameraModelHandlerTests
    {
        IHandler handler;

        [TestInitialize()]
        public void Initialize()
        {
            handler = new CameraModelHandler();
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
            var result = handler.Do("EXIFTests\\JPGWithEXIFData.jpg", new HandlerOptions());
            Assert.AreEqual("Test Camera Model", result.Value, "Wrong value was returned.");
        }
    }
}
