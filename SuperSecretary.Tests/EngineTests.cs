using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SuperSecretary;
using System.Linq;

namespace SuperSecretary.Tests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.Scan")]
        [DeploymentItem("Files\\Test.pdf", "EngineTests.Scan\\Subdirectory")]
        public void Scan()
        {
            var result = Engine.Scan("EngineTests.Scan", false);
            Assert.IsTrue(result.Success, "Scan was not successful.");
            Assert.AreEqual(1, result.Files.Length, "Scan did not find all files.");
            Assert.IsTrue(result.Extensions.Contains(".txt"), "Expected extensions were not found.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ScanWithRecurseSubdirectories")]
        [DeploymentItem("Files\\Test.pdf", "EngineTests.ScanWithRecurseSubdirectories\\Subdirectory")]
        public void ScanWithRecurseSubdirectories()
        {
            var result = Engine.Scan("EngineTests.ScanWithRecurseSubdirectories", true);
            Assert.IsTrue(result.Success, "Scan was not successful.");
            Assert.AreEqual(2, result.Files.Length, "Scan did not find all files.");
            Assert.IsTrue(result.Extensions.Contains(".txt"), "Expected extensions were not found.");
            Assert.IsTrue(result.Extensions.Contains(".pdf"), "Expected extensions were not found.");
        }

        [TestMethod]
        public void ScanShouldFail()
        {
            var result = Engine.Scan(@"A:\Path\That\Does\Not\Exist", true);
            Assert.IsFalse(result.Success, "Invalid path scan returned wrong success value.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.Process.In")]
        [DeploymentItem("Files\\Test.pdf", "EngineTests.Process.In")]
        [DeploymentItem("Files\\Test.html", "EngineTests.Process.In")]
        [DeploymentItem("Files\\JPGWithEXIFData.jpg", "EngineTests.Process.In")]
        public void Process()
        {
            const string SOURCE = "EngineTests.Process.In";
            const string DESTINATION = "EngineTests.Process.Out";

            string[] properties = new string[] { "File Extension" };

            EngineOptions options = new EngineOptions()
            {
                RecurseSubdirectories = true,
                SortByMonth = true,
                Copy = true,
                FileExtensions = new string[] {},
                YearFormatString = "yyyy",
                MonthFormatString = "MM"
            };

            Engine engine = new Engine(SOURCE, DESTINATION, properties, options);
            engine.Process();

            Assert.IsTrue(File.Exists(DESTINATION + "\\txt\\Test.txt"), "File does not exist in destination.");
            Assert.IsTrue(File.Exists(DESTINATION + "\\pdf\\Test.pdf"), "File does not exist in destination.");
            Assert.IsTrue(File.Exists(DESTINATION + "\\html\\Test.html"), "File does not exist in destination.");
            Assert.IsTrue(File.Exists(DESTINATION + "\\jpg\\JPGWithEXIFData.jpg"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithMove.In")]
        public void ProcessWithMove()
        {
            const string SOURCE = "EngineTests.ProcessWithMove.In";
            const string DESTINATION = "EngineTests.ProcessWithMove.Out";

            string[] properties = new string[] { "File Extension" };

            EngineOptions options = new EngineOptions()
            {
                RecurseSubdirectories = true,
                SortByMonth = true,
                Copy = false,
                FileExtensions = new string[] { },
                YearFormatString = "yyyy",
                MonthFormatString = "MM"
            };

            Engine engine = new Engine(SOURCE, DESTINATION, properties, options);
            engine.Process();

            Assert.IsFalse(File.Exists(SOURCE + "\\txt\\Test.txt"), "File should have moved to destination.");

            Assert.IsTrue(File.Exists(DESTINATION + "\\txt\\Test.txt"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithSelectedExtensions.In")]
        [DeploymentItem("Files\\Test.pdf", "EngineTests.ProcessWithSelectedExtensions.In")]
        public void ProcessWithSelectedExtensions()
        {
            const string SOURCE = "EngineTests.ProcessWithSelectedExtensions.In";
            const string DESTINATION = "EngineTests.ProcessWithSelectedExtensions.Out";

            string[] properties = new string[] { "File Extension" };

            EngineOptions options = new EngineOptions()
            {
                RecurseSubdirectories = true,
                SortByMonth = true,
                Copy = true,
                FileExtensions = new string[] { ".txt" },
                YearFormatString = "yyyy",
                MonthFormatString = "MM"
            };

            Engine engine = new Engine(SOURCE, DESTINATION, properties, options);
            engine.Process();

            Assert.IsFalse(File.Exists(DESTINATION + "\\pdf\\Test.pdf"), "File should should not exist in destination.");

            Assert.IsTrue(File.Exists(DESTINATION + "\\txt\\Test.txt"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithRecurseSubdirectories.In")]
        [DeploymentItem("Files\\Test.pdf", "EngineTests.ProcessWithRecurseSubdirectories.In\\Subdirectory")]
        public void ProcessWithRecurseSubdirectories()
        {
            const string SOURCE = "EngineTests.ProcessWithRecurseSubdirectories.In";
            const string DESTINATION = "EngineTests.ProcessWithRecurseSubdirectories.Out";

            string[] properties = new string[] { "File Extension" };

            EngineOptions options = new EngineOptions()
            {
                RecurseSubdirectories = true,
                SortByMonth = true,
                Copy = true,
                FileExtensions = new string[] { },
                YearFormatString = "yyyy",
                MonthFormatString = "MM"
            };

            Engine engine = new Engine(SOURCE, DESTINATION, properties, options);
            engine.Process();

            Assert.IsTrue(File.Exists(DESTINATION + "\\pdf\\Test.pdf"), "File does not exist in destination.");

            Assert.IsTrue(File.Exists(DESTINATION + "\\txt\\Test.txt"), "File does not exist in destination.");
        }
    }
}
