using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class BoardTools
    {
        public char[] PrintBoard(char[] board)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.Write(board[i]);
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            return board;
        }

        public char[] UpdateBoard(char[] board, int spot, char player)
        {
            board[spot] = player;

            for (int i = 0; i < 9; i++)
            {
                Console.Write(board[i]);
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            return board;
        }

        public bool CheckWin(char[] board, char player)
        {
            if (board[0] == player && board[1] == player && board[2] == player)
            {
                return true;
            }
            else if (board[3] == player && board[4] == player && board[5] == player)
            {
                return true;
            }
            else if (board[6] == player && board[7] == player && board[8] == player)
            {
                return true;
            }
            else if (board[0] == player && board[3] == player && board[6] == player)
            {
                return true;
            }
            else if (board[1] == player && board[4] == player && board[7] == player)
            {
                return true;
            }
            else if (board[2] == player && board[5] == player && board[8] == player)
            {
                return true;
            }
            else if (board[0] == player && board[4] == player && board[8] == player)
            {
                return true;
            }
            else if (board[2] == player && board[4] == player && board[6] == player)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
