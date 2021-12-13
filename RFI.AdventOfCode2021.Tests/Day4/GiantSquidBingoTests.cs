using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RFI.AdventOfCode2021.Day4.Tests
{
    [TestClass()]
    public class GiantSquidBingoTests
    {
        private readonly GiantSquidBingo _giantSquidBingo = new();

        [TestMethod()]
        public void PlayTest_TrainingInput()
        {
            var result = _giantSquidBingo.Play(File.ReadAllLines(@"Day4\TrainingInput.txt"));
            Assert.AreEqual(4512, result);
        }

        [TestMethod()]
        public void PlayTest_RealInput()
        {
            var result = _giantSquidBingo.Play(File.ReadAllLines(@"Day4\RealInput.txt"));
            Assert.AreEqual(34506, result);
        }
    }
}