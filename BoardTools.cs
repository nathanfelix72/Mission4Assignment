using System;

namespace Mission4Assignment
{
    internal class BoardTools
    {
        // Method to print the current state of the board
        public char[] PrintBoard(char[] board)
        {
            for (int i = 0; i < 9; i++)
            {
                // Print each cell in the board followed by a space
                Console.Write(board[i] + " ");

                // Add a new line after every 3 cells to display the board as a grid
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(); // Add extra space between rows for readability
                }
            }

            return board; // Return the board unchanged
        }

        // Method to update the board with a player's move
        public char[] UpdateBoard(char[] board, int spot, char player)
        {
            // Update the specified spot with the player's symbol ('X' or 'O')
            board[spot] = player;

            // Reprint the board to reflect the update
            for (int i = 0; i < 9; i++)
            {
                Console.Write(board[i] + " ");
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            return board; // Return the updated board
        }

        // Method to check if the given player has won
        public bool CheckWin(char[] board, char player)
        {
            // Check all possible winning conditions for Tic-Tac-Toe
            if (board[0] == player && board[1] == player && board[2] == player)
            {
                // Top row
                return true;
            }
            else if (board[3] == player && board[4] == player && board[5] == player)
            {
                // Middle row
                return true;
            }
            else if (board[6] == player && board[7] == player && board[8] == player)
            {
                // Bottom row
                return true;
            }
            else if (board[0] == player && board[3] == player && board[6] == player)
            {
                // Left column
                return true;
            }
            else if (board[1] == player && board[4] == player && board[7] == player)
            {
                // Middle column
                return true;
            }
            else if (board[2] == player && board[5] == player && board[8] == player)
            {
                // Right column
                return true;
            }
            else if (board[0] == player && board[4] == player && board[8] == player)
            {
                // Diagonal from top-left to bottom-right
                return true;
            }
            else if (board[2] == player && board[4] == player && board[6] == player)
            {
                // Diagonal from top-right to bottom-left
                return true;
            }
            else
            {
                // No winning condition met
                return false;
            }
        }
    }
}
