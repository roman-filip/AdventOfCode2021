using System.Text.RegularExpressions;

namespace RFI.AdventOfCode2021.Day5
{
    internal record Point(int Col, int Row);

    internal class VentLine
    {
        private static readonly Regex _rx = new(@"^(?<c1>\d+),(?<r1>\d+) -> (?<c2>\d+),(?<r2>\d+)$", RegexOptions.Compiled);

        public Point Start { get; set; }

        public Point End { get; set; }

        public VentLine(string ventLine)
        {
            var matches = _rx.Matches(ventLine);
            if (matches.Count != 1)
            {
                throw new Exception("Could not parse vent line");
            }

            Start = new Point(int.Parse(matches[0].Groups["c1"].Value), int.Parse(matches[0].Groups["r1"].Value));
            End = new Point(int.Parse(matches[0].Groups["c2"].Value), int.Parse(matches[0].Groups["r2"].Value));
        }

        public bool IsHorizontal()
            => Start.Row == End.Row;

        public bool IsVertical()
            => Start.Col == End.Col;

        public (int Col, int Row) GetMaxCoord()
            => (Math.Max(Start.Col, End.Col), Math.Max(Start.Row, End.Row));
    }
}
