using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFI.AdventOfCode2021.Day6;

namespace RFI.AdventOfCode2021.Tests.Day6
{
    [TestClass]
    public class LanternfishTests
    {
        private readonly Lanternfish _lanternfish = new();

        [TestMethod]
        [DataRow(26, 18, "3,4,3,1,2")]
        [DataRow(5934, 80, "3,4,3,1,2")]
        [DataRow(393019, 80, "1,4,1,1,1,1,1,1,1,4,3,1,1,3,5,1,5,3,2,1,1,2,3,1,1,5,3,1,5,1,1,2,1,2,1,1,3,1,5,1,1,1,3,1,1,1,1,1,1,4,5,3,1,1,1,1,1,1,2,1,1,1,1,4,4,4,1,1,1,1,5,1,2,4,1,1,4,1,2,1,1,1,2,1,5,1,1,1,3,4,1,1,1,3,2,1,1,1,4,1,1,1,5,1,1,4,1,1,2,1,4,1,1,1,3,1,1,1,1,1,3,1,3,1,1,2,1,4,1,1,1,1,3,1,1,1,1,1,1,2,1,3,1,1,1,1,4,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,5,1,1,1,2,2,1,1,3,5,1,1,1,1,3,1,3,3,1,1,1,1,3,5,2,1,1,1,1,5,1,1,1,1,1,1,1,2,1,2,1,1,1,2,1,1,1,1,1,2,1,1,1,1,1,5,1,4,3,3,1,3,4,1,1,1,1,1,1,1,1,1,1,4,3,5,1,1,1,1,1,1,1,1,1,1,1,1,1,5,2,1,4,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1,1,1,1,1,1,1,1,2,1,4,4,1,1,1,1,1,1,1,5,1,1,2,5,1,1,4,1,3,1,1")]
        public void GetOverlapsCountTest(int expectedPopulationSize, int days, string initialPopulation)
            => Assert.AreEqual(expectedPopulationSize, _lanternfish.GetPopulationSize(initialPopulation, days));
    }
}
