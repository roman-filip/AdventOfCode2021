﻿namespace RFI.AdventOfCode2021.Day4
{
    internal class BoardNumber
    {
        public int Number { get; set; }
        public bool Marked { get; set; }

        public BoardNumber(int number)
        {
            Number = number;
        }
    }
}