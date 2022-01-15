using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RFI.AdventOfCode2021.Day5.Tests
{
    [TestClass()]
    public class HydrothermalVentureTests
    {
        private readonly HydrothermalVenture _hydrothermalVenture = new();

        [TestMethod()]
        public void GetOverlapsCountTest_TrainingInput()
            => Assert.AreEqual(5, _hydrothermalVenture.GetOverlapsCount(File.ReadAllLines(@"Day5\TrainingInput.txt")));

        [TestMethod()]
        public void GetOverlapsCountTest_RealInput()
            => Assert.AreEqual(8622, _hydrothermalVenture.GetOverlapsCount(File.ReadAllLines(@"Day5\RealInput.txt")));

        [TestMethod()]
        public void GetOverlapsWithDiagonalsCountTest_TrainingInput()
            => Assert.AreEqual(12, _hydrothermalVenture.GetOverlapsWithDiagonalsCount(File.ReadAllLines(@"Day5\TrainingInput.txt")));

        [TestMethod()]
        public void GetOverlapsWithDiagonalsCountTest_RealInput()
            => Assert.AreEqual(22037, _hydrothermalVenture.GetOverlapsWithDiagonalsCount(File.ReadAllLines(@"Day5\RealInput.txt")));
    }
}