using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SuperSecretary;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void Scan_WithRecurseSubdirectories()
        {
            FileManager.RefreshTestFiles();
            var result = Engine.Scan(FileManager.PATH, true);
        }

        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void Scan_WithInvalidPath()
        {
            var result = Engine.Scan(@"A:\Path\That\Does\Not\Exist", true);
        }
    }
}
