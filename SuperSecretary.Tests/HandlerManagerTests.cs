using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class HandlerManagerTests
    {
        [TestMethod]
        [DeploymentItem("SuperSecretary.Tests.dll", "HandlerManagerTests")]
        public void LoadAssembly()
        {
            var hm = HandlerManager.Instance;
            hm.LoadAssembly(Environment.CurrentDirectory + "\\HandlerManagerTests\\SuperSecretary.Tests.dll");

            Assert.IsTrue(hm.Handlers.ContainsKey("Test Handler"));

            var testHandler = hm.Handlers["Test Handler"];
            var result = testHandler.Do("", new HandlerOptions());
            Assert.AreEqual("Test Value", result.Value, "Returned value is not correct.");
        }
    }
}
