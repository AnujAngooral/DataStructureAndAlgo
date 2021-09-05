using System;
using System.Collections.Generic;
using System.Text;

namespace Karat
{
    class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    var currentNumber = board[i][j];
                    if (currentNumber != '.')
                    {
                        if (!seen.Add($"{currentNumber} found in row {i}")
                            ||
                            !seen.Add($"{currentNumber} found in col {j}")
                            ||
                            !seen.Add($"{currentNumber} found in box {i / 3} - {j / 3}"))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
