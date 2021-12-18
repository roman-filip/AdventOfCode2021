namespace RFI.AdventOfCode2021.Day4
{
    internal class BingoBoard
    {
        private BoardNumber[,] _boardConfiguration;
        private int _lastNumber;

        public BingoBoard(int[,] boardConfiguration)
        {
            _boardConfiguration = new BoardNumber[boardConfiguration.GetLength(0), boardConfiguration.GetLength(1)];

            for (int i = 0; i < boardConfiguration.GetLength(0); i++)
            {
                for (int j = 0; j < boardConfiguration.GetLength(1); j++)
                {
                    _boardConfiguration[i, j] = new BoardNumber(boardConfiguration[i, j]);
                }
            }
        }

        public void MarkNumber(int number)
        {
            _lastNumber = number;

            foreach (var boardNumber in _boardConfiguration)
            {
                if (boardNumber.Number == number)
                {
                    boardNumber.Marked = true;
                    return;
                }
            }

        }

        public bool IsBingo()
            => ExistsRowBingo() || ExistsColumnBingo();

        private bool ExistsRowBingo()
        {
            for (int rowIndes = 0; rowIndes < _boardConfiguration.GetLength(0); rowIndes++)
            {
                var rowBingo = true;
                for (int columnIndex = 0; columnIndex < _boardConfiguration.GetLength(1); columnIndex++)
                {
                    rowBingo &= _boardConfiguration[rowIndes, columnIndex].Marked;
                }

                if (rowBingo)
                {
                    return true;
                }
            }

            return false;
        }

        private bool ExistsColumnBingo()
        {
            for (int columnIndex = 0; columnIndex < _boardConfiguration.GetLength(1); columnIndex++)
            {
                var columnBingo = true;
                for (int rowIndex = 0; rowIndex < _boardConfiguration.GetLength(0); rowIndex++)
                {
                    columnBingo &= _boardConfiguration[rowIndex, columnIndex].Marked;
                }

                if (columnBingo)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetScore()
        {
            if (IsBingo())
            {
                var sum = 0;

                foreach (var boardNumber in _boardConfiguration)
                {
                    if (!boardNumber.Marked)
                    {
                        sum += boardNumber.Number;
                    }
                }

                return sum * _lastNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}