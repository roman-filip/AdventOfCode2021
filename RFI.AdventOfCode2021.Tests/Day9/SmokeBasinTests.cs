using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day9;

namespace RFI.AdventOfCode2021.Tests.Day9
{
    [TestClass]
    public class SmokeBasinTests
    {
        private const string TRAINING_INPUT = @"Day9\TrainingInput.txt";
        private const string REAL_INPUT = @"Day9\RealInput.txt";

        private readonly SmokeBasin _smokeBasin = new();

        [TestMethod]
        [DataRow(15, TRAINING_INPUT)]
        [DataRow(518, REAL_INPUT)]
        public void ComputeRiskLevelTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _smokeBasin.ComputeRiskLevel(File.ReadAllLines(file)));

        [TestMethod]
        [DataRow(1134, TRAINING_INPUT)]
        [DataRow(949905, REAL_INPUT)]
        public void ComputeLargestBasinsTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _smokeBasin.ComputeLargestBasins(File.ReadAllLines(file)));
    }
}
