using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day10;

namespace RFI.AdventOfCode2021.Tests.Day10
{
    [TestClass]
    public class SyntaxScoringTest
    {
        private const string TRAINING_INPUT = @"Day10\TrainingInput.txt";
        private const string REAL_INPUT = @"Day10\RealInput.txt";

        private readonly SyntaxScoring _syntaxScoring = new();

        [TestMethod]
        [DataRow(26397, TRAINING_INPUT)]
        [DataRow(389589, REAL_INPUT)]
        public void ComputeSyntaxErrorScoreTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _syntaxScoring.ComputeSyntaxErrorScore(File.ReadAllLines(file)));

        [TestMethod]
        [DataRow(288957, TRAINING_INPUT)]
        [DataRow(1190420163, REAL_INPUT)]
        public void ComputeAutocompleteScoreTest(int expectedCount, string file)
            => Assert.AreEqual(expectedCount, _syntaxScoring.ComputeAutocompleteScore(File.ReadAllLines(file)));
    }
}
