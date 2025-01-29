using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeTools
    {
        private char[,] board;
        public TicTacToeTools(char[,] board)
        {
            this.board = board;
        }
        
        //constructor to print the board 
        public void PrintBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++) //loop through rows
            {
                for (int j = 0; j < 3; j++) //loop through cols
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Method for determining winner :)
        public char DetermineWinner()
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '-')
                    return board[i, 0]; // Row winner

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '-')
                    return board[0, i]; // Column winner
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '-')
                return board[0, 0];

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '-')
                return board[0, 2];

            //Check for a draw (if no '-' are left)
            foreach(char cell in board)
            {
                if (cell == '-')
                {
                    return ' '; //Game still ongoing
                }
            }
            
            return 'D'; //Draw
        }
    }
}
