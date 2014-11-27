using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class Id3AlbumHandlerTests
    {
        IHandler handler;

        [TestInitialize()]
        public void Initialize()
        {
            handler = new Id3AlbumHandler();
        }

        [TestMethod]
        public void TestName()
        {
            Assert.IsFalse(String.IsNullOrEmpty(handler.Name));
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.mp3", "Id3Tests")]
        public void TestReturnValue()
        {
            var result = handler.Do("Id3Tests\\Test.mp3", new HandlerOptions());
            Assert.AreEqual("Test Album", result.Value, "Wrong value was returned.");
        }
    }
}
