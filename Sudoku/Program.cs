﻿//Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

//    Each row must contain the digits 1-9 without repetition.
//    Each column must contain the digits 1-9 without repetition.
//    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

//Note:

//    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
//    Only the filled cells need to be validated according to the mentioned rules.



//Example 1:

//Input: board =
//[["5", "3", ".", ".", "7", ".", ".", ".", "."]
//, ["6", ".", ".", "1", "9", "5", ".", ".", "."]
//, [".", "9", "8", ".", ".", ".", ".", "6", "."]
//, ["8", ".", ".", ".", "6", ".", ".", ".", "3"]
//, ["4", ".", ".", "8", ".", "3", ".", ".", "1"]
//, ["7", ".", ".", ".", "2", ".", ".", ".", "6"]
//, [".", "6", ".", ".", ".", ".", "2", "8", "."]
//, [".", ".", ".", "4", "1", "9", ".", ".", "5"]
//, [".", ".", ".", ".", "8", ".", ".", "7", "9"]]
//Output: true
//Example 2:

//Input: board =
//[["8", "3", ".", ".", "7", ".", ".", ".", "."]
//, ["6", ".", ".", "1", "9", "5", ".", ".", "."]
//, [".", "9", "8", ".", ".", ".", ".", "6", "."]
//, ["8", ".", ".", ".", "6", ".", ".", ".", "3"]
//, ["4", ".", ".", "8", ".", "3", ".", ".", "1"]
//, ["7", ".", ".", ".", "2", ".", ".", ".", "6"]
//, [".", "6", ".", ".", ".", ".", "2", "8", "."]
//, [".", ".", ".", "4", "1", "9", ".", ".", "5"]
//, [".", ".", ".", ".", "8", ".", ".", "7", "9"]]
//Output: false
//Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
static bool IsValidSudoku(char[,] board)
{
    Dictionary<int, List<char>> rowDict = new Dictionary<int, List<char>>();
    Dictionary<int, List<char>> colDict = new Dictionary<int, List<char>>();
    Dictionary<List<int>, List<char>> squareDict = new Dictionary<List<int>, List<char>>();
    for(int i=0;i<9;i++)
    {
        for (int j = 0; j < 9;j++)
        {
            if (board[i, j] == '.') continue;
            if (rowDict.ContainsKey(i))
            {
                if (rowDict[i].Contains(board[i, j]))
                    return false;
            }
            if (colDict.ContainsKey(j))
            {
                if (colDict[j].Contains(board[i, j]))
                    return false;
            }
            List<int> ints = new List<int> { i /3, j /3 };
            if (squareDict.ContainsKey(ints))
            {
                if (squareDict[ints].Contains(board[i, j]))
                    return false;
            }
                if(!rowDict.ContainsKey(i)) rowDict.Add(i, new List<char>());
                if(!colDict.ContainsKey(j)) colDict.Add(j, new List<char>());
                if(!squareDict.ContainsKey(ints)) squareDict.Add(ints, new List<char>());
                rowDict[i].Add(board[i, j]);
                colDict[j].Add(board[i, j]);
                squareDict[ints].Add(board[i, j]);
        }
    }
    return true;
}

char[,] board = { { '.', '.', '.', '.', '5', '.', '.', '1', '.' }, { '.', '4', '.', '3', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '3', '.', '.', '1' }, { '8', '.', '.', '.', '.', '.', '.', '2', '.' }, { '.', '.', '2', '.', '7', '.', '.', '.', '.' }, { '.', '1', '5', '.', '.', '.', '.', '.', '.' }, { '.', '.', '.', '.', '.', '2', '.', '.', '.' }, { '.', '2', '.', '9', '.', '.', '.', '.', '.' }, { '.', '.', '4', '.', '.', '.', '.', '.', '.' } };

IsValidSudoku(board);
