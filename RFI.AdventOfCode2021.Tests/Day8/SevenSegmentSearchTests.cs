using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day8;

namespace RFI.AdventOfCode2021.Tests.Day8
{
    [TestClass]
    public class SevenSegmentSearchTests
    {
        private const string TRAINING_INPUT = @"Day8\TrainingInput.txt";
        private const string REAL_INPUT = @"Day8\RealInput.txt";

        private readonly SevenSegmentSearch _sevenSegmentSearch = new();

        [TestMethod]
        [DataRow(26, TRAINING_INPUT)]
        [DataRow(409, REAL_INPUT)]
        public void GetCountOf_1_4_7Test(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _sevenSegmentSearch.GetCountOf_1_4_7_8(File.ReadAllLines(file)));

        [TestMethod]
        [DataRow(61229, TRAINING_INPUT)]
        [DataRow(1024649, REAL_INPUT)]
        public void GetSumOfOutputsTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _sevenSegmentSearch.GetSumOfOutputs(File.ReadAllLines(file)));
    }
}
