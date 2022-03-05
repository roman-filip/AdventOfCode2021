using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day05;

namespace RFI.AdventOfCode2021.Tests.Day05
{
    [TestClass]
    public class HydrothermalVentureTests
    {
        private const string TRAINING_INPUT = @"Day05\TrainingInput.txt";
        private const string REAL_INPUT = @"Day05\RealInput.txt";

        private readonly HydrothermalVenture _hydrothermalVenture = new();

        [TestMethod]
        [DataRow(5, TRAINING_INPUT)]
        [DataRow(8622, REAL_INPUT)]
        public void GetOverlapsCountTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _hydrothermalVenture.GetOverlapsCount(File.ReadAllLines(file)));

        [TestMethod]
        [DataRow(12, TRAINING_INPUT)]
        [DataRow(22037, REAL_INPUT)]
        public void GetOverlapsWithDiagonalsCountTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _hydrothermalVenture.GetOverlapsWithDiagonalsCount(File.ReadAllLines(file)));
    }
}