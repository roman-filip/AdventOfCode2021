using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day4;

namespace RFI.AdventOfCode2021.Tests.Day4
{
    [TestClass]
    public class GiantSquidBingoTests
    {
        private const string TRAINING_INPUT = @"Day4\TrainingInput.txt";
        private const string REAL_INPUT = @"Day4\RealInput.txt";

        private readonly GiantSquidBingo _giantSquidBingo = new();

        [TestMethod]
        [DataRow(4512, TRAINING_INPUT)]
        [DataRow(34506, REAL_INPUT)]
        public void PlayTest(int expectedResult, string file)
        {
            var result = _giantSquidBingo.Play(File.ReadAllLines(file));
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(1924, TRAINING_INPUT)]
        [DataRow(7686, REAL_INPUT)]
        public void PlayWhenLastBoardWins(int expectedResult, string file)
        {
            var result = _giantSquidBingo.PlayWhenLastBoardWins(File.ReadAllLines(file));
            Assert.AreEqual(expectedResult, result);
        }
    }
}