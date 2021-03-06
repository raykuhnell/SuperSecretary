﻿using System;
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
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] {},
                DateFormatString = "yyyy\\MM"
            };

            Engine engine = new Engine(options);
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
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = false,
                FileExtensions = new string[] { },
                DateFormatString = "yyyy\\MM"
            };

            Engine engine = new Engine(options);
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
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] { ".txt" },
                DateFormatString = "yyyy\\MM"
            };

            Engine engine = new Engine(options);
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
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] { },
                DateFormatString = "yyyy\\MM"
            };

            Engine engine = new Engine(options);
            engine.Process();

            Assert.IsTrue(File.Exists(DESTINATION + "\\pdf\\Test.pdf"), "File does not exist in destination.");

            Assert.IsTrue(File.Exists(DESTINATION + "\\txt\\Test.txt"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithMissingFolderName.In")]
        public void ProcessWithMissingFolderName()
        {
            const string SOURCE = "EngineTests.ProcessWithMissingFolderName.In";
            const string DESTINATION = "EngineTests.ProcessWithMissingFolderName.Out";

            string[] properties = new string[] { "Date Taken" };

            EngineOptions options = new EngineOptions()
            {
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] { },
                SkipFolder = false,
                MissingFolderName = "Unsorted"
            };

            Engine engine = new Engine(options);
            engine.Process();

            Assert.IsTrue(File.Exists(DESTINATION + "\\Unsorted\\Test.txt"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithSkipFolder.In")]
        public void ProcessWithSkipFolder()
        {
            const string SOURCE = "EngineTests.ProcessWithSkipFolder.In";
            const string DESTINATION = "EngineTests.ProcessWithSkipFolder.Out";

            string[] properties = new string[] { "Date Taken" };

            EngineOptions options = new EngineOptions()
            {
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] { },
                DateFormatString = "yyyy\\MM",
                SkipFolder = true
            };

            Engine engine = new Engine(options);
            engine.Process();

            Assert.IsTrue(File.Exists(DESTINATION + "\\Test.txt"), "File does not exist in destination.");
        }

        [TestMethod]
        [DeploymentItem("Files\\Test.txt", "EngineTests.ProcessWithOverwriteExistingFiles.In")]
        [DeploymentItem("Files\\Existing\\Test.txt", "EngineTests.ProcessWithOverwriteExistingFiles.Out\\txt")]
        public void ProcessWithOverwriteExistingFiles()
        {
            const string SOURCE = "EngineTests.ProcessWithOverwriteExistingFiles.In";
            const string DESTINATION = "EngineTests.ProcessWithOverwriteExistingFiles.Out";

            string[] properties = new string[] { "File Extension" };

            EngineOptions options = new EngineOptions()
            {
                Source = SOURCE,
                Destination = DESTINATION,
                Properties = properties,
                RecurseSubdirectories = true,
                Copy = true,
                FileExtensions = new string[] { },
                DateFormatString = "yyyy\\MM",
                OverwriteExistingFiles = true
            };

            Engine engine = new Engine(options);
            engine.Process();

            string text = File.ReadAllText(DESTINATION + "\\txt\\Test.txt");

            Assert.IsTrue(String.IsNullOrEmpty(text), "Existing file was not overwritten.");
        }
    }
}
