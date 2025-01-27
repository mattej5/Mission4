// Use this space to write methods for the main class
using System.ComponentModel;

//The supporting class (with whichever name you choose) will:
//• Receive the “board” array from the driver class
//• Contain a method that prints the board based on the information passed to it
//• Contain a method that receives the game board array as input and returns if there is a
//winner and who it was

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Mission4
{
    internal class TicTacTools
    {
        public bool IsPossible(char[,] array, int row, int column)
        {
            bool isPossible = true;

            if (array[row - 1, column - 1] != ' ')
            {
                isPossible = false;
            }

            return isPossible;
        }

        public char[,] PrintBoard(char[,] array, int row, int column, int roundNumber)
        {
            char playerChar;

            if (roundNumber % 2 == 0)
            {
                playerChar = 'O';
            }
            else
            {
                playerChar = 'X';
            }

            Console.WriteLine("1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + array[i, j] + " ");
                }
            }

            return array;
        }

        public bool CheckWinner(char[,] array)
        {
            bool hasWinner = false;

            // Check along rows
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 1] == array[i, 0] && array[i, 2] == array[i, 0])
                {
                    hasWinner = true;
                }
            }

            // Check along columns
            for (int i = 0; i < 3; i++)
            {
                if (array[0, i] == array[1, i] && array[0, i] == array[2, i])
                {
                    hasWinner = true;
                }
            }

            // Check along diagonals
            if (array[0, 0] == array[1, 1] && array[0, 0] ==  (array[2, 2]))
            {
                hasWinner = true;
            }

            else if (array[0, 2] == array[1, 1] && array[0, 2] == (array[2, 0]))
            {
                hasWinner = true;
            }

            return hasWinner;
        }

    }
}
